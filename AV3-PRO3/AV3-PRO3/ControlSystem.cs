using System;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       	// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading
using Crestron.SimplSharpPro.Diagnostics;		    	// For System Monitor Access
using Crestron.SimplSharpPro.DeviceSupport;         	// For Generic Device Support
using Crestron.SimplSharp.CrestronIO;
using Crestron.SimplSharpPro.ThreeSeriesCards;


namespace AV3_PRO3
{
    public class ControlSystem : CrestronControlSystem
    {
        #region global variables: CP3 OnBoard Devices
        public ComPort Com01;
        public ComPort Com02;
        public ComPort Com03;
        public ComPort Com04;
        public ComPort Com05;
        public ComPort Com06;
        public Versiport Versiport1;
        public Versiport Versiport2;
        public Versiport Versiport3;
        public Versiport Versiport4;
        public Versiport Versiport5;
        public Versiport Versiport6;
        public Versiport Versiport7;
        public Versiport Versiport8;
        public Relay Relay1;
        public Relay Relay2;
        public Relay Relay3;
        public Relay Relay4;
        public Relay Relay5;
        public Relay Relay6;
        public Relay Relay7;
        public Relay Relay8;
        public IROutputPort IR1;
        public IROutputPort IR2;
        public IROutputPort IR3;
        public IROutputPort IR4;
        public IROutputPort IR5;
        public IROutputPort IR6;
        public IROutputPort IR7;
        public IROutputPort IR8;
        public UsbHid USBHid1;
        #endregion

        #region Add-On Cards
        public C3com3 ComPortCard;
        public C3io16 VersiPortCard;
        public C3ir8 IRCard;
        public C3ry16 RelayCard16;
        public C3ry8 RelayCard8;

        //Extra IOs.  Only showing one.  Add as necessary
        public ComPort Com07;
        public Versiport Versiport9;
        public Relay Relay9;
        public IROutputPort IR9;
        #endregion  

