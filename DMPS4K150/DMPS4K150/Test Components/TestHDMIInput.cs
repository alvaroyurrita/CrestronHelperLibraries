using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using Crestron.SimplSharpPro.DM;


namespace DMPS4K150.Test_Components
{

    public class TestHDMIInput
    {
        private DMPS4K150C_HDMI_Input _HDMIInput;
        public TestHDMIInput(DMPS4K150C_HDMI_Input HDMIInput)
        {
            _HDMIInput = HDMIInput;
            Start();
        }
        private void Start()
        {

            _HDMIInput.Aspect_Ratio_Changed += (state) => { CrestronConsole.PrintLine("{2} Aspcet Ratio State: {0}, {1}", state, _HDMIInput.Aspect_Ratio_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Audio_Channels_Changed += (value) => { CrestronConsole.PrintLine("{2} Audio Channels Value: {0}, {1}", value, _HDMIInput.Audio_Channels_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Audio_Format_Changed += (format) => { CrestronConsole.PrintLine("{2} Audio Format: {0}, {1}", format.ToString(), _HDMIInput.Audio_Format_fb.ToString(), _HDMIInput.HDMIInputPort); };
            _HDMIInput.Audio_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} Audio Gain Value: {0}, {1}", (double)value / 10, (double)_HDMIInput.Audio_Gain_fb / 10, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Audio_Source_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Audo Source Detected State: {0}, {1}", state, _HDMIInput.Audio_Source_Detected_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.CEC_Err_Changed += (state) => { CrestronConsole.PrintLine("{2} CEC Err Changed State: {0}, {1}", state, _HDMIInput.CEC_Err_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.HDCP_Active_Changed += (state) => { CrestronConsole.PrintLine("{2} HDCP Active State: {0}, {1}", state, _HDMIInput.HDCP_Active_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.HDCP_Support_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} HDCP Support Off State: {0}, {1}", state, _HDMIInput.HDCP_Support_Off_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.HDCP_Support_On_Changed += (state) => { CrestronConsole.PrintLine("{2} HDCP Support On State: {0}, {1}", state, _HDMIInput.HDCP_Support_On_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Horizontal_Resolution_Changed += (value) => { CrestronConsole.PrintLine("{2} Horizontal Resolution Value: {0}, {1}", value, _HDMIInput.Horizontal_Resolution_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Interlaced_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Interlaced Detected State: {0}, {1}", state, _HDMIInput.Interlaced_Detected_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Receive_CEC_Message_Changed += (message) => { CrestronConsole.PrintLine("{2} Receive CEC Message: {0}, {1}", message, _HDMIInput.Receive_CEC_Message_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Refresh_Rate_Changed += (value) => { CrestronConsole.PrintLine("{2} Refresh Rate Value: {0}, {1}", value, _HDMIInput.Refresh_Rate_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Status_3D_Changed += (status) => { CrestronConsole.PrintLine("{2} Status 3D State: {0}, {1}", status.ToString(), _HDMIInput.Status_3D_fb.ToString(), _HDMIInput.HDMIInputPort); };
            _HDMIInput.Sync_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Sync Detected State: {0}, {1}", state, _HDMIInput.Sync_Detected_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Vertical_Resolution_Changed += (value) => { CrestronConsole.PrintLine("{2} Vertical Resolution Value: {0}, {1}", value, _HDMIInput.Vertical_Resolution_fb, _HDMIInput.HDMIInputPort); };
            _HDMIInput.Video_Source_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Video Source Detected State: {0}, {1}", state, _HDMIInput.Video_Source_Detected_fb, _HDMIInput.HDMIInputPort); };


            CrestronConsole.AddNewConsoleCommand(HDCPChangeSupport, "THDCPSupport" + _HDMIInput.HDMIInputPort, "Sets/Resets HDCP Support for " + _HDMIInput.HDMIInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(AudioGain, "TAudioGain" + _HDMIInput.HDMIInputPort, "Changes Audio Gain for" + _HDMIInput.HDMIInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SendCECMessage, "TCECMessage" + _HDMIInput.HDMIInputPort, "Sends CEC Message" + _HDMIInput.HDMIInputPort, ConsoleAccessLevelEnum.AccessOperator);

        }
        void HDCPChangeSupport(string State)
        {
            if (State.ToUpper() == "ON") _HDMIInput.HDCP_Support_On();
            else if (State.ToUpper() == "OFF") _HDMIInput.HDCP_Support_Off();
            else { CrestronConsole.ConsoleCommandResponse("THDCPSupport" + _HDMIInput.HDMIInputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing HDCP Support to {0}...\n", State.ToUpper());
        }
        double GetFirstParameterDouble(string value, string MessageHelp)
        {
            var commands = value.Split(' ');
            double Result;
            try
            {
                Result = double.Parse(commands[0]);
                Result = Math.Round(Result, 1);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return 0xffff;
            }
            return Result;
        }
        void AudioGain(string value)
        {
            string MessageHelp = "TAudioGain" + _HDMIInput.HDMIInputPort + " value (-10.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -10 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _HDMIInput.Audio_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SendCECMessage(string message)
        {
            string MessageHelp = "TCECMessage" + _HDMIInput.HDMIInputPort + " message";
            var commands = Regex.Matches(message, "\\\".*?\\\"|\\S*");
            string Message = "";
            try
            {
                Message = commands[0].Value.Replace("\"", string.Empty);
                Message = Regex.Unescape(Message);
            }
            catch
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
            }
            if (Message != "")
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Sending Message {0} through CEC", Message);
                _HDMIInput.Transmit_CEC_Message(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }

}