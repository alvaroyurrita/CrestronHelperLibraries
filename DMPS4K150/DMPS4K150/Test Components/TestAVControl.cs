using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;

namespace DMPS4K150.Test_Components
{
    public static class TestAVControl
    {
        private static DMPS4K150C_AVControl _AVControl;
        public static void Start(DMPS4K150C_AVControl AVControl)
        {
            _AVControl = AVControl;
            _AVControl.AutoMode_On_Changed += (state) => { CrestronConsole.PrintLine("Auto Mode On State: {0}, {1}", state, _AVControl.AutoMode_On_fb); };
            _AVControl.AutoMode_Off_Changed += (state) => { CrestronConsole.PrintLine("Auto Mode Off State: {0}, {1}", state, _AVControl.AutoMode_Off_fb); };
            _AVControl.Video_Source_Changed += (value) => { CrestronConsole.PrintLine("Video Source Value: {0}, {1}", value, _AVControl.Video_Source_fb); };
            _AVControl.Audio_Source_Changed += (value) => { CrestronConsole.PrintLine("Audio Source Value: {0}, {1}", value, _AVControl.Audio_Source_fb); };
            _AVControl.Input_DM1_UsbRoutedTo_Changed += (value) => { CrestronConsole.PrintLine("Input DM1 USB Routed to: {0}, {1}", value, _AVControl.Input_DM1_UsbRoutedTo_fb); };
            _AVControl.Input_DM2_UsbRoutedTo_Changed += (value) => { CrestronConsole.PrintLine("Input DM2 USB Route to: {0}, {1}", value, _AVControl.Input_DM2_UsbRoutedTo_fb); };
            _AVControl.Output_DM_UsbRoutedTo_Changed += (value) => { CrestronConsole.PrintLine("Output DM USB Route to: {0}, {1}", value, _AVControl.Output_DM_UsbRoutedTo_fb); };

            CrestronConsole.AddNewConsoleCommand(AutoMode, "TAutoMode", "Sets/Resets Auto Mode", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeVideoSource, "TChangeVideoSource", "Changes Video Source", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeAudioSource, "TChangeAudioSource", "Changes Audio Source", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeInDM1Usb, "TChangeInDM1Usb", "Changes Input DM1 USB Routed To", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeInDm2Usb, "TChangeInDm2Usb", "Changes Input DM2 USB Routed To", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeOutDMUsb, "TChangeOutDmUsb", "Changes Output DM USB Routed To", ConsoleAccessLevelEnum.AccessOperator);
        }
        static void AutoMode(string State)
        {
            if (State.ToUpper() == "ON") _AVControl.AutoMode_On();
            else if (State.ToUpper() == "OFF") _AVControl.AutoMode_Off();
            else { CrestronConsole.ConsoleCommandResponse("TAutoMode [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Auto Mode to  {0}...\n", State);
        }
        static void ChangeVideoSource(string Input)
        {
            string MessageHelp = "TChangeVideoSource InputNo(0-10)";
            var commands = Input.Split(' ');
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(commands[0]);
            }
            catch(Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber >= 0 && InputNumber <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Video Output to Input {0}", InputNumber);
                _AVControl.Video_Source(InputNumber);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void ChangeAudioSource(string Input)
        {
            string MessageHelp = "TChangeAudioSource InputNo(0-10)";
            var commands = Input.Split(' ');
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber >= 0 && InputNumber <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Audio Output to Input {0}", InputNumber);
                _AVControl.Audio_Source(InputNumber);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void ChangeInDM1Usb(string Input)
        {
            string MessageHelp = "TChangeInDM1Usb InputNo(0|9|10)";
            var commands = Input.Split(' ');
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber == 0 || InputNumber == 9 || InputNumber == 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Input DM1 USB Routed to Input {0}", InputNumber);
                _AVControl.Input_DM1_UsbRoutedTo(InputNumber);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void ChangeInDm2Usb(string Input)
        {
            string MessageHelp = "TChangeInDM2Usb InputNo(0|9|10)";
            var commands = Input.Split(' ');
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber == 0 || InputNumber == 9 || InputNumber == 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Input DM2 USB Routed to Input {0}", InputNumber);
                _AVControl.Input_DM2_UsbRoutedTo(InputNumber);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void ChangeOutDMUsb(string Input)
        {
            string MessageHelp = "TOutputName InputNo(0|9|10)";
            var commands = Input.Split(' ');
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber == 0 || InputNumber == 9 || InputNumber == 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Output DM USB Routed to Input {0}", InputNumber);
                _AVControl.Output_DM_UsbRoutedTo(InputNumber);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}