using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;

namespace DMPS4K150.Test_Components
{
    public static class TestDeviceControl
    {
        private static DMPS4K150C_DeviceControl _DeviceControl;
        public static void Start(DMPS4K150C_DeviceControl DeviceControl)
        {
            _DeviceControl = DeviceControl;
            _DeviceControl.Front_Panel_Lock_Changed += (state) => { CrestronConsole.PrintLine("Front Panel Lock State: {0}, {1}", state, _DeviceControl.Front_Panel_Lock_fb); };
            _DeviceControl.Front_Panel_Unlock_Changed += (state) => { CrestronConsole.PrintLine("Front Panel Unlock State: {0}, {1}", state, _DeviceControl.Front_Panel_Unlock_fb); };
            _DeviceControl.Input_1_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 1 Name: {0}, {1}", name, _DeviceControl.Input_1_Name_fb); };
            _DeviceControl.Input_2_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 2 Name: {0}, {1}", name, _DeviceControl.Input_2_Name_fb); };
            _DeviceControl.Input_3_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 3 Name: {0}, {1}", name, _DeviceControl.Input_3_Name_fb); };
            _DeviceControl.Input_4_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 4 Name: {0}, {1}", name, _DeviceControl.Input_4_Name_fb); };
            _DeviceControl.Input_5_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 5 Name: {0}, {1}", name, _DeviceControl.Input_5_Name_fb); };
            _DeviceControl.Input_6_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 6 Name: {0}, {1}", name, _DeviceControl.Input_6_Name_fb); };
            _DeviceControl.Input_7_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 7 Name: {0}, {1}", name, _DeviceControl.Input_7_Name_fb); };
            _DeviceControl.Input_8_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 8 Name: {0}, {1}", name, _DeviceControl.Input_8_Name_fb); };
            _DeviceControl.Input_9_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 9 Name: {0}, {1}", name, _DeviceControl.Input_9_Name_fb); };
            _DeviceControl.Input_10_Name_Changed += (name) => { CrestronConsole.PrintLine("Input 10 Name: {0}, {1}", name, _DeviceControl.Input_10_Name_fb); };
            _DeviceControl.Output_Name_Changed += (name) => { CrestronConsole.PrintLine("Output Name: {0}, {1}", name, _DeviceControl.Output_Name_fb); };

            CrestronConsole.AddNewConsoleCommand(LockFrontPanel, "TLockFronPanel", "Locks/Unlocks Front Panel", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeInputName, "TInputName", "Changes Input Slot Name", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeOutputName, "TOutputName", "Changes Output Slot Name", ConsoleAccessLevelEnum.AccessOperator);
        }
        static void LockFrontPanel(string State)
        {
            if (State.ToUpper() == "ON") _DeviceControl.Front_Panel_Lock();
            else if (State.ToUpper() == "OFF") _DeviceControl.Front_Panel_Unlock();
            else { CrestronConsole.ConsoleCommandResponse("TLockFronPanel [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Front Panel Lock to {0}...\n", State);
        }
        static void ChangeInputName(string Options)
        {
            string MessageHelp = "TInputName InputNo(1-10) Name";
            var commands = Regex.Matches(Options, "[\\w]+|\\\"[^\\\"]*\\\"");
            int InputNumber;
            string Name;
            try
            {
                Name = commands[1].Value;
                InputNumber = int.Parse(commands[0].Value);
            }
            catch(Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber > 0 && InputNumber <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing input {0} name to : {1}", InputNumber, Name);
                switch (InputNumber)
                {
                    case 1:
                        _DeviceControl.Input_1_Name(Name);
                        break;
                    case 2:
                        _DeviceControl.Input_2_Name(Name);
                        break;
                    case 3:
                        _DeviceControl.Input_3_Name(Name);
                        break;
                    case 4:
                        _DeviceControl.Input_4_Name(Name);
                        break;
                    case 5:
                        _DeviceControl.Input_5_Name(Name);
                        break;
                    case 6:
                        _DeviceControl.Input_6_Name(Name);
                        break;
                    case 7:
                        _DeviceControl.Input_7_Name(Name);
                        break;
                    case 8:
                        _DeviceControl.Input_8_Name(Name);
                        break;
                    case 9:
                        _DeviceControl.Input_9_Name(Name);
                        break;
                    case 10:
                        _DeviceControl.Input_10_Name(Name);
                        break;

                    default:
                        break;
                }
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void ChangeOutputName(string Options)
        {
            string MessageHelp = "TOutputName InputNo(1-1) Name";
            var commands = Regex.Matches(Options, "[\\w]+|\\\"[^\\\"]*\\\"");
            int OutputNumber;
            string Name;
            try
            {
                Name = commands[1].Value;
                OutputNumber = int.Parse(commands[0].Value);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (OutputNumber > 0 && OutputNumber <= 1)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing output {0} name to : {1}", OutputNumber, Name);
                switch (OutputNumber)
                {
                    case 1:
                        _DeviceControl.Output_Name(Name);
                        break;
                    default:
                        break;
                }
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}