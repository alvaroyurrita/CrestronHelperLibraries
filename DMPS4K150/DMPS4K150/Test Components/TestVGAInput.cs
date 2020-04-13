using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using Crestron.SimplSharpPro.DM;


namespace DMPS4K150.Test_Components
{

    public class TestVGAInput
    {
        private DMPS4K150C_VGA_Input _VGAInput;
        public TestVGAInput(DMPS4K150C_VGA_Input VGAInput)
        {
            _VGAInput = VGAInput;
            Start();
        }
        private void Start()
        {
            _VGAInput.Analog_Audio_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} Analog Audio Gain Value: {0}, {1}", (double)value/10, (double)_VGAInput.Analog_Audio_Gain_fb/10, _VGAInput.VgaInputPort); };
            _VGAInput.Aspect_Ratio_Changed += (state) => { CrestronConsole.PrintLine("{2} Aspcet Ratio State: {0}, {1}", state, _VGAInput.Aspect_Ratio_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Auto_Calibrate_Changed += (state) => { CrestronConsole.PrintLine("{2} Auto Calibrate State: {0}, {1}", state, _VGAInput.Auto_Calibrate_fb.ToString(), _VGAInput.VgaInputPort); };
            _VGAInput.Blue_Changed += (value) => { CrestronConsole.PrintLine("{2} Blue Gain Value: {0}, {1}", value, _VGAInput.Blue_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Brightness_Changed += (value) => { CrestronConsole.PrintLine("{2} Brightness Gain Value: {0}, {1}", value, _VGAInput.Brightness_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Contrast_Changed += (value) => { CrestronConsole.PrintLine("{2} Contrast Gain Value: {0}, {1}", value, _VGAInput.Contrast_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Green_Changed += (value) => { CrestronConsole.PrintLine("{2} Green Gain Value: {0}, {1}", value, _VGAInput.Green_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Horizontal_Resolution_Changed += (value) => { CrestronConsole.PrintLine("{2} Horizontal Resolution Value: {0}, {1}", value, _VGAInput.Horizontal_Resolution_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Hue_Changed += (value) => { CrestronConsole.PrintLine("{2} Hue Gain Value: {0}, {1}", value, _VGAInput.Hue_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Red_Changed += (value) => { CrestronConsole.PrintLine("{2} Red Gain Value: {0}, {1}", value, _VGAInput.Red_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Refresh_Rate_Changed += (value) => { CrestronConsole.PrintLine("{2} Refresh Rate Value: {0}, {1}", value, _VGAInput.Refresh_Rate_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Saturation_Changed += (value) => { CrestronConsole.PrintLine("{2} Saturation Gain Value: {0}, {1}", value, _VGAInput.Saturation_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Sync_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Sync Detected State: {0}, {1}", state, _VGAInput.Sync_Detected_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Type_Control_Changed += (type) => { CrestronConsole.PrintLine("{2} Audo Source Detected Type: {0}, {1}", type.ToString(), _VGAInput.Type_Control_fb.ToString(), _VGAInput.VgaInputPort); };
            _VGAInput.Vertical_Resolution_Changed += (value) => { CrestronConsole.PrintLine("{2} Vertical Resolution Value: {0}, {1}", value, _VGAInput.Vertical_Resolution_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Video_Source_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Video Source Detected State: {0}, {1}", state, _VGAInput.Video_Source_Detected_fb, _VGAInput.VgaInputPort); };
            _VGAInput.X_Position_Changed += (value) => { CrestronConsole.PrintLine("{2} X_Position Gain Value: {0}, {1}", value, _VGAInput.X_Position_fb, _VGAInput.VgaInputPort); };
            _VGAInput.Y_Position_Changed += (value) => { CrestronConsole.PrintLine("{2} Y_Position Gain Value: {0}, {1}", value, _VGAInput.Y_Position_fb, _VGAInput.VgaInputPort); };


            CrestronConsole.AddNewConsoleCommand(AutoCalibrate, "TAutoCalibrate" + _VGAInput.VgaInputPort, "Sets/Resets HDCP Support for " + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Brightness, "TBrightness" + _VGAInput.VgaInputPort, "Changes Brightness Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Contrast, "TContrast" + _VGAInput.VgaInputPort, "Changes Contrast Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Saturation, "TSaturation" + _VGAInput.VgaInputPort, "Changes Saturation Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Hue, "THue" + _VGAInput.VgaInputPort, "Changes Hue Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Red, "TRed" + _VGAInput.VgaInputPort, "Changes Red Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Green, "TGreen" + _VGAInput.VgaInputPort, "Changes Green Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Blue, "TBlue" + _VGAInput.VgaInputPort, "Changes Blue Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TypeControl, "TTypeControl" + _VGAInput.VgaInputPort, "Changes TypeControl for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(AudioGain, "TAudioGain" + _VGAInput.VgaInputPort, "Changes Audio Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(XPosition, "TXPosition" + _VGAInput.VgaInputPort, "Changes XPosition Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(YPosition, "TYPosition" + _VGAInput.VgaInputPort, "Changes YPosition Gain for" + _VGAInput.VgaInputPort, ConsoleAccessLevelEnum.AccessOperator);

        }
        void AutoCalibrate(string value)
        {
            if (value == "")
            {
                _VGAInput.Auto_Calibrate();
            }
            else { CrestronConsole.ConsoleCommandResponse("TAutoCalibrate" + _VGAInput.VgaInputPort); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Starting Auto Calibration\n");
        }
        double GetFirstParameterDouble(string value, string MessageHelp)
        {
            var commands = value.Split(' ');
            double Result;
            try
            {
                Result = double.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return 0xffff;
            }
            return Result;
        }
        double GetFirstParameterInteger(string value, string MessageHelp)
        {
            var commands = value.Split(' ');
            double Result;
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
        void Brightness(string value)
        {
            string MessageHelp = "TBrightness" + _VGAInput.VgaInputPort + " value (0 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 0 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Brightness((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void Contrast(string value)
        {
            string MessageHelp = "TContrast" + _VGAInput.VgaInputPort + " value (-50 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);

            if (Gain >= -50 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Contrast((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void Saturation(string value)
        {
            string MessageHelp = "TSaturation" + _VGAInput.VgaInputPort + " value (-50 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);

            if (Gain >= -50 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Saturation((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void Hue(string value)
        {
            string MessageHelp = "THue" + _VGAInput.VgaInputPort + " value (-50 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);

            if (Gain >= -50 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Hue((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void Red(string value)
        {
            string MessageHelp = "TRed" + _VGAInput.VgaInputPort + " value (-50 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);

            if (Gain >= -50 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Red((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void Green(string value)
        {
            string MessageHelp = "TGreen" + _VGAInput.VgaInputPort + " value (-50 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);

            if (Gain >= -50 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Green((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void Blue(string value)
        {
            string MessageHelp = "TBlue" + _VGAInput.VgaInputPort + " value (-50 to 50)";
            double Gain = GetFirstParameterInteger(value, MessageHelp);

            if (Gain >= -50 && Gain <= 50)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Blue((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void TypeControl(string options)
        {
            string MessageHelp = "TAudioGain" + _VGAInput.VgaInputPort + " [Auto|RGB|Comp|SVid|Video]";
            var opts = options.Split(' ');
            string type = opts[0].ToUpper();

            switch (type)
            {   
                case "AUTO":
                    _VGAInput.Type_Control(eDmVgaSourceControlType.Auto);
                    break;
                case "RGB":
                    _VGAInput.Type_Control(eDmVgaSourceControlType.RGB);
                    break;
                case "COMP":
                    _VGAInput.Type_Control(eDmVgaSourceControlType.YPbPr);
                    break;
                case "SVID":
                    _VGAInput.Type_Control(eDmVgaSourceControlType.SVideo);
                    break;
                case "VIDEO":
                    _VGAInput.Type_Control(eDmVgaSourceControlType.Composite);
                    break;
                default:
                    CrestronConsole.ConsoleCommandResponse(MessageHelp);
                    break;
            }
        }
        void AudioGain(string value)
        {
            string MessageHelp = "TAudioGain" + _VGAInput.VgaInputPort + " value (-10.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -10 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _VGAInput.Analog_Audio_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void XPosition(string value)
        {
            string MessageHelp = "TXPosition" + _VGAInput.VgaInputPort + " value (-100 to 100)pixels";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -100 && Gain <= 100)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Position to {0}", Gain);
                _VGAInput.XPosition((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void YPosition(string value)
        {
            string MessageHelp = "TYPosition" + _VGAInput.VgaInputPort + " value (-10 to 10)pixels";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -10 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Position to {0}", Gain);
                _VGAInput.YPosition((short)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }

}