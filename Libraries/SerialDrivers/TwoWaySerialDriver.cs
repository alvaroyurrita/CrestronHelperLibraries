using System;
using System.Text;
using System.Collections.Generic;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace Serial_Drivers
{
    public class TwoWaySerialDriver : SerialDriverBase
    {
        #region public properties and events
        public delegate void PresetStringReceivedHandler(ComPortPresetStrings PresetString, bool State);

        public event Action<string> rx_Changed;
        public string rx
        {
            get { return _ComPort.RcvdString; }
            private set { if (rx_Changed != null) rx_Changed(rx); }
        }
        public event Action<bool> cts_Changed;
        public bool cts
        {
            get { return _ComPort.CTS; }
        }

        public event Action<ComPort.eComProtocolType> Protocol_Changed;
        public ComPort.eComProtocolType Protocol
        {
            get { return _ComPort.Protocol; }
            set
            {
                bool OkRS232 = (_ComPort.Supports232 && (value == ComPort.eComProtocolType.ComspecProtocolRS232));
                bool OkRS422 = (_ComPort.Supports422 && (value == ComPort.eComProtocolType.ComspecProtocolRS422));
                bool OkRS485 = (_ComPort.Supports485 && (value == ComPort.eComProtocolType.ComspecProtocolRS485));
                if (OkRS232 || OkRS422 || OkRS485)
                {
                    ComPortSpec.Protocol = value;
                    if (_ComPort.Registered)
                    {
                        try { _ComPort.SetComPortSpec(ComPortSpec); }
                        catch (NotSupportedException) { ErrorLog.Notice("{0} Does not support the {1} specification", Name, value.ToString()); }
                        catch (InvalidOperationException) { ErrorLog.Notice("{0} Is not registered", Name); }
                    }
                }
            }
        }


        public event Action<ComPort.eComHardwareHandshakeType> HW_Handshake_Changed;
        public ComPort.eComHardwareHandshakeType HW_HandShake
        {
            get { return _ComPort.HwHandShake;}
            set
            { 
                ComPortSpec.HardwareHandShake = value;
                if (_ComPort.Registered)
                {
                    try { _ComPort.SetComPortSpec(ComPortSpec);}
                    catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the {1} specification",Name, value.ToString()); }
                    catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                }
            }
        }

        public event Action<ComPort.eComSoftwareHandshakeType> SW_Handshake_Changed;
        public ComPort.eComSoftwareHandshakeType SW_HandShake
        {
            get { return _ComPort.SwHandShake;}
            set
            { 
                ComPortSpec.SoftwareHandshake = value;
                if (_ComPort.Registered)
                {
                    try { _ComPort.SetComPortSpec(ComPortSpec);}
                    catch (NotSupportedException) {ErrorLog.Notice("{0} Does not support the {1} specification",Name, value.ToString()); }
                    catch (InvalidOperationException) {ErrorLog.Notice("{0} Is not registered",Name); }
                }
            }
        }


        public bool RTS
        {
            get { return _ComPort.RTS; }
            set 
            {
                try { _ComPort.RTS = value; }
                catch (NotSupportedException)
                { ErrorLog.Notice("RTS not supported in {0}", Name); }
            }
        }

        public event PresetStringReceivedHandler PresetStringReceived;
        #endregion


        #region public methods


        public bool GetPresetStringStatus(string Name)
        {
            var preset = PresetStrings.Find(prst => prst.Name == Name);
            return (preset != null) ? preset.Active : false;
        }
        #endregion

        private bool localstarted;

        public TwoWaySerialDriver(ComPort ComPort): base(ComPort)
        {
            if (!ComPort.Supports422)
            {
                throw new NotSupportedException(string.Format("{0} ComPort is not a Two Way Serial Driver", ComPort.DeviceName));
            } 
            Start();
            LocalStart();
        }


        private void LocalStart()
        {
            if (!localstarted)
            {
                localstarted = true;

                PresetStrings = new List<ComPortPresetStrings>();
                _ComPort.PropertyChanged += new ComPortPropertyEvent(_ComPort_PropertyChanged);
                _ComPort.ExtendedInformationChanged += new ComPortExtendedInformationEvent(_ComPort_ExtendedInformationChanged);
                var ProcessData = new ProcessedReceivedData(PresetStrings, _delimiter);
                ProcessData.rx_Changed += rxData => { if (rx_Changed != null) rx_Changed(rxData); };
                ProcessData.PresetStringReceived += (PresetString, State) => { if (PresetStringReceived != null) PresetStringReceived(PresetString, State); };
                _ComPort.SerialDataReceived += new ComPortDataReceivedEvent(ProcessData._ComPort_SerialDataReceived);
            }
        }

        void _ComPort_PropertyChanged(ComPort ReceivingComPort, ComPortPropertyEventArgs args)
        {
            switch (args.Property)
            {
                case eComPortProperty.CTS:
                    if (cts_Changed != null) cts_Changed(cts);
                    break;
                default:
                    break;
            }
        }

        void _ComPort_ExtendedInformationChanged(ComPort ReceivingComPort, ComPortExtendedInformationEventArgs args)
        {
            switch (args.Name)
            {
                case eComPortExtendedInformation.HWHandshake:
                    if (HW_Handshake_Changed != null) HW_Handshake_Changed(HW_HandShake);
                    break;
                case eComPortExtendedInformation.SWHandshake:
                    if (SW_Handshake_Changed != null) SW_Handshake_Changed(SW_HandShake);
                    break;
                case eComPortExtendedInformation.Protocol:
                    if (Protocol_Changed != null) Protocol_Changed(Protocol);
                    break;
                default:
                    break;
            }
        }
    }
}

