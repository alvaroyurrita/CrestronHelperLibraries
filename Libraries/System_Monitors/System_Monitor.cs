using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.Diagnostics;

namespace System_Monitors
{
    public class System_Monitor
    {
        

        #region public properties and events

        public event Action<bool> SysmonStarted_F_Changed;
        bool _SysmonStarted_F;
        public bool SysmonStarted_F
        {
            get { return _SysmonStarted_F; }
            private set 
            { 
                if (_SysmonStarted_F != value) 
                { 
                    _SysmonStarted_F = value; 
                    if (SysmonStarted_F_Changed != null) SysmonStarted_F_Changed(SysmonStarted_F); 
                } 
            }
        }
        public event Action<bool> ProcessStatisticsEnable_F_Changed;
        bool _ProcessStatisticsEnable_F;
        public bool ProcessStatisticsEnable_F
        {
            get { return _ProcessStatisticsEnable_F; }
            private set { _ProcessStatisticsEnable_F = value; SysmonStarted_F = AreStatsEnabled(); if (ProcessStatisticsEnable_F_Changed != null) ProcessStatisticsEnable_F_Changed(ProcessStatisticsEnable_F); }
        }
        public event Action<bool> CresnetStatisticsEnable_F_Changed;
        bool _CresnetStatisticsEnable_F;
        public bool CresnetStatisticsEnable_F
        {
            get { return _CresnetStatisticsEnable_F; }
            private set { _CresnetStatisticsEnable_F = value; SysmonStarted_F = AreStatsEnabled(); if (CresnetStatisticsEnable_F_Changed != null) CresnetStatisticsEnable_F_Changed(CresnetStatisticsEnable_F); }
        }
        public event Action<bool> TCP_StatisticsEnable_F_Changed;
        bool _TCP_StatisticsEnable_F_Changed;
        public bool TCP_StatisticsEnable_F
        {
            get { return _TCP_StatisticsEnable_F_Changed; }
            private set { _TCP_StatisticsEnable_F_Changed = value; SysmonStarted_F = AreStatsEnabled(); if (TCP_StatisticsEnable_F_Changed != null) TCP_StatisticsEnable_F_Changed(TCP_StatisticsEnable_F); }
        }
        public event Action<bool> CIP_StatisticsEnable_F_Changed;
        bool _CIP_StatisticsEnable_F;
        public bool CIP_StatisticsEnable_F
        {
            get { return _CIP_StatisticsEnable_F; }
            private set { _CIP_StatisticsEnable_F = value; SysmonStarted_F = AreStatsEnabled(); if (CIP_StatisticsEnable_F_Changed != null) CIP_StatisticsEnable_F_Changed(CIP_StatisticsEnable_F); }
        }
        public event Action<bool> CPU_UtilizationEnable_F_Changed;
        bool _CPU_UtilizationEnable_F;
        public bool CPU_UtilizationEnable_F
        {
            get { return _CPU_UtilizationEnable_F; }
            private set { _CPU_UtilizationEnable_F = value; SysmonStarted_F = AreStatsEnabled(); if (CPU_UtilizationEnable_F_Changed != null) CPU_UtilizationEnable_F_Changed(CPU_UtilizationEnable_F); }
        }
        public event Action<bool> ErrorLogStatisticsEnable_F_Changed;
        bool _ErrorLogStatisticsEnable_F;
        public bool ErrorLogStatisticsEnable_F
        {
            get { return _ErrorLogStatisticsEnable_F; }
            private set { _ErrorLogStatisticsEnable_F = value; SysmonStarted_F = AreStatsEnabled(); if (ErrorLogStatisticsEnable_F_Changed != null) ErrorLogStatisticsEnable_F_Changed(ErrorLogStatisticsEnable_F); }
        }