        //constructor
        public ControlSystem()
            : base()
        {



            string DeviceType = this.ToString();
            if (DeviceType != "AV3.ControlSystem" && DeviceType != "PRO3.ControlSystem")
            {
                ErrorLog.Error("This program is for a CP3 Control System");
                ErrorLog.Error("Terminating Execution");
                throw new NotSupportedException();
            }

            #region Onboard Devices
            //CP3 onboard devices
            Com01 = this.ComPorts[1];
            Com02 = this.ComPorts[2];
            Com03 = this.ComPorts[3];
            Com03 = this.ComPorts[4];
            Com03 = this.ComPorts[5];
            Com03 = this.ComPorts[6];
            Versiport1 = this.VersiPorts[1];
            Versiport2 = this.VersiPorts[2];
            Versiport3 = this.VersiPorts[3];
            Versiport4 = this.VersiPorts[4];
            Versiport5 = this.VersiPorts[5];
            Versiport6 = this.VersiPorts[6];
            Versiport7 = this.VersiPorts[7];
            Versiport8 = this.VersiPorts[8];
            Relay1 = this.RelayPorts[1];
            Relay2 = this.RelayPorts[2];
            Relay3 = this.RelayPorts[3];
            Relay4 = this.RelayPorts[4];
            Relay5 = this.RelayPorts[5];
            Relay6 = this.RelayPorts[6];
            Relay7 = this.RelayPorts[7];
            Relay8 = this.RelayPorts[8];
            IR1 = this.IROutputPorts[1];
            IR2 = this.IROutputPorts[2];
            IR3 = this.IROutputPorts[3];
            IR4 = this.IROutputPorts[4];
            IR5 = this.IROutputPorts[5];
            IR6 = this.IROutputPorts[6];
            IR7 = this.IROutputPorts[7];
            IR8 = this.IROutputPorts[8];
            USBHid1 = this.UsbHids[1];
            #endregion

            #region OnBoardCards
            // Uncomment and modify accordingly
            ComPortCard = new C3com3(1, this);
            VersiPortCard = new C3io16(2, this);
            IRCard = new C3ir8(3, this);
            RelayCard8 = new C3ry8(1, this);
            RelayCard16 = new C3ry16(2, this);
            #endregion
            
            try
            {
                Thread.MaxNumberOfUserThreads = 20;

                #region Crestron Environment
                CrestronEnvironment.SystemEventHandler += new SystemEventHandler(ControlSystem_ControllerSystemEventHandler);
                CrestronEnvironment.ProgramStatusEventHandler += new ProgramStatusEventHandler(ControlSystem_ControllerProgramEventHandler);
                CrestronEnvironment.EthernetEventHandler += new EthernetEventHandler(ControlSystem_ControllerEthernetEventHandler);
                #endregion

                #region System Monitor Event Handlers
                SystemMonitor.CIPOverTCPStatisticChange += new CIPStatisticChangeEventHandler(SystemMonitor_CIPOverTCPStatisticChange);
                SystemMonitor.CIPOverUDPStatisticChange += new CIPStatisticChangeEventHandler(SystemMonitor_CIPOverUDPStatisticChange);
                SystemMonitor.CPUStatisticChange += new CPUStatisticChangeEventHandler(SystemMonitor_CPUStatisticChange);
                SystemMonitor.ErrorLogStatisticChange += new ErrorLogStatisticChangeEventHandler(SystemMonitor_ErrorLogStatisticChange);
                SystemMonitor.ProcessStatisticChange += new ProcessStatisticChangeEventHandler(SystemMonitor_ProcessStatisticChange);
                SystemMonitor.ProgramChange += new ProgramStateChangeEventHandler(SystemMonitor_ProgramChange);
                SystemMonitor.TimeZoneInformation.TimeZoneChange += new TimeZoneChangeEventHandler(TimeZoneInformation_TimeZoneChange);
                SystemMonitor.CresnetInformation.CresnetPowerChange += new CresnetPowerEventHandler(CresnetInformation_CresnetPowerChange);
                #endregion
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in the constructor: {0}", e.Message);
            }

        }


        #region System Monitor Event Data Handling

        void ControlSystem_ControllerEthernetEventHandler(EthernetEventArgs ethernetEventArgs)
        {
            switch (ethernetEventArgs.EthernetEventType)
            {
                case (eEthernetEventType.LinkDown):
                    if (ethernetEventArgs.EthernetAdapter == EthernetAdapterType.EthernetLANAdapter)
                    {
                    }
                    break;
                case (eEthernetEventType.LinkUp):
                    if (ethernetEventArgs.EthernetAdapter == EthernetAdapterType.EthernetLANAdapter)
                    {
                    }
                    break;
            }
        }

        void ControlSystem_ControllerProgramEventHandler(eProgramStatusEventType programStatusEventType)
        {
            switch (programStatusEventType)
            {
                case (eProgramStatusEventType.Paused):
                    break;
                case (eProgramStatusEventType.Resumed):
                    break;
                case (eProgramStatusEventType.Stopping):
                    break;
            }

        }

        void ControlSystem_ControllerSystemEventHandler(eSystemEventType systemEventType)
        {
            switch (systemEventType)
            {
                case (eSystemEventType.DiskInserted):
                    break;
                case (eSystemEventType.DiskRemoved):
                    break;
                case (eSystemEventType.Rebooting):
                    break;
            }

        }

        void SystemMonitor_CIPOverTCPStatisticChange(CIPStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eCIPStatisticChange.MaximumReceivedCount:
                    break;
                case eCIPStatisticChange.MaximumTotalCount:
                    break;
                case eCIPStatisticChange.MaximumTransmittedCount:
                    break;
                case eCIPStatisticChange.NoChange:
                    break;
                case eCIPStatisticChange.ReceivedCount:
                    break;
                case eCIPStatisticChange.TotalCount:
                    break;
                case eCIPStatisticChange.TransmittedCount:
                    break;
                default:
                    break;
            }
        }

