using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;

namespace IOPorts
{
    public class IOPort
    {
        public event Action<IOPort, eVersiportConfiguration> Configuration_Changed;
        private eVersiportConfiguration _Configuration;
        public eVersiportConfiguration Configuration
        {
            get { return _Versiport.VersiportConfiguration; }
            set 
            {
                if (_Configuration == value) return;
                if (_Versiport.VersiportConfiguration != value)
                {
                    if (ReRegisterPort() == -1) return;
                    _Versiport.SetVersiportConfiguration(value);
                    if (_Configuration == eVersiportConfiguration.AnalogInput) _Versiport.AnalogMinChange = _MinimumVoltageChange ?? 100;
                }
                _Configuration = value;
                if (Configuration_Changed != null) Configuration_Changed(this, _Configuration);
            }
        }

        public event Action<IOPort, bool?> DigitalOutput_Changed;
        private bool? _DigitalOutput;
        public bool? DigitalOutput
        {
            get 
            {
                if (_Configuration != eVersiportConfiguration.DigitalOutput) return null; ;
                return _Versiport.DigitalOut; 
            }
            set 
            {
                if (_DigitalOutput == value) return;
                _DigitalOutput = value;
                if (_Versiport.DigitalOut != value) _Versiport.DigitalOut = (bool)value;
                if (DigitalOutput_Changed != null) DigitalOutput_Changed(this, _DigitalOutput);
            }
        }

        public event Action<IOPort, bool?> DigitalInput_Changed;
        private bool? _DigitalInput;
        public bool? DigitalInput
        {
            get 
            {
                if (_Configuration != eVersiportConfiguration.DigitalInput) return null; ;
                return _Versiport.DigitalIn; 
            }
            private set
            {
                if (_DigitalInput == value) return;
                _DigitalInput = value;
                if (DigitalInput_Changed != null) DigitalInput_Changed(this, _DigitalInput);
            }
        }

        public event Action<IOPort, bool?> PullUpResistorDisabled_Changed;
        private bool? _PullUpResistorDisabled;
        public bool? PullUpResistorDisabled
        {
            get 
            {
                if (_Configuration == eVersiportConfiguration.NotSet || _Configuration == eVersiportConfiguration.DigitalOutput) return null; ;
                return _Versiport.DisablePullUpResistor; 
            }
            set
            {
                if (_Configuration == eVersiportConfiguration.DigitalOutput) return;
                if (_PullUpResistorDisabled == value) return;
                _PullUpResistorDisabled = value;
                if (_Versiport.DisablePullUpResistor != value) _Versiport.DisablePullUpResistor = (bool)value;
                if (PullUpResistorDisabled_Changed != null) PullUpResistorDisabled_Changed(this, _PullUpResistorDisabled);
            }
        }

        public event Action<IOPort, ushort?> MinimumVoltageChange_Changed;
        private ushort? _MinimumVoltageChange;
        public ushort? MinimumVoltageChange
        {
            get 
            {
                if (_Configuration != eVersiportConfiguration.AnalogInput) return null; ;
                return _Versiport.AnalogMinChange; 
            }
            set
            {
                if (_MinimumVoltageChange == value) return;
                _MinimumVoltageChange = value;
                if (_Versiport.AnalogMinChange != value) _Versiport.AnalogMinChange = (ushort)value;
                if (MinimumVoltageChange_Changed != null) MinimumVoltageChange_Changed(this, _MinimumVoltageChange);
            }
        }

        public event Action<IOPort, double?> AnalogInput_Changed;
        private double? _AnalogInput;
        public double? AnalogInput
        {
            get 
            {
                if (_Configuration != eVersiportConfiguration.AnalogInput) return null; ;
                return _AnalogInput;
            }
            private set
            {
                var _ScaledValue = AnalogScale(value);
                if (_AnalogInput == _ScaledValue) return;
                _AnalogInput = _ScaledValue;
                if (AnalogInput_Changed != null) AnalogInput_Changed(this, _AnalogInput);
            }
        }


        private double? AnalogScale(double? value)
        {
            if (_Configuration != eVersiportConfiguration.AnalogInput) return null; ;
            if (AnalogOutputScale == eAnalogOutputScale.Volts) return Math.Round(_Versiport.AnalogIn / 6553.0,1);
            if ((bool)!PullUpResistorDisabled && scale > 0 && _Configuration == eVersiportConfiguration.AnalogInput && AnalogOutputScale == eAnalogOutputScale.FullScale)
            {
                if (AnalogOutputScale == eAnalogOutputScale.Raw) return _Versiport.AnalogIn;
                double ScaledValue = Math.Round((65535.0 * _Versiport.AnalogIn / scale));
                if (ScaledValue > 65535) ScaledValue = 65535;
                return ScaledValue;
            }
            return _Versiport.AnalogIn;
        }

        public string Name { get; private set; }
        private double scale;
        private double _Resistor = 0;
        public double Resistor 
        { 
            get {return _Resistor;}
            set 
            {
                _Resistor = value;
                scale = (688117 * _Resistor) / (23 * _Resistor + 42.0);
                AnalogInput = _Versiport.AnalogIn; 
            }
        }

        public eAnalogOutputScale AnalogOutputScale { get; set; }

        public uint Number { get; private set; }

        private Versiport _Versiport;


        public IOPort(Versiport Versiport)
        {
            if (Versiport == null)
            {
                ErrorLog.Error("Error Creating IOPort. Versiport is null");
                return;
            }
            _Versiport = Versiport;
            if (ReRegisterPort() == -1) return;
            Name = "IOPort" + _Versiport.ID;
            Number = _Versiport.ID;
            AnalogOutputScale = eAnalogOutputScale.Raw;
            _Versiport.VersiportChange += new VersiportEventHandler(_Versiport_VersiportChange);

        }

        private int ReRegisterPort()
        {
            if (_Versiport.Registered)
            {
                if (_Versiport.UnRegister() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Unregistering IOPort ID {0}: {1}", _Versiport.ID, _Versiport.DeviceRegistrationFailureReason);
                    return -1;
                }
            }
            if (_Versiport.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
            {
                ErrorLog.Error("Error Registering IOPort ID {0}: {1}", _Versiport.ID, _Versiport.DeviceRegistrationFailureReason);
                return -1;
            }
            _Configuration = _Versiport.VersiportConfiguration;
            return 0;
        }

        void _Versiport_VersiportChange(Versiport port, VersiportEventArgs args)
        {
            switch (args.Event)
            {
                case eVersiportEvent.AnalogInChange:
                    AnalogInput = port.AnalogIn;
                    break;
                case eVersiportEvent.AnalogMinChangeChange:
                    MinimumVoltageChange = port.AnalogMinChange;
                    break;
                case eVersiportEvent.DigitalInChange:
                    DigitalInput = port.DigitalIn;
                    break;
                case eVersiportEvent.DigitalOutChange:
                    DigitalOutput = port.DigitalOut;
                    break;
                case eVersiportEvent.DisablePullUpResistorChange:
                    PullUpResistorDisabled = port.DisablePullUpResistor;
                    break;
                case eVersiportEvent.NA:
                    break;
                case eVersiportEvent.VersiportConfigurationChange:
                    Configuration = port.VersiportConfiguration;
                    break;
                default:
                    break;
            }
        }


    }
}