        public event Action<ushort> NumProcesses_F_Changed;
        public ushort NumProcesses_F
        {
            get { return SystemMonitor.NumberOfRunningProcesses; }
            private set { if (NumProcesses_F_Changed != null) NumProcesses_F_Changed(NumProcesses_F); }
        }
        public event Action<ushort> MaxProcesses_F_Changed;
        public ushort MaxProcesses_F
        {
            get { return SystemMonitor.MaximumNumberOfRunningProcesses; }
            private set { if (MaxProcesses_F_Changed != null) MaxProcesses_F_Changed(MaxProcesses_F); }
        }
        public event Action<ushort> CresnetRX_Count_F_Changed;
        public ushort CresnetRX_Count_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetReceivedCount; }
            private set { if (CresnetRX_Count_F_Changed != null) CresnetRX_Count_F_Changed(CresnetRX_Count_F); }
        }
        public event Action<ushort> CresnetTX_Count_F_Changed;
        public ushort CresnetTX_Count_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetTransmittedCount; }
            private set { if (CresnetTX_Count_F_Changed != null) CresnetTX_Count_F_Changed(CresnetTX_Count_F); }
        }
        public event Action<ushort> CresnetTotalCount_F_Changed;
        public ushort CresnetTotalCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetTotalCount; }
            private set { if (CresnetTotalCount_F_Changed != null) CresnetTotalCount_F_Changed(CresnetTotalCount_F); }
        }
        public event Action<ushort> MaxCresnetRX_Count_F_Changed;
        public ushort MaxCresnetRX_Count_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetMaximumReceivedCount; }
            private set { if (MaxCresnetRX_Count_F_Changed != null) MaxCresnetRX_Count_F_Changed(MaxCresnetRX_Count_F); }
        }
        public event Action<ushort> MaxCresnetTX_Count_F_Changed;
        public ushort MaxCresnetTX_Count_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetMaximumTransmittedCount; }
            private set { if (MaxCresnetTX_Count_F_Changed != null) MaxCresnetTX_Count_F_Changed(MaxCresnetTX_Count_F); }
        }
        public event Action<ushort> MaxCresnetTotalCount_F_Changed;
        public ushort MaxCresnetTotalCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetMaximumTotalCount; }
            private set { if (MaxCresnetTotalCount_F_Changed != null) MaxCresnetTotalCount_F_Changed(MaxCresnetTotalCount_F); }
        }
        public event Action<ushort> CresnetRX_UtilizationCount_F_Changed;
        public ushort CresnetRX_UtilizationCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetReceivedUtilization; }
            private set { if (CresnetRX_UtilizationCount_F_Changed != null) CresnetRX_UtilizationCount_F_Changed(CresnetRX_UtilizationCount_F); }
        }
        public event Action<ushort> CresneTX_UtilizationCount_F_Changed;
        public ushort CresnetTX_UtilizationCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetTransmittedUtilization; }
            private set { if (CresneTX_UtilizationCount_F_Changed != null) CresneTX_UtilizationCount_F_Changed(CresnetTX_UtilizationCount_F); }
        }
        public event Action<ushort> CresnetTotalUtilizationCount_F_Changed;
        public ushort CresnetTotalUtilizationCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetTotalUtilization; }
            private set { if (CresnetTotalUtilizationCount_F_Changed != null) CresnetTotalUtilizationCount_F_Changed(CresnetTotalUtilizationCount_F); }
        }
        public event Action<ushort> MaxCresnetRX_UtilizationCount_F_Changed;
        public ushort MaxCresnetRX_UtilizationCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetMaximumReceivedUtilization; }
            private set { if (MaxCresnetRX_UtilizationCount_F_Changed != null) MaxCresnetRX_UtilizationCount_F_Changed(MaxCresnetRX_UtilizationCount_F); }
        }
        public event Action<ushort> MaxCresnetTX_UtilizationCount_F_Changed;
        public ushort MaxCresnetTX_UtilizationCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetMaximumTransmittedUtilization; }
            private set { if (MaxCresnetTX_UtilizationCount_F_Changed != null) MaxCresnetTX_UtilizationCount_F_Changed(MaxCresnetTX_UtilizationCount_F); }
        }
        public event Action<ushort> MaxCresnetTotalUtilizationCount_F_Changed;
        public ushort MaxCresnetTotalUtilizationCount_F
        {
            get { return SystemMonitor.CresnetInformation.CresnetMaximumTotalUtilization; }
            private set { if (MaxCresnetTotalUtilizationCount_F_Changed != null) MaxCresnetTotalUtilizationCount_F_Changed(MaxCresnetTotalUtilizationCount_F); }
        }
        public event Action<ushort> TCP_RX_Count_F_Changed;
        public ushort TCP_RX_Count_F
        {
            get { return SystemMonitor.CIPOverTCPReceivedCount; }
            private set { if (TCP_RX_Count_F_Changed != null) TCP_RX_Count_F_Changed(TCP_RX_Count_F); }
        }
        public event Action<ushort> TCP_TX_Count_F_Changed;
        public ushort TCP_TX_Count_F
        {
            get { return SystemMonitor.CIPOverTCPTransmittedCount; }
            private set { if (TCP_TX_Count_F_Changed != null) TCP_TX_Count_F_Changed(TCP_TX_Count_F); }
        }
        public event Action<ushort> TCP_TotalCount_F_Changed;
        public ushort TCP_TotalCount_F
        {
            get { return SystemMonitor.CIPOverTCPTotalCount; }
            private set { if (TCP_TotalCount_F_Changed != null) TCP_TotalCount_F_Changed(TCP_TotalCount_F); }
        }
        public event Action<ushort> MaxTCP_RX_Count_F_Changed;
        public ushort MaxTCP_RX_Count_F
        {
            get { return SystemMonitor.CIPOverTCPMaximumReceivedCount; }
            private set { if (MaxTCP_RX_Count_F_Changed != null) MaxTCP_RX_Count_F_Changed(MaxTCP_RX_Count_F); }
        }
        public event Action<ushort> MaxTCP_TX_Count_F_Changed;
        public ushort MaxTCP_TX_Count_F
        {
            get { return SystemMonitor.CIPOverTCPMaximumTransmittedCount; }
            private set { if (MaxTCP_TX_Count_F_Changed != null) MaxTCP_TX_Count_F_Changed(MaxTCP_TX_Count_F); }
        }
        public event Action<ushort> MaxTCP_TotalCount_F_Changed;
        public ushort MaxTCP_TotalCount_F
        {
            get { return SystemMonitor.CIPOverTCPMaximumTotalCount; }
            private set { if (MaxTCP_TotalCount_F_Changed != null) MaxTCP_TotalCount_F_Changed(MaxTCP_TotalCount_F); }
        }
        public event Action<ushort> CIP_RX_Count_F_Changed;
        public ushort CIP_RX_Count_F
        {
            get { return SystemMonitor.CIPOverUDPReceivedCount; }
            private set { if (CIP_RX_Count_F_Changed != null) CIP_RX_Count_F_Changed(CIP_RX_Count_F); }
        }
        public event Action<ushort> CIP_TX_Count_F_Changed;
        public ushort CIP_TX_Count_F
        {
            get { return SystemMonitor.CIPOverUDPTransmittedCount; }
            private set { if (CIP_TX_Count_F_Changed != null) CIP_TX_Count_F_Changed(CIP_TX_Count_F); }
        }
        public event Action<ushort> CIP_TotalCount_F_Changed;
        public ushort CIP_TotalCount_F
        {
            get { return SystemMonitor.CIPOverUDPTotalCount; }
            private set { if (CIP_TotalCount_F_Changed != null) CIP_TotalCount_F_Changed(CIP_TotalCount_F); }
        }
        public event Action<ushort> MaxCIP_RX_Count_F_Changed;
        public ushort MaxCIP_RX_Count_F
        {
            get { return SystemMonitor.CIPOverUDPMaximumReceivedCount; }
            private set { if (MaxCIP_RX_Count_F_Changed != null) MaxCIP_RX_Count_F_Changed(MaxCIP_RX_Count_F); }
        }
        public event Action<ushort> MaxCIP_TX_Count_F_Changed;
        public ushort MaxCIP_TX_Count_F
        {
            get { return SystemMonitor.CIPOverUDPMaximumTransmittedCount; }
            private set { if (MaxCIP_TX_Count_F_Changed != null) MaxCIP_TX_Count_F_Changed(MaxCIP_TX_Count_F); }
        }
        public event Action<ushort> MaxCIP_TotalCount_F_Changed;
        public ushort MaxCIP_TotalCount_F
        {
            get { return SystemMonitor.CIPOverUDPMaximumTotalCount; }
            private set { if (MaxCIP_TotalCount_F_Changed != null) MaxCIP_TotalCount_F_Changed(MaxCIP_TotalCount_F); }
        }
        public event Action<ushort> CPU_Utilization_F_Changed;
        public ushort CPU_Utilization_F
        {
            get { return SystemMonitor.CPUUtilization; }
            private set { if (CPU_Utilization_F_Changed != null) CPU_Utilization_F_Changed(CPU_Utilization_F); }
        }
        public event Action<ushort> MaxCPU_Utilization_F_Changed;
        public ushort MaxCPU_Utilization_F
        {
            get { return SystemMonitor.MaximumCPUUtilization; }
            private set { if (MaxCPU_Utilization_F_Changed != null) MaxCPU_Utilization_F_Changed(MaxCPU_Utilization_F); }
        }
        public event Action<ushort> ErrorLogNoticeCount_F_Changed;
        public ushort ErrorLogNoticeCount_F
        {
            get { return SystemMonitor.ErrorLogNoticeCount; }
            private set { if (ErrorLogNoticeCount_F_Changed != null) ErrorLogNoticeCount_F_Changed(ErrorLogNoticeCount_F); }
        }
        public event Action<ushort> ErrorLogWarningCount_F_Changed;
        public ushort ErrorLogWarningCount_F
        {
            get { return SystemMonitor.ErrorLogWarningCount; }
            private set { if (ErrorLogWarningCount_F_Changed != null) ErrorLogWarningCount_F_Changed(ErrorLogWarningCount_F); }
        }
        public event Action<ushort> ErrorLogErrorCount_F_Changed;
        public ushort ErrorLogErrorCount_F
        {
            get { return SystemMonitor.ErrorLogErrorCount; }
            private set { if (ErrorLogErrorCount_F_Changed != null) ErrorLogErrorCount_F_Changed(ErrorLogErrorCount_F); }
        }

        public event Action<string> HeapFree_F_Changed;
        public string HeapFree_F
        {
            get { return SystemMonitor.RAMFree.ToString(); }
            private set { if (HeapFree_F_Changed != null) HeapFree_F_Changed(HeapFree_F); }
        }
        public event Action<string> HeapFreeMin_F_Changed;
        public string HeapFreeMin_F
        {
            get { return SystemMonitor.RAMFreeMinimum.ToString(); }
            private set { if (HeapFreeMin_F_Changed != null) HeapFreeMin_F_Changed(HeapFreeMin_F); }
        }
        public event Action<string> TotalHeapSpace_F_Changed;
        public string TotalHeapSpace_F
        {
            get { return SystemMonitor.TotalRAMSize.ToString() ; }
            private set { if (TotalHeapSpace_F_Changed != null) TotalHeapSpace_F_Changed(TotalHeapSpace_F); }
        }
        #endregion  

        #region Public Methods
        public void StartSysmon()
        {

            ProcessStatisticsEnable();
            CresnetStatisticsEnable();
            TCP_StatisticsEnable();
            CIP_StatisticsEnable();
            CPU_UtilizationEnable();
            ErrorLogStatisicsEnable();
        }

        public void StopSysmon()
        {

            ProcessStatisticsDisable();
            CresnetStatisticsDisable();
            TCP_StatisticsDisable();
            CIP_StatisticsDisable();
            CPU_UtilizationDisable();
            ErrorLogStatisicsDisable();
        }

        public void ResetMax() { SystemMonitor.ResetMaximums(); }

        private bool AreStatsEnabled()
        {
            bool result =
                _CIP_StatisticsEnable_F ||
                _CPU_UtilizationEnable_F ||
                _CresnetStatisticsEnable_F ||
                _ErrorLogStatisticsEnable_F ||
                _ProcessStatisticsEnable_F ||
                _TCP_StatisticsEnable_F_Changed;
            return result;
        }

        public void ProcessStatisticsEnable()
        {
            if (ProcessStatisticsEnable_F) return;
            ProcessStatisticsEnable_F = true;
            SystemMonitor.ProcessStatisticChange +=new ProcessStatisticChangeEventHandler(SystemMonitor_ProcessStatisticChange);
        }
        public void ProcessStatisticsDisable()
        {
            if (!ProcessStatisticsEnable_F) return;
            ProcessStatisticsEnable_F = false;
            SystemMonitor.ProcessStatisticChange -= new ProcessStatisticChangeEventHandler(SystemMonitor_ProcessStatisticChange);

        }

        public void CresnetStatisticsEnable()
        {
            if (CresnetStatisticsEnable_F) return;
            CresnetStatisticsEnable_F = true;
            SystemMonitor.CresnetInformation.CresnetStatisticChange += new CresnetStatisticChangeEventHandler(CresnetInformation_CresnetStatisticChange);
        }
        public void CresnetStatisticsDisable()
        {
            if (!CresnetStatisticsEnable_F) return;
            CresnetStatisticsEnable_F = false;
            SystemMonitor.CresnetInformation.CresnetStatisticChange -= new CresnetStatisticChangeEventHandler(CresnetInformation_CresnetStatisticChange);
        }

        public void TCP_StatisticsEnable()
        {
            if (TCP_StatisticsEnable_F) return;
            TCP_StatisticsEnable_F = true;
            SystemMonitor.CIPOverTCPStatisticChange +=new CIPStatisticChangeEventHandler(SystemMonitor_CIPOverTCPStatisticChange);
        }
        public void TCP_StatisticsDisable()
        {
            if (!TCP_StatisticsEnable_F) return;
            TCP_StatisticsEnable_F = false;
            SystemMonitor.CIPOverTCPStatisticChange -= new CIPStatisticChangeEventHandler(SystemMonitor_CIPOverTCPStatisticChange);
        }

        public void CIP_StatisticsEnable()
        {
            if (CIP_StatisticsEnable_F) return;
            CIP_StatisticsEnable_F = true;
            SystemMonitor.CIPOverUDPStatisticChange += new CIPStatisticChangeEventHandler(SystemMonitor_CIPOverTCPStatisticChange);
        }
        public void CIP_StatisticsDisable()
        {
            if (!CIP_StatisticsEnable_F) return;
            CIP_StatisticsEnable_F = false;
            SystemMonitor.CIPOverUDPStatisticChange -= new CIPStatisticChangeEventHandler(SystemMonitor_CIPOverTCPStatisticChange);
        }

        public void CPU_UtilizationEnable()
        {
            if (CPU_UtilizationEnable_F) return;
            CPU_UtilizationEnable_F = true;
            SystemMonitor.CPUStatisticChange +=new CPUStatisticChangeEventHandler(SystemMonitor_CPUStatisticChange);
        }
        public void CPU_UtilizationDisable()
        {
            if (!CPU_UtilizationEnable_F) return;
            CPU_UtilizationEnable_F = false;
            SystemMonitor.CPUStatisticChange -= new CPUStatisticChangeEventHandler(SystemMonitor_CPUStatisticChange);
        }

        public void ErrorLogStatisicsEnable()
        {
            if (ErrorLogStatisticsEnable_F) return;
            ErrorLogStatisticsEnable_F = true;
            SystemMonitor.ErrorLogStatisticChange +=new ErrorLogStatisticChangeEventHandler(SystemMonitor_ErrorLogStatisticChange);
        }
        public void ErrorLogStatisicsDisable()
        {
            if (!ErrorLogStatisticsEnable_F) return;
            ErrorLogStatisticsEnable_F = false;
            SystemMonitor.ErrorLogStatisticChange -= new ErrorLogStatisticChangeEventHandler(SystemMonitor_ErrorLogStatisticChange);
        }

        public void UpdateInterval(ushort Interval)
        {
            if (Interval >= 10 && Interval <= 65535)
            {
                SystemMonitor.SetUpdateInterval(Interval);
            }
        }
        public void CresnetStatisticsMode(eStatisticMode Mode)
        {
            SystemMonitor.CresnetInformation.SetCresnetStatisticCountMode(Mode);
        }

        public void TCP_StatisticsMode(eStatisticMode Mode)
        {
            SystemMonitor.SetCIPOverTCPStatisticCountMode(Mode);
        }
        public void CIP_StatisticsMode(eStatisticMode Mode)
        {
            SystemMonitor.SetCIPOverUDPStatisticCountMode(Mode);
        }


        #endregion

        #region Private Fields
        //Singleton
        private static System_Monitor _System_Monitor;

        #endregion

        public static System_Monitor GetSystemMonitor()
        {
            return _System_Monitor ?? (_System_Monitor = new System_Monitor());
        }

        //constructor
        private System_Monitor() {}

        void SystemMonitor_CIPOverTCPStatisticChange(CIPStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eCIPStatisticChange.MaximumReceivedCount:
                    MaxTCP_RX_Count_F = SystemMonitor.CIPOverTCPMaximumReceivedCount;
                    break;
                case eCIPStatisticChange.MaximumTotalCount:
                    MaxTCP_TotalCount_F = SystemMonitor.CIPOverTCPMaximumTotalCount;
                    break;
                case eCIPStatisticChange.MaximumTransmittedCount:
                    MaxTCP_TX_Count_F = SystemMonitor.CIPOverTCPMaximumTotalCount;
                    break;
                case eCIPStatisticChange.NoChange:
                    break;
                case eCIPStatisticChange.ReceivedCount:
                    TCP_RX_Count_F = SystemMonitor.CIPOverTCPReceivedCount;
                    break;
                case eCIPStatisticChange.TotalCount:
                    TCP_TotalCount_F = SystemMonitor.CIPOverTCPTotalCount;
                    break;
                case eCIPStatisticChange.TransmittedCount:
                    TCP_TX_Count_F = SystemMonitor.CIPOverTCPTransmittedCount;
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
                    MaxCIP_RX_Count_F = SystemMonitor.CIPOverUDPMaximumReceivedCount;
                    break;
                case eCIPStatisticChange.MaximumTotalCount:
                    MaxCIP_TotalCount_F = SystemMonitor.CIPOverUDPMaximumTotalCount;
                    break;
                case eCIPStatisticChange.MaximumTransmittedCount:
                    MaxCIP_TX_Count_F = SystemMonitor.CIPOverUDPMaximumTransmittedCount;
                    break;
                case eCIPStatisticChange.NoChange:
                    break;
                case eCIPStatisticChange.ReceivedCount:
                    CIP_RX_Count_F = SystemMonitor.CIPOverUDPReceivedCount;
                    break;
                case eCIPStatisticChange.TotalCount:
                    CIP_TotalCount_F = SystemMonitor.CIPOverUDPTotalCount;
                    break;
                case eCIPStatisticChange.TransmittedCount:
                    CIP_TX_Count_F = SystemMonitor.CIPOverUDPTransmittedCount;
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
                    MaxCPU_Utilization_F = SystemMonitor.MaximumCPUUtilization;
                    break;
                case eCPUStatisticChange.NoChange:
                    break;
                case eCPUStatisticChange.Utilization:
                    CPU_Utilization_F = SystemMonitor.CPUUtilization;
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
                    ErrorLogErrorCount_F = SystemMonitor.ErrorLogErrorCount;
                    break;
                case eErrorLogStatisticChange.NoChange:
                    break;
                case eErrorLogStatisticChange.NoticeCount:
                    ErrorLogNoticeCount_F = SystemMonitor.ErrorLogNoticeCount;
                    break;
                case eErrorLogStatisticChange.WarningCount:
                    ErrorLogWarningCount_F = SystemMonitor.ErrorLogWarningCount;
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
                    MaxProcesses_F = SystemMonitor.MaximumNumberOfRunningProcesses;
                    break;
                case eProcessStatisticChange.NoChange:
                    break;
                case eProcessStatisticChange.NumberOfRunningProcesses:
                    NumProcesses_F = SystemMonitor.NumberOfRunningProcesses; 
                    break;
                case eProcessStatisticChange.RAMFree:
                    HeapFree_F = SystemMonitor.RAMFree.ToString();
                    break;
                case eProcessStatisticChange.RAMFreeMinimum:
                    HeapFreeMin_F = SystemMonitor.RAMFreeMinimum.ToString();
                    break;
                case eProcessStatisticChange.TotalRAMSize:
                    TotalHeapSpace_F = SystemMonitor.TotalRAMSize.ToString();
                    break;
                default:
                    break;
            }
        }

        void CresnetInformation_CresnetStatisticChange(CresnetStatisticChangeEventArgs args)
        {
            switch (args.StatisticWhichChanged)
            {
                case eCresnetStatisticChange.MaximumReceivedCount:
                    MaxCresnetRX_Count_F = args.MaximumReceivedCount;
                    break;
                case eCresnetStatisticChange.MaximumReceivedUtilization:
                    MaxCresnetRX_UtilizationCount_F = args.MaximumReceivedUtilization;
                    break;
                case eCresnetStatisticChange.MaximumTotalCount:
                    MaxCresnetTotalCount_F = args.MaximumTotalCount;
                    break;
                case eCresnetStatisticChange.MaximumTotalUtilization:
                    MaxCresnetTotalUtilizationCount_F = args.MaximumTotalUtilization;
                    break;
                case eCresnetStatisticChange.MaximumTransmittedCount:
                    MaxCresnetTX_Count_F = args.MaximumTransmittedCount;
                    break;
                case eCresnetStatisticChange.MaximumTransmittedUtilization:
                    MaxCresnetTX_UtilizationCount_F = args.MaximumTransmittedUtilization;
                    break;
                case eCresnetStatisticChange.NoChange:
                    break;
                case eCresnetStatisticChange.ReceivedCount:
                    CresnetRX_Count_F = args.ReceivedCount;
                    break;
                case eCresnetStatisticChange.ReceivedUtilization:
                    CresnetRX_UtilizationCount_F = args.ReceivedUtilization;
                    break;
                case eCresnetStatisticChange.TotalCount:
                    CresnetTotalCount_F = args.TotalCount;
                    break;
                case eCresnetStatisticChange.TotalUtilization:
                    CresnetTotalUtilizationCount_F = args.TotalUtilization;
                    break;
                case eCresnetStatisticChange.TransmittedCount:
                    CresnetTX_Count_F = args.TransmittedCount;
                    break;
                case eCresnetStatisticChange.TransmittedUtilization:
                    CresnetTX_UtilizationCount_F = args.TransmittedUtilization;
                    break;
                default:
                    break;
            }

        }
    }
}

