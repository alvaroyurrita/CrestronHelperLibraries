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
   
            try
            {

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
 


            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }


    }
}