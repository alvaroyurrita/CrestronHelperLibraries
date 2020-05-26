using System;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro.Diagnostics;
using System_Monitors;

namespace RMC3.Test_Components
{
    public static class TestSystemMonitor
    {
        private static System_Monitor _SystemMonitor;
        public static void Start(System_Monitor SystemMonitor)
        {
            _SystemMonitor = SystemMonitor;
            _SystemMonitor.CIP_RX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CIP_RX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.CIP_RX_Count_F); };
            _SystemMonitor.CIP_StatisticsEnable_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CIP_StatisticsEnable_F_Changed: {0}, {1}", value, _SystemMonitor.CIP_StatisticsEnable_F); };
            _SystemMonitor.CIP_TotalCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CIP_TotalCount_F_Changed: {0}, {1}", value, _SystemMonitor.CIP_TotalCount_F); };
            _SystemMonitor.CIP_TX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CIP_TX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.CIP_TX_Count_F); };
            _SystemMonitor.CPU_Utilization_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CPU_Utilization_F_Changed: {0}, {1}", value, _SystemMonitor.CPU_Utilization_F); };
            _SystemMonitor.CPU_UtilizationEnable_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CPU_UtilizationEnable_F_Changed: {0}, {1}", value, _SystemMonitor.CPU_UtilizationEnable_F); };
            _SystemMonitor.CresnetRX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresnetRX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetRX_Count_F); };
            _SystemMonitor.CresnetRX_UtilizationCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresnetRX_UtilizationCount_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetRX_UtilizationCount_F); };
            _SystemMonitor.CresnetStatisticsEnable_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresnetStatisticsEnable_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetStatisticsEnable_F); };
            _SystemMonitor.CresnetTotalCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresnetTotalCount_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetTotalCount_F); };
            _SystemMonitor.CresnetTotalUtilizationCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresnetTotalUtilizationCount_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetTotalUtilizationCount_F); };
            _SystemMonitor.CresnetTX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresnetTX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetTX_Count_F); };
            _SystemMonitor.CresneTX_UtilizationCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: CresneTX_UtilizationCount_F_Changed: {0}, {1}", value, _SystemMonitor.CresnetTX_UtilizationCount_F); };
            _SystemMonitor.ErrorLogErrorCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: ErrorLogErrorCount_F_Changed: {0}, {1}", value, _SystemMonitor.ErrorLogErrorCount_F); };
            _SystemMonitor.ErrorLogNoticeCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: ErrorLogNoticeCount_F_Changed: {0}, {1}", value, _SystemMonitor.ErrorLogNoticeCount_F); };
            _SystemMonitor.ErrorLogStatisticsEnable_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: ErrorLogStatisticsEnable_F_Changed: {0}, {1}", value, _SystemMonitor.ErrorLogStatisticsEnable_F); };
            _SystemMonitor.ErrorLogWarningCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: ErrorLogWarningCount_F_Changed: {0}, {1}", value, _SystemMonitor.ErrorLogWarningCount_F); };
            _SystemMonitor.HeapFree_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: HeapFree_F_Changed: {0}, {1}", value, _SystemMonitor.HeapFree_F); };
            _SystemMonitor.HeapFreeMin_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: HeapFreeMin_F_Changed: {0}, {1}", value, _SystemMonitor.HeapFreeMin_F); };
            _SystemMonitor.MaxCIP_RX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCIP_RX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCIP_RX_Count_F); };
            _SystemMonitor.MaxCIP_TotalCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCIP_TotalCount_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCIP_TotalCount_F); };
            _SystemMonitor.MaxCIP_TX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCIP_TX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCIP_TX_Count_F); };
            _SystemMonitor.MaxCPU_Utilization_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCPU_Utilization_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCPU_Utilization_F); };
            _SystemMonitor.MaxCresnetRX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCresnetRX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCresnetRX_Count_F); };
            _SystemMonitor.MaxCresnetRX_UtilizationCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCresnetRX_UtilizationCount_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCresnetRX_UtilizationCount_F); };
            _SystemMonitor.MaxCresnetTotalCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCresnetTotalCount_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCresnetTotalCount_F); };
            _SystemMonitor.MaxCresnetTotalUtilizationCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCresnetTotalUtilizationCount_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCresnetTotalUtilizationCount_F); };
            _SystemMonitor.MaxCresnetTX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCresnetTX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCresnetTX_Count_F); };
            _SystemMonitor.MaxCresnetTX_UtilizationCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxCresnetTX_UtilizationCount_F_Changed: {0}, {1}", value, _SystemMonitor.MaxCresnetTX_UtilizationCount_F); };
            _SystemMonitor.MaxProcesses_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxProcesses_F_Changed: {0}, {1}", value, _SystemMonitor.MaxProcesses_F); };
            _SystemMonitor.MaxTCP_RX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxTCP_RX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.MaxTCP_RX_Count_F); };
            _SystemMonitor.MaxTCP_TotalCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxTCP_TotalCount_F_Changed: {0}, {1}", value, _SystemMonitor.MaxTCP_TotalCount_F); };
            _SystemMonitor.MaxTCP_TX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: MaxTCP_TX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.MaxTCP_TX_Count_F); };
            _SystemMonitor.NumProcesses_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: NumProcesses_F_Changed: {0}, {1}", value, _SystemMonitor.NumProcesses_F); };
            _SystemMonitor.ProcessStatisticsEnable_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: ProcessStatisticsEnable_F_Changed: {0}, {1}", value, _SystemMonitor.ProcessStatisticsEnable_F); };
            _SystemMonitor.SysmonStarted_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: SysmonStarted_F_Changed: {0}, {1}", value, _SystemMonitor.SysmonStarted_F); };
            _SystemMonitor.TCP_RX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: TCP_RX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.TCP_RX_Count_F); };
            _SystemMonitor.TCP_StatisticsEnable_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: TCP_StatisticsEnable_F_Changed: {0}, {1}", value, _SystemMonitor.TCP_StatisticsEnable_F); };
            _SystemMonitor.TCP_TotalCount_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: TCP_TotalCount_F_Changed: {0}, {1}", value, _SystemMonitor.TCP_TotalCount_F); };
            _SystemMonitor.TCP_TX_Count_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: TCP_TX_Count_F_Changed: {0}, {1}", value, _SystemMonitor.TCP_TX_Count_F); };
            _SystemMonitor.TotalHeapSpace_F_Changed += (value) => { CrestronConsole.PrintLine("Sys Mon: TotalHeapSpace_F_Changed: {0}, {1}", value, _SystemMonitor.TotalHeapSpace_F); };

            CrestronConsole.AddNewConsoleCommand(Sysmon, "TSysmon", "Start/Stop System Monitor for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ResetMax, "TResetMax", "Reset Max Stats for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ProcessStatiscs, "TProcessStatistics", "Start/Stop Process Statistics for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CresnetStatistics, "TCresnetStatistics", "Start/Stop Cresnet Statistics for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TCPStatistics, "TTCPStatistics", "Start/Stop TCP Statistics for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CIPStatistics, "TCIPStatistics", "Start/Stop CIP Statistics for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CPUUtilization, "TCPUUtilization", "Start/Stop CPU Utilization for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ErrorLogStatistics, "TErrorLogStatistics", "Start/Stop Error Log Statistics for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(UpdateInterval, "TUpdateInterval", "Start/Stop Update Interval for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CresnetStatisticsMode, "TCresnetStatisticsMode", "Set Cresnet Statistics Mode for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TCPStatisticsMode, "TTCPStatisticsMode", "Set TCP Statistics Mode for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CIPStatisticsMode, "TCIPStatisticsMode", "Set CIP Statistics Mode for System Monitor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetStatsState, "TGetStatsState", "Get enable/disable statuses", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetAllStats, "TGetAllStats", "Get All Statistics", ConsoleAccessLevelEnum.AccessOperator);

            _SystemMonitor.StartSysmon();
            _SystemMonitor.ProcessStatisticsEnable();
            _SystemMonitor.CresnetStatisticsEnable();
            _SystemMonitor.TCP_StatisticsEnable();
            _SystemMonitor.CIP_StatisticsEnable();
            _SystemMonitor.CPU_UtilizationEnable();
            _SystemMonitor.ErrorLogStatisicsEnable();
        }
        static void GetStatsState(string State)
        {
            if (State == "")
            {
                CrestronConsole.ConsoleCommandResponse("STAT State:CIP Statistic: {0}\n\r", _SystemMonitor.CIP_StatisticsEnable_F ? "Enabled" : "Disabled");
                CrestronConsole.ConsoleCommandResponse("STAT State:CPU Utilization: {0}\n\r", _SystemMonitor.CPU_UtilizationEnable_F ? "Enabled" : "Disabled");
                CrestronConsole.ConsoleCommandResponse("STAT State:Cresnet Statistic: {0}\n\r", _SystemMonitor.CresnetStatisticsEnable_F ? "Enabled" : "Disabled");
                CrestronConsole.ConsoleCommandResponse("STAT State:Error Log Statistic: {0}\n\r", _SystemMonitor.ErrorLogStatisticsEnable_F ? "Enabled" : "Disabled");
                CrestronConsole.ConsoleCommandResponse("STAT State:Process Statistic: {0}\n\r", _SystemMonitor.ProcessStatisticsEnable_F ? "Enabled" : "Disabled");
                CrestronConsole.ConsoleCommandResponse("STAT State:System Monitor: {0}\n\r", _SystemMonitor.SysmonStarted_F ? "Enabled" : "Disabled");
                CrestronConsole.ConsoleCommandResponse("STAT State:TCP Statistic: {0}\n\r", _SystemMonitor.TCP_StatisticsEnable_F ? "Enabled" : "Disabled");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TGetAllStats"); return; }
        }
        static void GetAllStats(string State)
        {
            if (State == "")
            {
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CIP_RX_Count_F: {0}\n\r", _SystemMonitor.CIP_RX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CIP_TotalCount_F: {0}\n\r", _SystemMonitor.CIP_TotalCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CIP_TX_Count_F: {0}\n\r", _SystemMonitor.CIP_TX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CPU_Utilization_F: {0}\n\r", _SystemMonitor.CPU_Utilization_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CresnetRX_Count_F: {0}\n\r", _SystemMonitor.CresnetRX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CresnetRX_UtilizationCount_F: {0}\n\r", _SystemMonitor.CresnetRX_UtilizationCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CresnetTotalCount_F: {0}\n\r", _SystemMonitor.CresnetTotalCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CresnetTotalUtilizationCount_F: {0}\n\r", _SystemMonitor.CresnetTotalUtilizationCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CresnetTX_Count_F: {0}\n\r", _SystemMonitor.CresnetTX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP CresnetTX_UtilizationCount_F: {0}\n\r", _SystemMonitor.CresnetTX_UtilizationCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP ErrorLogErrorCount_F: {0}\n\r", _SystemMonitor.ErrorLogErrorCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP ErrorLogNoticeCount_F: {0}\n\r", _SystemMonitor.ErrorLogNoticeCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP ErrorLogWarningCount_F: {0}\n\r", _SystemMonitor.ErrorLogWarningCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP HeapFree_F: {0}\n\r", _SystemMonitor.HeapFree_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP HeapFreeMin_F: {0}\n\r", _SystemMonitor.HeapFreeMin_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCIP_RX_Count_F: {0}\n\r", _SystemMonitor.MaxCIP_RX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCIP_TotalCount_F: {0}\n\r", _SystemMonitor.MaxCIP_TotalCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCIP_TX_Count_F: {0}\n\r", _SystemMonitor.MaxCIP_TX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCPU_Utilization_F: {0}\n\r", _SystemMonitor.MaxCPU_Utilization_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCresnetRX_Count_F: {0}\n\r", _SystemMonitor.MaxCresnetRX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCresnetRX_UtilizationCount_F: {0}\n\r", _SystemMonitor.MaxCresnetRX_UtilizationCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCresnetTotalCount_F: {0}\n\r", _SystemMonitor.MaxCresnetTotalCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCresnetTotalUtilizationCount_F: {0}\n\r", _SystemMonitor.MaxCresnetTotalUtilizationCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCresnetTX_Count_F: {0}\n\r", _SystemMonitor.MaxCresnetTX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxCresnetTX_UtilizationCount_F: {0}\n\r", _SystemMonitor.MaxCresnetTX_UtilizationCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxProcesses_F: {0}\n\r", _SystemMonitor.MaxProcesses_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxTCP_RX_Count_F: {0}\n\r", _SystemMonitor.MaxTCP_RX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxTCP_TotalCount_F: {0}\n\r", _SystemMonitor.MaxTCP_TotalCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP MaxTCP_TX_Count_F: {0}\n\r", _SystemMonitor.MaxTCP_TX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP NumProcesses_F: {0}\n\r", _SystemMonitor.NumProcesses_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP TCP_RX_Count_F: {0}\n\r", _SystemMonitor.TCP_RX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP TCP_TotalCount_F: {0}\n\r", _SystemMonitor.TCP_TotalCount_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP TCP_TX_Count_F: {0}\n\r", _SystemMonitor.TCP_TX_Count_F);
                CrestronConsole.ConsoleCommandResponse("STAT:CIP TotalHeapSpace_F: {0}\n\r", _SystemMonitor.TotalHeapSpace_F);

            }
            else
            { CrestronConsole.ConsoleCommandResponse("TGetAllStats"); return; }
        }
        static int GetFirstParameterInteger(string value, string MessageHelp)
        {
            var commands = value.Split(' ');
            int Result;
            try
            {
                Result = int.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return 0xfff;
            }
            return Result;
        }
        static void Sysmon(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.StartSysmon();
            else if (State.ToUpper() == "STOP") _SystemMonitor.StopSysmon();
            else { CrestronConsole.ConsoleCommandResponse("TSysmon [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing System Monitor to {0}...\n", State);
        }
        static void ResetMax(string State)
        {
            if (State == "")
            {
                _SystemMonitor.ResetMax();
                CrestronConsole.ConsoleCommandResponse("CMD:Reseting Stats...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TResetMax"); return; }
        }
        static void ProcessStatiscs(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.ProcessStatisticsEnable();
            else if (State.ToUpper() == "STOP") _SystemMonitor.ProcessStatisticsDisable();
            else { CrestronConsole.ConsoleCommandResponse("TProcessStatistics [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Process Statistics to {0}...\n", State);
        }
        static void CresnetStatistics(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.CresnetStatisticsEnable();
            else if (State.ToUpper() == "STOP") _SystemMonitor.CresnetStatisticsDisable();
            else { CrestronConsole.ConsoleCommandResponse("TCresnetStatistics [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Cresnet Statistics to {0}...\n", State);
        }
        static void TCPStatistics(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.TCP_StatisticsEnable();
            else if (State.ToUpper() == "STOP") _SystemMonitor.TCP_StatisticsDisable();
            else { CrestronConsole.ConsoleCommandResponse("TTCPStatistics [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing TCP_ Statistics to {0}...\n", State);
        }
        static void CIPStatistics(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.CIP_StatisticsEnable();
            else if (State.ToUpper() == "STOP") _SystemMonitor.CIP_StatisticsDisable();
            else { CrestronConsole.ConsoleCommandResponse("TCIPStatistics [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing CIP Statistics to {0}...\n", State);
        }
        static void CPUUtilization(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.CPU_UtilizationEnable();
            else if (State.ToUpper() == "STOP") _SystemMonitor.CPU_UtilizationDisable();
            else { CrestronConsole.ConsoleCommandResponse("TCPUUtilization [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing CPU Utiliziation to {0}...\n", State);
        }
        static void ErrorLogStatistics(string State)
        {
            if (State.ToUpper() == "START") _SystemMonitor.ErrorLogStatisicsEnable();
            else if (State.ToUpper() == "STOP") _SystemMonitor.ErrorLogStatisicsDisable();
            else { CrestronConsole.ConsoleCommandResponse("TErrorLogStatistics [START|STOP]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Error Log Statistics to {0}...\n", State);
        }
        static void UpdateInterval(string Interval)
        {
            string MessageHelp = "TUpdateInterval" + " value (10 to 65535)";
            double interval = GetFirstParameterInteger(Interval, MessageHelp);
            if (interval >= 10 && interval <= 65535)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Setting Update Interval to {0}", interval);
                _SystemMonitor.UpdateInterval((ushort)interval);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CresnetStatisticsMode(string Mode)
        {
            string MessageHelp = "TCresnetStatisticsMode" + " [0,1]";
            int mode = GetFirstParameterInteger(Mode, MessageHelp);
            if (Enum.IsDefined(typeof(eStatisticMode), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Cresnet Statistic Mode to {0}", ((eStatisticMode)mode).ToString());
                _SystemMonitor.CresnetStatisticsMode((eStatisticMode)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void TCPStatisticsMode(string Mode)
        {
            string MessageHelp = "TTCPStatisticsMode" + " [0,1]";
            int mode = GetFirstParameterInteger(Mode, MessageHelp);
            if (Enum.IsDefined(typeof(eStatisticMode), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Cresnet Statistic Mode to {0}", ((eStatisticMode)mode).ToString());
                _SystemMonitor.TCP_StatisticsMode((eStatisticMode)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CIPStatisticsMode(string Mode)
        {
            string MessageHelp = "CIPStatisticsMode" + " [0,1]";
            int mode = GetFirstParameterInteger(Mode, MessageHelp);
            if (Enum.IsDefined(typeof(eStatisticMode), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Cresnet Statistic Mode to {0}", ((eStatisticMode)mode).ToString());
                _SystemMonitor.CIP_StatisticsMode((eStatisticMode)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}