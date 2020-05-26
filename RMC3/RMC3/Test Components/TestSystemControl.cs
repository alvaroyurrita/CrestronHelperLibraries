using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.Diagnostics;
using System_Monitors;

namespace RMC3.Test_Components
{
    public class TestSystemControl
    {
        private static System_Control _SystemControl;
        public static void Start(System_Control SystemControl)
        {
            _SystemControl = SystemControl;

            _SystemControl.CurrentTimeZone_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: CurrentTimeZone_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.OSD_InSetup_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: OSD_InSetup_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
 
            _SystemControl.Program1_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program1_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program1_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program1_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program1_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program1_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program1_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program1_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program2_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program2_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program2_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program2_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program2_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program2_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program2_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program2_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program3_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program3_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program3_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program3_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program3_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program3_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program3_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program3_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program4_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program4_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program4_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program4_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program4_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program4_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program4_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program4_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program5_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program5_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program5_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program5_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program5_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program5_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program5_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program5_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program6_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program6_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program6_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program6_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program6_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program6_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program6_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program6_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program7_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program7_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program7_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program7_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program7_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program7_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program7_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program7_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program8_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program8_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program8_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program8_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program8_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program8_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program8_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program8_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program9_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program9_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program9_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program9_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program9_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program9_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program9_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program9_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            _SystemControl.Program10_Registered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program10_Registered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program10_Start_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program10_Start_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program10_Stop_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program10_Stop_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };
            _SystemControl.Program10_Unregistered_Changed += (value) => { CrestronConsole.PrintLine("Sys Control: Program10_Unregistered_Changed: {0}, {1}", value, _SystemControl.CurrentTimeZone_F); };

            CrestronConsole.AddNewConsoleCommand(ProgramStart, "TProgram", "Start/Stop A Specific Program", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ProgramRegister, "TRegister", "Register/Unregister A Specific Program", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TimeZome, "TTimeZone", "Sets Time Zon", ConsoleAccessLevelEnum.AccessOperator);
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
        static string GetSecondParameter(string value)
        {
            var commands = value.Split(' ');
            return commands[1].ToUpper();
        }
        static void ProgramStart(string Commands)
        {
            string MessageHelp = "TProgram" + " [1|10] [Start|Stop]";
            int slot = GetFirstParameterInteger(Commands, MessageHelp);
            string action = GetSecondParameter(Commands);
            if (action != "START" && action != "STOP")
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            bool start = action=="START"?true:false;
            if (slot >= 1 && slot <= 10)
            {
                switch (slot)
                {
                    case 1:
                        if (start) _SystemControl.Program1_Start(); else _SystemControl.Program1_Stop();
                        break;
                    case 2:
                        if (start) _SystemControl.Program2_Start(); else _SystemControl.Program2_Stop();
                        break;
                    case 3:
                        if (start) _SystemControl.Program3_Start(); else _SystemControl.Program3_Stop();
                        break;
                    case 4:
                        if (start) _SystemControl.Program4_Start(); else _SystemControl.Program4_Stop();
                        break;
                    case 5:
                        if (start) _SystemControl.Program5_Start(); else _SystemControl.Program5_Stop();
                        break;
                    case 6:
                        if (start) _SystemControl.Program6_Start(); else _SystemControl.Program6_Stop();
                        break;
                    case 7:
                        if (start) _SystemControl.Program7_Start(); else _SystemControl.Program7_Stop();
                        break;
                    case 8:
                        if (start) _SystemControl.Program8_Start(); else _SystemControl.Program8_Stop();
                        break;
                    case 9:
                        if (start) _SystemControl.Program9_Start(); else _SystemControl.Program9_Stop();
                        break;
                    case 10:
                        if (start) _SystemControl.Program10_Start(); else _SystemControl.Program10_Stop();
                        break;
                    default:
                        break;
                }
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Program {0} to {1}...\n", slot, action);

            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void ProgramRegister(string Commands)
        {
            string MessageHelp = "TRegister" + " [1|10] [Reg|Unreg]";
            int slot = GetFirstParameterInteger(Commands, MessageHelp);
            string action = GetSecondParameter(Commands);
            if (action != "REG" && action != "UNREG")
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            bool register = action == "REG" ? true : false;
            if (slot >= 1 && slot <= 10)
            {
                switch (slot)
                {
                    case 1:
                        if (register) _SystemControl.Program1_Register(); else _SystemControl.Program1_Unregister();
                        break;
                    case 2:
                        if (register) _SystemControl.Program2_Register(); else _SystemControl.Program2_Unregister();
                        break;
                    case 3:
                        if (register) _SystemControl.Program3_Register(); else _SystemControl.Program3_Unregister();
                        break;
                    case 4:
                        if (register) _SystemControl.Program4_Register(); else _SystemControl.Program4_Unregister();
                        break;
                    case 5:
                        if (register) _SystemControl.Program5_Register(); else _SystemControl.Program5_Unregister();
                        break;
                    case 6:
                        if (register) _SystemControl.Program6_Register(); else _SystemControl.Program6_Unregister();
                        break;
                    case 7:
                        if (register) _SystemControl.Program7_Register(); else _SystemControl.Program7_Unregister();
                        break;
                    case 8:
                        if (register) _SystemControl.Program8_Register(); else _SystemControl.Program8_Unregister();
                        break;
                    case 9:
                        if (register) _SystemControl.Program9_Register(); else _SystemControl.Program9_Unregister();
                        break;
                    case 10:
                        if (register) _SystemControl.Program10_Register(); else _SystemControl.Program10_Unregister();
                        break;
                    default:
                        break;
                }
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Program {0} to {1}...\n", slot, action);

            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void TimeZome(string TimeZone)
        {
            string MessageHelp = "TTimeZone" + " value (from list)";
            int timezone = GetFirstParameterInteger(TimeZone, MessageHelp);
            var result = _SystemControl.TimeZone(timezone);
            if (result)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Setting TimeZone to {0}", timezone);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}