        void SystemMonitor_CIPOverUDPStatisticChange(CIPStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eCIPStatisticChange.MaximumReceivedCount:
                    break;
                case eCIPStatisticChange.MaximumTotalCount:
                    break;
                case eCIPStatisticChange.MaximumTransmittedCount:
                    break;
                case eCIPStatisticChange.NoChange:
                    break;
                case eCIPStatisticChange.ReceivedCount:
                    break;
                case eCIPStatisticChange.TotalCount:
                    break;
                case eCIPStatisticChange.TransmittedCount:
                    break;
                default:
                    break;
            }
        }

        void SystemMonitor_CPUStatisticChange(CPUStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eCPUStatisticChange.MaximumUtilization:
                    break;
                case eCPUStatisticChange.NoChange:
                    break;
                case eCPUStatisticChange.Utilization:
                    break;
                default:
                    break;
            }
        }

        void SystemMonitor_ErrorLogStatisticChange(ErrorLogStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eErrorLogStatisticChange.ErrorCount:
                    break;
                case eErrorLogStatisticChange.NoChange:
                    break;
                case eErrorLogStatisticChange.NoticeCount:
                    break;
                case eErrorLogStatisticChange.WarningCount:
                    break;
                default:
                    break;
            }
        }

        void SystemMonitor_ProcessStatisticChange(ProcessStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eProcessStatisticChange.MaximumNumberOfRunningProcesses:
                    break;
                case eProcessStatisticChange.NoChange:
                    break;
                case eProcessStatisticChange.NumberOfRunningProcesses:
                    break;
                case eProcessStatisticChange.RAMFree:
                    break;
                case eProcessStatisticChange.RAMFreeMinimum:
                    break;
                case eProcessStatisticChange.TotalRAMSize:
                    break;
                default:
                    break;
            }
        }

        void SystemMonitor_ProgramChange(Program sender, ProgramEventArgs args)
        {
            var ProgNumber = args.ProgramNumber;

            switch (args.EventType)
            {
                case eProgramChangeEventType.NoChange:
                    break;
                case eProgramChangeEventType.OperatingState:
                    break;
                case eProgramChangeEventType.RegistrationState:
                    break;
                default:
                    break;
            }

            switch (args.OperatingState)
            {
                case eProgramOperatingState.NotAvailable:
                    break;
                case eProgramOperatingState.Start:
                    break;
                case eProgramOperatingState.Stop:
                    break;
                default:
                    break;
            }

            switch (args.RegistrationState)
            {
                case eProgramRegistrationState.NotAvailable:
                    break;
                case eProgramRegistrationState.Register:
                    break;
                case eProgramRegistrationState.Unregister:
                    break;
                default:
                    break;
            }
        }

        void TimeZoneInformation_TimeZoneChange(TimeZoneEventArgs args)
        {

            throw new NotImplementedException();
        }

        void CresnetInformation_CresnetPowerChange(CresnetPowerEventArgs args)
        {
            switch (args.CresnetPowerEventType)
            {
                case eCresnetPowerEventType.Breaker:
                    break;
                case eCresnetPowerEventType.Current:
                    break;
                case eCresnetPowerEventType.None:
                    break;
                case eCresnetPowerEventType.Power:
                    break;
                case eCresnetPowerEventType.Voltage:
                    break;
                default:
                    break;
            }

            switch (args.BreakerStatus)
            {
                case eBreakerStatus.Closed:
                    break;
                case eBreakerStatus.NotAvailable:
                    break;
                case eBreakerStatus.Open:
                    break;
                default:
                    break;
            }

        }
        #endregion

        public override void InitializeSystem()
        {


            try
            {
                #region ComPorts Initialization  and Registration
                
                ComPort.ComPortSpec ComSpecs = new ComPort.ComPortSpec();
                /*
                //Com01 and Com02 support hardware handshake
                if (Com01.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registration Comport{0}: {1}",Com01.ID, Com01.DeviceRegistrationFailureReason);
                }
                else
                {
                    ComSpecs.BaudRate = ComPort.eComBaudRates.ComspecBaudRate115200;
                    ComSpecs.DataBits = ComPort.eComDataBits.ComspecDataBits8;
                    ComSpecs.StopBits = ComPort.eComStopBits.ComspecStopBits1;
                    ComSpecs.Protocol = ComPort.eComProtocolType.ComspecProtocolRS232;
                    ComSpecs.HardwareHandShake = ComPort.eComHardwareHandshakeType.ComspecHardwareHandshakeNone;
                    ComSpecs.SoftwareHandshake = ComPort.eComSoftwareHandshakeType.ComspecSoftwareHandshakeNone;
                    ComSpecs.Parity = ComPort.eComParityType.ComspecParityNone;
                    ComSpecs.ReportCTSChanges = true;
                    Com01.SetComPortSpec(ComSpecs);
                    Com01.SerialDataReceived += new ComPortDataReceivedEvent(Com01_SerialDataReceived);
                    Com01.PropertyChanged +=new ComPortPropertyEvent(Com01_PropertyChanged);
                }

                if (Com02.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registration Comport{0}: {1}", Com02.ID, Com02.DeviceRegistrationFailureReason);
                }
                else
                {
                    ComSpecs.BaudRate = ComPort.eComBaudRates.ComspecBaudRate115200;
                    ComSpecs.DataBits = ComPort.eComDataBits.ComspecDataBits8;
                    ComSpecs.StopBits = ComPort.eComStopBits.ComspecStopBits1;
                    ComSpecs.Protocol = ComPort.eComProtocolType.ComspecProtocolRS232;
                    ComSpecs.HardwareHandShake = ComPort.eComHardwareHandshakeType.ComspecHardwareHandshakeNone;
                    ComSpecs.SoftwareHandshake = ComPort.eComSoftwareHandshakeType.ComspecSoftwareHandshakeNone;
                    ComSpecs.Parity = ComPort.eComParityType.ComspecParityNone;
                    ComSpecs.ReportCTSChanges = true;
                    Com02.SetComPortSpec(ComSpecs);
                    Com02.SerialDataReceived += new ComPortDataReceivedEvent(Com02_SerialDataReceived);
                    Com02.PropertyChanged +=new ComPortPropertyEvent(Com01_PropertyChanged);
                } 
                
                //Com03 and Com06 dont support hardware handshake. duplicate as necessary.
                
                if (Com03.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registration Comport{0}: {1}", Com03.ID, Com03.DeviceRegistrationFailureReason);
                }
                else
                {
                    ComSpecs.BaudRate = ComPort.eComBaudRates.ComspecBaudRate115200;
                    ComSpecs.DataBits = ComPort.eComDataBits.ComspecDataBits8;
                    ComSpecs.StopBits = ComPort.eComStopBits.ComspecStopBits1;
                    ComSpecs.Protocol = ComPort.eComProtocolType.ComspecProtocolRS232;
                    ComSpecs.SoftwareHandshake = ComPort.eComSoftwareHandshakeType.ComspecSoftwareHandshakeNone;
                    ComSpecs.Parity = ComPort.eComParityType.ComspecParityNone;
                    ComSpecs.ReportCTSChanges = true;
                    Com03.SetComPortSpec(ComSpecs);
                    Com03.SerialDataReceived += new ComPortDataReceivedEvent(Com03_SerialDataReceived);
                }
                */

                #endregion

                #region Versiports Initialization  and Registration
                //Duplicate or make into a collection as necesary
                eVersiportConfiguration VersiportConfiguration;
                /*
                if (Versiport1.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering Versiport {0}: {1}:", Versiport1.ID, Versiport1.DeviceRegistrationFailureReason);
                }
                else
                {
                    VersiportConfiguration = eVersiportConfiguration.AnalogInput;
                    Versiport1.DisablePullUpResistor = false;
                    Versiport1.AnalogMinChange = 6553; // for 1 V minimum change (0 (0V) to 65535 (10V) )
                    Versiport1.SetVersiportConfiguration(VersiportConfiguration);
                    Versiport1.VersiportChange += new VersiportEventHandler(Versiport1_VersiportChange);
                }
                */

                #endregion

                #region Relays Initialization and Registration
                //Duplicate or make into a collection as necesary
                /*
                if (Relay1.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering Relay {0}: {1}:", Relay1.ID, Relay1.DeviceRegistrationFailureReason);
                }
                else
                {
                    Relay1.StateChange += new RelayEventHandler(Relay1_StateChange);
                }
                */
                #endregion

                #region IR Output ports Initialization and Registration
                //Duplicate or make into a collection as necesary
                /*
                if (IR1.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering IR Output Port {0}: {1}:", IR1.ID, IR1.DeviceRegistrationFailureReason);

                }
                else
                {

                    //use when for IR
                    string IRDriverFileName = string.Format("{0}\\filename.IR", Directory.GetApplicationDirectory());
                    IR1.LoadIRDriver(IRDriverFileName);
                    foreach (string s in IR1.AvailableStandardIRCmds())
                    {
                        CrestronConsole.PrintLine("Standard IR Command: {0}", s);
                    }
                    foreach (string s in IR1.AvailableIRCmds())
                    {
                        CrestronConsole.PrintLine("IR Command: {0}", s);
                    }

                    //use for serial
                    IR1.SetIRSerialSpec(eIRSerialBaudRates.ComspecBaudRate115200,
                        eIRSerialDataBits.ComspecDataBits7,
                        eIRSerialParityType.ComspecParityNone,
                        eIRSerialStopBits.ComspecStopBits1,
                        System.Text.Encoding.ASCII);
                }
                */
                #endregion

                #region USBHID
                /*
                if (USBHid1.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering USB Output Port {0}: {1}:", USBHid1.ID, USBHid1.RegistrationFailureReason);
                }
                else
                {

                    USBHid1.BaseEvent += new BaseEventHandler(USBHid1_BaseEvent);
                    USBHid1.IpInformationChange += new IpInformationChangeEventHandler(USBHid1_IpInformationChange);
                    USBHid1.OnlineStatusChange += new OnlineStatusChangeEventHandler(USBHid1_OnlineStatusChange);
                }
                 */
                #endregion

            #region Additonal Cards
                //Additional Comports. Uncoment and moddify as neccesary.
                /*
                if (ComPortCard.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering ComPortCard Output Port {0}: {1}:", ComPortCard.ID, ComPortCard.RegistrationFailureReason);
                }
                else
                {
                    Com07 = ComPortCard.ComPorts[1];
                    if (Com07.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                    {
                        ErrorLog.Error("Error Registration Comport{0}: {1}", Com07.ID, Com07.DeviceRegistrationFailureReason);
                    }
                    else
                    {
                        ComSpecs.BaudRate = ComPort.eComBaudRates.ComspecBaudRate115200;
                        ComSpecs.DataBits = ComPort.eComDataBits.ComspecDataBits8;
                        ComSpecs.StopBits = ComPort.eComStopBits.ComspecStopBits1;
                        ComSpecs.Protocol = ComPort.eComProtocolType.ComspecProtocolRS232;
                        ComSpecs.HardwareHandShake = ComPort.eComHardwareHandshakeType.ComspecHardwareHandshakeNone;
                        ComSpecs.SoftwareHandshake = ComPort.eComSoftwareHandshakeType.ComspecSoftwareHandshakeNone;
                        ComSpecs.Parity = ComPort.eComParityType.ComspecParityNone;
                        ComSpecs.ReportCTSChanges = true;
                        Com07.SetComPortSpec(ComSpecs);
                        Com07.SerialDataReceived += new ComPortDataReceivedEvent(Com07_SerialDataReceived);
                        Com07.PropertyChanged += new ComPortPropertyEvent(Com07_PropertyChanged);
                    }

                }
                 */

                /*
                //Additional Versiports. Uncoment and modify as neccesary.
                if (VersiPortCard.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering ComPortCard Output Port {0}: {1}:", VersiPortCard.ID, VersiPortCard.RegistrationFailureReason);
                }
                else
                {
                    Versiport9 = VersiPortCard.VersiPorts[1];
                    if (Versiport9.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                    {
                        ErrorLog.Error("Error Registering Versiport {0}: {1}:", Versiport9.ID, Versiport9.DeviceRegistrationFailureReason);
                    }
                    else
                    {
                        VersiportConfiguration = eVersiportConfiguration.AnalogInput;
                        Versiport9.DisablePullUpResistor = false;
                        Versiport9.AnalogMinChange = 6553; // for 1 V minimum change (0 (0V) to 65535 (10V) )
                        Versiport9.SetVersiportConfiguration(VersiportConfiguration);
                        Versiport9.VersiportChange += new VersiportEventHandler(Versiport9_VersiportChange);
                    }

                }
                 */

                /*
                //Additional IR Ports. Uncoment and modify as neccesary.
                if (IRCard.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering ComPortCard Output Port {0}: {1}:", IRCard.ID, IRCard.RegistrationFailureReason);
                }
                else
                {
                    IR9 = IRCard.IROutputPorts[1];
                    if (IR9.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                    {
                        ErrorLog.Error("Error Registering Versiport {0}: {1}:", IR9.ID, IR9.DeviceRegistrationFailureReason);
                    }
                    else
                    {
                        //use when for IR
                        string IRDriverFileName = string.Format("{0}\\filename.IR", Directory.GetApplicationDirectory());
                        IR1.LoadIRDriver(IRDriverFileName);
                        foreach (string s in IR1.AvailableStandardIRCmds())
                        {
                            CrestronConsole.PrintLine("Standard IR Command: {0}", s);
                        }
                        foreach (string s in IR1.AvailableIRCmds())
                        {
                            CrestronConsole.PrintLine("IR Command: {0}", s);
                        }

                        //use for serial
                        IR1.SetIRSerialSpec(eIRSerialBaudRates.ComspecBaudRate115200,
                            eIRSerialDataBits.ComspecDataBits7,
                            eIRSerialParityType.ComspecParityNone,
                            eIRSerialStopBits.ComspecStopBits1,
                            System.Text.Encoding.ASCII);
                    }
                }
                 */

                /*
                //Additional Relay Ports. Uncoment and modify as neccesary. Showing for 8 relay card only. Modify as necessary
                if (RelayCard8.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering ComPortCard Output Port {0}: {1}:", RelayCard8.ID, RelayCard8.RegistrationFailureReason);
                }
                else
                {
                    Relay9 = RelayCard8.RelayPorts[1];
                    if (Relay9.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                    {
                        ErrorLog.Error("Error Registering Versiport {0}: {1}:", Relay9.ID, Relay9.DeviceRegistrationFailureReason);
                    }
                    else
                    {
                        Relay9.StateChange += new RelayEventHandler(Relay9_StateChange);

                    }
                }
                 */
            #endregion


            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }

        #region ComPort Event Data Handling
        void Com01_SerialDataReceived(ComPort ReceivingComPort, ComPortSerialDataEventArgs args)
        {
            //throw new NotImplementedException();
        }
        void Com01_PropertyChanged(ComPort ReceivingComPort, ComPortPropertyEventArgs args)
        {
            switch (args.Property)
            {
                case eComPortProperty.CD:
                    break;
                case eComPortProperty.CTS:
                    break;
                case eComPortProperty.CTSFeedback:
                    break;
                case eComPortProperty.DSR:
                    break;
                case eComPortProperty.NoChange:
                    break;
                case eComPortProperty.PresentFeedback:
                    break;
                case eComPortProperty.RING:
                    break;
                case eComPortProperty.RTSFeedback:
                    break;
                default:
                    break;
            }
        }
        void Com07_PropertyChanged(ComPort ReceivingComPort, ComPortPropertyEventArgs args)
        {
            switch (args.Property)
            {
                case eComPortProperty.CD:
                    break;
                case eComPortProperty.CTS:
                    break;
                case eComPortProperty.CTSFeedback:
                    break;
                case eComPortProperty.DSR:
                    break;
                case eComPortProperty.NoChange:
                    break;
                case eComPortProperty.PresentFeedback:
                    break;
                case eComPortProperty.RING:
                    break;
                case eComPortProperty.RTSFeedback:
                    break;
                default:
                    break;
            }
        }

        void Com02_SerialDataReceived(ComPort ReceivingComPort, ComPortSerialDataEventArgs args)
        {
            //throw new NotImplementedException();
        }
        void Com03_SerialDataReceived(ComPort ReceivingComPort, ComPortSerialDataEventArgs args)
        {
            //throw new NotImplementedException();
        }

        void Com07_SerialDataReceived(ComPort ReceivingComPort, ComPortSerialDataEventArgs args)
        {
            //throw new NotImplementedException();
        }
        #endregion

        #region VersiPort Event Data Handling
        //Duplicate or consolidate as necesary.
        void Versiport1_VersiportChange(Versiport port, VersiportEventArgs args)
        {
            switch (args.Event)
            {
                case eVersiportEvent.AnalogInChange:
                    break;
                case eVersiportEvent.AnalogMinChangeChange:
                    break;
                case eVersiportEvent.DigitalInChange:
                    break;
                case eVersiportEvent.DigitalOutChange:
                    break;
                case eVersiportEvent.DisablePullUpResistorChange:
                    break;
                case eVersiportEvent.NA:
                    break;
                case eVersiportEvent.VersiportConfigurationChange:
                    break;
                default:
                    break;
            }
        }

        void Versiport9_VersiportChange(Versiport port, VersiportEventArgs args)
        {
            switch (args.Event)
            {
                case eVersiportEvent.AnalogInChange:
                    break;
                case eVersiportEvent.AnalogMinChangeChange:
                    break;
                case eVersiportEvent.DigitalInChange:
                    break;
                case eVersiportEvent.DigitalOutChange:
                    break;
                case eVersiportEvent.DisablePullUpResistorChange:
                    break;
                case eVersiportEvent.NA:
                    break;
                case eVersiportEvent.VersiportConfigurationChange:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Relay Event Data Handling
        void Relay1_StateChange(Relay relay, RelayEventArgs args)
        {
            switch (args.State)
            {
                default:
                    break;
            }
        }

        void Relay9_StateChange(Relay relay, RelayEventArgs args)
        {
            switch (args.State)
            {
                default:
                    break;
            }
        }
        #endregion

        #region USBHID Event Data Handling
        void USBHid1_BaseEvent(GenericBase device, BaseEventArgs args)
        {
            switch (args.EventId)
            {
                case UsbHid.CountryCodeFeedbackEventId:
                    break;
                case UsbHid.ManufacturerFeedbackEventId:
                    break;
                case UsbHid.ProductFeedbackEventId:
                    break;
                case UsbHid.SerialNumberFeedbackEventId:
                    break;
                case UsbHid.ReportDescriptorFeedbackEventId:
                    break;
                case UsbHid.InputReportFeedbackEventId:
                    break;
                case UsbHid.FeatureReportFeedbackEventId:
                    break;
                default:
                    break;
            }
        }

        void USBHid1_IpInformationChange(GenericBase currentDevice, ConnectedIpEventArgs args)
        {
            //throw new NotImplementedException();
        }
        void USBHid1_OnlineStatusChange(GenericBase currentDevice, OnlineOfflineEventArgs args)
        {
            //throw new NotImplementedException();
        }
        #endregion

    }
}