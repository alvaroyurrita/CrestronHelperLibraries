using System;
using System.Text;
using System.Collections.Generic;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace Serial_Drivers
{
    public class SerialDriverBase
    {
        #region public properties and events

        public event Action<ComPort.eComBaudRates> BaudRate_Changed;
        public ComPort.eComBaudRates BaudRate
        {
            get { return _ComPort.BaudRate;}
            set { 
                ComPortSpec.BaudRate = value;
                if (_ComPort.Registered)
                {
                    try { _ComPort.SetComPortSpec(ComPortSpec);}
                    catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the {1} specification",Name, value.ToString()); }
                    catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                }
            }
        }

        public event Action<ComPort.eComDataBits> DataBits_Changed;
        public ComPort.eComDataBits DataBits
        {
            get { return _ComPort.DataBits;}
            set { 
                ComPortSpec.DataBits = value;
                if (_ComPort.Registered)
                {
                    try { _ComPort.SetComPortSpec(ComPortSpec);}
                    catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the {1} specification",Name, value.ToString()); }
                    catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                }
            }
        }

        public event Action<ComPort.eComParityType> Parity_Changed;
        public ComPort.eComParityType Parity
        {
            get { return _ComPort.Parity;}
            set { 
                ComPortSpec.Parity = value;
                if (_ComPort.Registered)
                {
                    try { _ComPort.SetComPortSpec(ComPortSpec);}
                    catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the {1} specification",Name, value.ToString()); }
                    catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                }
            }
        }

        public event Action<ComPort.eComStopBits> StopBits_Changed;
        public ComPort.eComStopBits StopBits
        {
            get { return _ComPort.StopBits;}
            set { 
                ComPortSpec.StopBits = value;
                if (_ComPort.Registered)
                {
                    try { _ComPort.SetComPortSpec(ComPortSpec);}
                    catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the {1} specification",Name, value.ToString()); }
                    catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                }
            }
        }


        public List<ComPortPresetStrings> PresetStrings { get; set; }

        public string Name { get; private set; }

        protected StringBuilder _delimiter = new StringBuilder();
        public string delimiter 
        {
            get {return _delimiter.ToString();} 
            set {_delimiter.Length = 0; _delimiter.Append(value);}
        }

        #endregion

        #region public methods
        public void tx(string message) 
        {
            try { _ComPort.Send(message + delimiter); }
            catch (InvalidOperationException)
            { ErrorLog.Notice("Tring to send a null string through {0}",Name);}
        }

        public void SendPresetString(string Name)
        {
            var prest = PresetStrings.Find(prst => prst.Name == Name);
            if (prest != null) { _ComPort.Send(prest.Command + delimiter); }
        }

        #endregion

        #region Private Fields
        protected ComPort _ComPort;
        protected bool started;
        protected ComPort.ComPortSpec ComPortSpec;
        #endregion

        public SerialDriverBase(ComPort ComPort)
        {
             if (ComPort == null)
            {
                ErrorLog.Error("Error Creating ComPort. ComPort is null");
                return;
            }
            _ComPort =ComPort;
            Name = "Com"+_ComPort.ID;
            delimiter = "";

        }


        protected void Start()
        {
            if (!started)
            {
                started = true;

                PresetStrings = new List<ComPortPresetStrings>();

                ComPortSpec.BaudRate = ComPort.eComBaudRates.ComspecBaudRate9600;
                ComPortSpec.DataBits = ComPort.eComDataBits.ComspecDataBits8;
                ComPortSpec.StopBits = ComPort.eComStopBits.ComspecStopBits1;
                ComPortSpec.Parity = ComPort.eComParityType.ComspecParityNone;
                ComPortSpec.Protocol = ComPort.eComProtocolType.ComspecProtocolRS232;
                ComPortSpec.HardwareHandShake = ComPort.eComHardwareHandshakeType.ComspecHardwareHandshakeNone;
                ComPortSpec.SoftwareHandshake = ComPort.eComSoftwareHandshakeType.ComspecSoftwareHandshakeNone;

                if (_ComPort.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering Comport ID {0}: {1}",_ComPort.ID, _ComPort.DeviceRegistrationFailureReason);
                    return;
                }
                try { _ComPort.SetComPortSpec(ComPortSpec);}
                catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the specification"); }
                catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                _ComPort.ExtendedInformationChanged +=new ComPortExtendedInformationEvent(_ComPort_ExtendedInformationChanged);
            }
        }

        void  _ComPort_ExtendedInformationChanged(ComPort ReceivingComPort, ComPortExtendedInformationEventArgs args)
        {
            switch (args.Name)
            {
                case eComPortExtendedInformation.BaudRate:
                    if (BaudRate_Changed != null) BaudRate_Changed(BaudRate);
                    break;
                case eComPortExtendedInformation.DataBits:
                    if (DataBits_Changed != null) DataBits_Changed(DataBits);
                    break;
                case eComPortExtendedInformation.Parity:
                    if (Parity_Changed != null) Parity_Changed(Parity);
                    break;
                case eComPortExtendedInformation.StopBits:
                    if (StopBits_Changed != null) StopBits_Changed(StopBits);
                    break;
                default:
                    break;
            }
        }
    }

    public class ComPortPresetStrings
    {
        public string Name { get; set; }
        public string Command { get; set; }
        public bool Active { get; internal set; }
    }
}

