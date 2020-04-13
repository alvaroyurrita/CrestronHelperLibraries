using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using Crestron.SimplSharpPro.DM;


namespace DMPS4K150.Test_Components
{

    public class TestDMInput
    {
        private DMPS4K150C_DM_Input _DMInput;
        public TestDMInput(DMPS4K150C_DM_Input DMInput)
        {
            _DMInput = DMInput;
            Start();
        }
        private void Start()
        {
            _DMInput.Aspect_Ratio_Changed += (state) => { CrestronConsole.PrintLine("{2} Aspect Ratio State: {0}, {1}", state, _DMInput.Aspect_Ratio_fb, _DMInput.DMInputPort); };
            _DMInput.Audio_Channels_Changed += (value) => { CrestronConsole.PrintLine("{2} Audio Channels Value: {0}, {1}", value, _DMInput.Audio_Channels_fb, _DMInput.DMInputPort); };
            _DMInput.Audio_Format_Changed += (format) => { CrestronConsole.PrintLine("{2} Audio Format: {0}, {1}", format.ToString(), _DMInput.Audio_Format_fb.ToString(), _DMInput.DMInputPort); };
            _DMInput.Audio_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} Audio Gain Value: {0}, {1}", (double)value / 10, (double)_DMInput.Audio_Gain_fb / 10, _DMInput.DMInputPort); };
            _DMInput.Audio_Source_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Audo Source Detected State: {0}, {1}", state, _DMInput.Audio_Source_Detected_fb, _DMInput.DMInputPort); };
            _DMInput.ENDPOINT_ONLINE_Changed += (state) => { CrestronConsole.PrintLine("{2} Endpoint Online State: {0}, {1}", state, _DMInput.ENDPOINT_ONLINE_fb, _DMInput.DMInputPort); };
            _DMInput.HDCP_Active_Changed += (state) => { CrestronConsole.PrintLine("{2} HDCP Active State: {0}, {1}", state, _DMInput.HDCP_Active_fb, _DMInput.DMInputPort); };
            _DMInput.HDCP_Support_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} HDCP Support Off State: {0}, {1}", state, _DMInput.HDCP_Support_Off_fb, _DMInput.DMInputPort); };
            _DMInput.HDCP_Support_On_Changed += (state) => { CrestronConsole.PrintLine("{2} HDCP Support On State: {0}, {1}", state, _DMInput.HDCP_Support_On_fb, _DMInput.DMInputPort); };
            _DMInput.Horizontal_Resolution_Changed += (value) => { CrestronConsole.PrintLine("{2} Horizontal Resolution Value: {0}, {1}", value, _DMInput.Horizontal_Resolution_fb, _DMInput.DMInputPort); };
            _DMInput.Interlaced_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Interlaced Detected State: {0}, {1}", state, _DMInput.Interlaced_Detected_fb, _DMInput.DMInputPort); };
            _DMInput.Refresh_Rate_Changed += (value) => { CrestronConsole.PrintLine("{2} Refresh Rate Value: {0}, {1}", value, _DMInput.Refresh_Rate_fb, _DMInput.DMInputPort); };
            _DMInput.Status_3D_Changed += (status) => { CrestronConsole.PrintLine("{2} Status 3D State: {0}, {1}", status.ToString(), _DMInput.Status_3D_fb.ToString(), _DMInput.DMInputPort); };
            _DMInput.Sync_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Sync Detected State: {0}, {1}", state, _DMInput.Sync_Detected_fb, _DMInput.DMInputPort); };
            _DMInput.Vertical_Resolution_Changed += (value) => { CrestronConsole.PrintLine("{2} Vertical Resolution Value: {0}, {1}", value, _DMInput.Vertical_Resolution_fb, _DMInput.DMInputPort); };
            _DMInput.Video_Source_Detected_Changed += (state) => { CrestronConsole.PrintLine("{2} Video Source Detected State: {0}, {1}", state, _DMInput.Video_Source_Detected_fb, _DMInput.DMInputPort); };


            CrestronConsole.AddNewConsoleCommand(HDCPChangeSupport, "THDCPSupport" + _DMInput.DMInputPort, "Sets/Resets HDCP Support for " + _DMInput.DMInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(AudioGain, "TAudioGain" + _DMInput.DMInputPort, "Changes Audio Gain for " + _DMInput.DMInputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetAllProps, "TGetAllProps" + _DMInput.DMInputPort, "Get All Properites for " + _DMInput.DMInputPort, ConsoleAccessLevelEnum.AccessOperator);
            

        }
        void GetAllProps(string message)
        {
            CrestronConsole.PrintLine("{1} Aspect Ratio State: {0}",  _DMInput.Aspect_Ratio_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Audio Channels Value: {0}",  _DMInput.Audio_Channels_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Audio Format: {0}",  _DMInput.Audio_Format_fb.ToString(), _DMInput.DMInputPort);
            CrestronConsole.PrintLine("{1} Audio Gain Value: {0}",  (double)_DMInput.Audio_Gain_fb / 10, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Audo Source Detected State: {0}",  _DMInput.Audio_Source_Detected_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Endpoint Online State: {0}",  _DMInput.ENDPOINT_ONLINE_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} HDCP Active State: {0}",  _DMInput.HDCP_Active_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} HDCP Support Off State: {0}",  _DMInput.HDCP_Support_Off_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} HDCP Support On State: {0}",  _DMInput.HDCP_Support_On_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Horizontal Resolution Value: {0}",  _DMInput.Horizontal_Resolution_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Interlaced Detected State: {0}",  _DMInput.Interlaced_Detected_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Refresh Rate Value: {0}",  _DMInput.Refresh_Rate_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Status 3D State: {0}",  _DMInput.Status_3D_fb.ToString(), _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Sync Detected State: {0}",  _DMInput.Sync_Detected_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Vertical Resolution Value: {0}",  _DMInput.Vertical_Resolution_fb, _DMInput.DMInputPort); 
            CrestronConsole.PrintLine("{1} Video Source Detected State: {0}",  _DMInput.Video_Source_Detected_fb, _DMInput.DMInputPort); 

        }
        void HDCPChangeSupport(string State)
        {
            if (State.ToUpper() == "ON") _DMInput.HDCP_Support_On();
            else if (State.ToUpper() == "OFF") _DMInput.HDCP_Support_Off();
            else { CrestronConsole.ConsoleCommandResponse("THDCPSupport" + _DMInput.DMInputPort + " [On|Off]"); return; }
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
            string MessageHelp = "TAudioGain" + _DMInput.DMInputPort + " value (-10.0 to 10.0)dm";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -10 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _DMInput.Audio_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }

}