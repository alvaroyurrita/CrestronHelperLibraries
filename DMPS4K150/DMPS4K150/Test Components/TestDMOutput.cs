using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using Crestron.SimplSharpPro.DM;


namespace DMPS4K150.Test_Components
{

    public class TestDMOutput
    {
        private DMPS4K150C_DM_Output _DMOutput;
        public TestDMOutput(DMPS4K150C_DM_Output DMOutput)
        {
            _DMOutput = DMOutput;
            Start();
        }
        void Start()
        {

            _DMOutput.DM_CEC_Display_Physical_Address_Changed += (message) => { CrestronConsole.PrintLine("{2} DM CEC Display Physical Address Message: {0}, {1}", message, _DMOutput.DM_CEC_Display_Physical_Address_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_CEC_Error_Changed += (state) => { CrestronConsole.PrintLine("{2} DM CEC Error State: {0}, {1} ", state, _DMOutput.DM_CEC_Error_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_CEC_Receive_Changed += (message) => { CrestronConsole.PrintLine("{2} DM_CEC_Receive Message: {0}, {1}", message, _DMOutput.DM_CEC_Receive_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Deep_Color_Mode_Changed += (mode) => { CrestronConsole.PrintLine("{2} DM Deep Color Mode: {0}, {1}", mode.ToString(), _DMOutput.DM_Deep_Color_Mode_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.DM_Force_HDCP_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2} DM Force HDCP Disable State: {0}, {1}", state, _DMOutput.DM_Force_HDCP_Disable_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Force_HDCP_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} DM Force HDCP Enable State: {0}, {1}", state, _DMOutput.DM_Force_HDCP_Enable_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Manf_String_Changed += (message) => { CrestronConsole.PrintLine("{2} DM Manufacturer String Message: {0}, {1}", message, _DMOutput.DM_Manf_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Name_String_Changed += (message) => { CrestronConsole.PrintLine("{2} DM Name String Message: {0}, {1}", message, _DMOutput.DM_Name_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Output_Disabled_By_HDCP_Changed += (state) => { CrestronConsole.PrintLine("{2} DM Output Disabled By HDCP State: {0}, {1}", state, _DMOutput.DM_Output_Disabled_By_HDCP_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Output_Disabled_Changed += (state) => { CrestronConsole.PrintLine("{2} DM Output Disabled State: {0}, {1}", state, _DMOutput.DM_Output_Disabled_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Output_Enabled_Changed += (state) => { CrestronConsole.PrintLine("{2} DM Output Enabled State: {0}, {1}", state, _DMOutput.DM_Output_Enabled_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Pref_Timing_String_Changed += (message) => { CrestronConsole.PrintLine("{2} DM Pref Timing String Message: {0}, {1}", message, _DMOutput.DM_Pref_Timing_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.DM_Serial_Number_String_Changed += (message) => { CrestronConsole.PrintLine("{2} DM Serial Number String Message: {0}, {1}", message, _DMOutput.DM_Serial_Number_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.ENDPOINT_ONLINE_Changed += (state) => { CrestronConsole.PrintLine("{2} ENDPOINT ONLINE State: {0}, {1}", state, _DMOutput.ENDPOINT_ONLINE_fb, _DMOutput.DMOutputPort); };

            _DMOutput.HDMI_CEC_Display_Physical_Address_Changed += (message) => { CrestronConsole.PrintLine("{2} HDMI CEC Display Physical Address Message: {0}, {1}", message, _DMOutput.HDMI_CEC_Display_Physical_Address_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_CEC_Error_Changed += (state) => { CrestronConsole.PrintLine("{2} HDMI CEC Error State: {0}, {1} ", state, _DMOutput.HDMI_CEC_Error_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_CEC_Receive_Changed += (message) => { CrestronConsole.PrintLine("{2} HDMI_CEC_Receive Message: {0}, {1}", message, _DMOutput.HDMI_CEC_Receive_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Deep_Color_Mode_Changed += (mode) => { CrestronConsole.PrintLine("{2} HDMI Deep Color Mode: {0}, {1}", mode.ToString(), _DMOutput.HDMI_Deep_Color_Mode_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Force_HDCP_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2} HDMI Force HDCP Disable State: {0}, {1}", state, _DMOutput.HDMI_Force_HDCP_Disable_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Force_HDCP_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} HDMI Force HDCP Enable State: {0}, {1}", state, _DMOutput.HDMI_Force_HDCP_Enable_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Manf_String_Changed += (message) => { CrestronConsole.PrintLine("{2} HDMI Manufacturer String Message: {0}, {1}", message, _DMOutput.HDMI_Manf_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Name_String_Changed += (message) => { CrestronConsole.PrintLine("{2} HDMI Name String Message: {0}, {1}", message, _DMOutput.HDMI_Name_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Output_Disabled_By_HDCP_Changed += (state) => { CrestronConsole.PrintLine("{2} HDMI Output Disabled By HDCP State: {0}, {1}", state, _DMOutput.HDMI_Output_Disabled_By_HDCP_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Output_Disabled_Changed += (state) => { CrestronConsole.PrintLine("{2} HDMI Output Disabled State: {0}, {1}", state, _DMOutput.HDMI_Output_Disabled_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Output_Enabled_Changed += (state) => { CrestronConsole.PrintLine("{2} HDMI Output Enabled State: {0}, {1}", state, _DMOutput.HDMI_Output_Enabled_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Pref_Timing_String_Changed += (message) => { CrestronConsole.PrintLine("{2} HDMI Pref Timing String Message: {0}, {1}", message, _DMOutput.HDMI_Pref_Timing_String_fb, _DMOutput.DMOutputPort); };
            _DMOutput.HDMI_Serial_Number_String_Changed += (message) => { CrestronConsole.PrintLine("{2} HDMI Serial Number String Message: {0}, {1}", message, _DMOutput.HDMI_Serial_Number_String_fb, _DMOutput.DMOutputPort); };                      
            _DMOutput.Master_Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Master Mute Off State: {0}, {1}", state, _DMOutput.Master_Mute_Off_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Master_Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Master Mute On State: {0}, {1}", state, _DMOutput.Master_Mute_On_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Master_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Master Volume Value: {0}, {1}", (double)value / 10, (double)_DMOutput.Master_Volume_fb / 10, _DMOutput.DMOutputPort); };
            _DMOutput.Max_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Max Volume Value: {0}, {1}", (double)value / 10, (double)_DMOutput.Max_Volume_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Mic_Level_Changed += (value) => { CrestronConsole.PrintLine("{2} Mic Level Value: {0}, {1}", (double)value / 10, (double)_DMOutput.Mic_Level_fb / 10, _DMOutput.DMOutputPort); };
            _DMOutput.Mic_Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Mic Mute Off State: {0}, {1}", state, _DMOutput.Mic_Mute_Off_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Mic_Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Mic Mute On State: {0}, {1}", state, _DMOutput.Mic_Mute_On_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Mic_Pan_Changed += (value) => { CrestronConsole.PrintLine("{2} Mic Pan: {0}, {1}", value, _DMOutput.Mic_Pan_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Min_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Min Volume Value: {0}, {1}", (double)value / 10, (double)_DMOutput.Min_Volume_fb / 10, _DMOutput.DMOutputPort); };
            _DMOutput.Mixer_Bypassed_Changed += (state) => { CrestronConsole.PrintLine("{2} Mixer Bypassed State: {0}, {1}", state, _DMOutput.Mixer_Bypassed_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Preset_Ready_Pulse_Changed += (state) => { CrestronConsole.PrintLine("{2} Preset Ready Pulse State: {0}, {1}", state, _DMOutput.Preset_Ready_Pulse_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Recalling_Preset_Changed += (state) => { CrestronConsole.PrintLine("{2} Recalling Preset State: {0}, {1}", state, _DMOutput.Recalling_Preset_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Scaler_Display_Mode_Changed += (mode) => { CrestronConsole.PrintLine("{2} Scaler Display Mode: {0}, {1}", mode.ToString(), _DMOutput.Scaler_Display_Mode_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.Scaler_Enabled_Changed += (state) => { CrestronConsole.PrintLine("{2} Scaler Enabled State: {0}, {1}", state.ToString(), _DMOutput.Scaler_Enabled_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.Scaler_Out_Standby_Timeout_Changed += (timeout) => { CrestronConsole.PrintLine("{2} Scaler Out Standby Timeout: {0}, {1}", timeout.ToString(), _DMOutput.Scaler_Out_Standby_Timeout_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.Scaler_Underscan_Mode_Changed += (mode) => { CrestronConsole.PrintLine("{2} Scaler Underscan Mode: {0}, {1}", mode.ToString(), _DMOutput.Scaler_Underscan_Mode_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.Scaler_User_Resolution_Index_Changed += (index) => { CrestronConsole.PrintLine("{2} Scaler User Resolution Index: {0}, {1}", index.ToString(), _DMOutput.Scaler_User_Resolution_Index_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.Source_3D_Status_Changed += (status) => { CrestronConsole.PrintLine("{2} Source 3D Status: {0}, {1}", status.ToString(), _DMOutput.Source_3D_Status_fb.ToString(), _DMOutput.DMOutputPort); };
            _DMOutput.Source_Balance_Changed += (value) => { CrestronConsole.PrintLine("{2} Source Balance Value: {0}, {1}", value, _DMOutput.Source_Balance_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Source_Level_Changed += (value) => { CrestronConsole.PrintLine("{2} Source Level Value: {0}, {1}", (double)value / 10, (double)_DMOutput.Source_Level_fb / 10, _DMOutput.DMOutputPort); };
            _DMOutput.Source_Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Source Mute Off State: {0}, {1}", state, _DMOutput.Source_Mute_Off_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Source_Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Source Mute On State: {0}, {1}", state, _DMOutput.Source_Mute_On_fb, _DMOutput.DMOutputPort); };
            _DMOutput.Startup_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Startup Volume Value: {0}, {1}", (double)value / 10, (double)_DMOutput.Startup_Volume_fb / 10, _DMOutput.DMOutputPort); };
            _DMOutput.VU_Changed += (value) => { CrestronConsole.PrintLine("{2} VU Value: {0}, {1}", (double)value / 10, (double)_DMOutput.VU_fb / 10, _DMOutput.DMOutputPort); };


            CrestronConsole.AddNewConsoleCommand(MasterVolUp, "TMasterVolUp" + _DMOutput.DMOutputPort, "Raises/Lowers Master Volume for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterVolDown, "TMasterVolDown" + _DMOutput.DMOutputPort, "Lowers Master Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterMute, "TMasterMute" + _DMOutput.DMOutputPort, "Mutes/Unmutes Master Volume for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterMuteToggle, "TMasterMuteToggle" + _DMOutput.DMOutputPort, "Toggles Mute Master Volume for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicLevelUp, "TMicLevelUp" + _DMOutput.DMOutputPort, "Lowers Mic Level for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicLevelDown, "TMicLevelDown" + _DMOutput.DMOutputPort, "Lowers Mic Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicMute, "TMicMute" + _DMOutput.DMOutputPort, "Mutes/Unmutes Mic Level for" + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicMuteToggle, "TMicMuteToggle" + _DMOutput.DMOutputPort, "Toggles Mute Mic Level for" + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceLevelUp, "TSourceLevelUp" + _DMOutput.DMOutputPort, "Lowers Source Level for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceLevelDown, "TSourceLevelDown" + _DMOutput.DMOutputPort, "Lowers Source Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceMute, "TSourceMute" + _DMOutput.DMOutputPort, "Mutes/Unmutes Source Level for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceMuteToggle, "TSourceMuteToggle" + _DMOutput.DMOutputPort, "Toggles Mute Source Level for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(DMOutputEnable, "TDMOutputEnable" + _DMOutput.DMOutputPort, "Enables/Disables DM Output for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(DMForceHDCPEnable, "TDMFrcHDCPEnbl" + _DMOutput.DMOutputPort, "Enables/Disables DM Force HDCP for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(HDMIOutputEnable, "THDMIOutputEnbl" + _DMOutput.DMOutputPort, "Enables/Disables HDMI Output for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(HDMIForceHDCPEnable, "THDMIFrcHDCPEnbl" + _DMOutput.DMOutputPort, "Enables/Disables HDMI Force HDCP for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SavePreset, "TSavePreset" + _DMOutput.DMOutputPort, "Saves Preset for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(RecallPreset, "TRecallPreset" + _DMOutput.DMOutputPort, "Recalls Preset for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(PresetNumber, "TPresetNumber" + _DMOutput.DMOutputPort, "Sets Preset Number to be Recalled/Saved for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterVolume, "TMasterVolume" + _DMOutput.DMOutputPort, "Changes Master Volume Gain for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicLevel, "TMicLevel" + _DMOutput.DMOutputPort, "Changes Mice Level Gain for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicPan, "TMicPan" + _DMOutput.DMOutputPort, "Changes Mic Pan for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceLevel, "TSourceLevel" + _DMOutput.DMOutputPort, "Changes Source Level Gain for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceBalance, "TSourceBalance" + _DMOutput.DMOutputPort, "Changes Source Balance Gain for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MinVolume, "TMinVolume" + _DMOutput.DMOutputPort, "Changes Minimum Volume for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MaxVolume, "TMaxVolume" + _DMOutput.DMOutputPort, "Changes Maximum Volume for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(StartupVolume, "TStartupVolume" + _DMOutput.DMOutputPort, "Changes Startup Volume for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SclrEnable, "TSclrEnable" + _DMOutput.DMOutputPort, "Enables/Disables Scaler for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SclrUnderscanMode, "TSclrUndrscnMode" + _DMOutput.DMOutputPort, "Sets scaler underscan mode for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SclrDisplayMode, "TSclrDisplayMode" + _DMOutput.DMOutputPort, "Sets the Zoom Display Mode for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SclrUsrResIndex, "TSclrUsrResIndex" + _DMOutput.DMOutputPort, "Sets User Resolution Index for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SclrOutStbyTimeout, "TSclrOutStbyTmout" + _DMOutput.DMOutputPort, "Sets Scaler Out Stadby Timeout for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(DMCECTx, "TDMCECTx" + _DMOutput.DMOutputPort, "DM CEC Transmit for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(HDMICECTx, "THDMICECTx" + _DMOutput.DMOutputPort, "HDMI CEC Transmit for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetAllProps, "TGetAllProps" + _DMOutput.DMOutputPort, "Get All Properites for " + _DMOutput.DMOutputPort, ConsoleAccessLevelEnum.AccessOperator);
        }
        void GetAllProps (string message)
        {
             CrestronConsole.PrintLine("{1} DM CEC Display Physical Address Message: {0}", _DMOutput.DM_CEC_Display_Physical_Address_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM CEC Error State: {0} ", _DMOutput.DM_CEC_Error_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM_CEC_Receive Message: {0}", _DMOutput.DM_CEC_Receive_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Deep Color Mode: {0}", _DMOutput.DM_Deep_Color_Mode_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Force HDCP Disable State: {0}", _DMOutput.DM_Force_HDCP_Disable_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Force HDCP Enable State: {0}", _DMOutput.DM_Force_HDCP_Enable_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Manufacturer String Message: {0}", _DMOutput.DM_Manf_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Name String Message: {0}", _DMOutput.DM_Name_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Output Disabled By HDCP State: {0}", _DMOutput.DM_Output_Disabled_By_HDCP_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Output Disabled State: {0}", _DMOutput.DM_Output_Disabled_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Output Enabled State: {0}", _DMOutput.DM_Output_Enabled_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Pref Timing String Message: {0}", _DMOutput.DM_Pref_Timing_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} DM Serial Number String Message: {0}", _DMOutput.DM_Serial_Number_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} ENDPOINT ONLINE State: {0}", _DMOutput.ENDPOINT_ONLINE_fb, _DMOutput.DMOutputPort); 

             CrestronConsole.PrintLine("{1} HDMI CEC Display Physical Address Message: {0}", _DMOutput.HDMI_CEC_Display_Physical_Address_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI CEC Error State: {0} ", _DMOutput.HDMI_CEC_Error_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI_CEC_Receive Message: {0}", _DMOutput.HDMI_CEC_Receive_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Deep Color Mode: {0}", _DMOutput.HDMI_Deep_Color_Mode_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Force HDCP Disable State: {0}", _DMOutput.HDMI_Force_HDCP_Disable_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Force HDCP Enable State: {0}", _DMOutput.HDMI_Force_HDCP_Enable_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Manufacturer String Message: {0}", _DMOutput.HDMI_Manf_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Name String Message: {0}", _DMOutput.HDMI_Name_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Output Disabled By HDCP State: {0}", _DMOutput.HDMI_Output_Disabled_By_HDCP_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Output Disabled State: {0}", _DMOutput.HDMI_Output_Disabled_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Output Enabled State: {0}", _DMOutput.HDMI_Output_Enabled_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Pref Timing String Message: {0}", _DMOutput.HDMI_Pref_Timing_String_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} HDMI Serial Number String Message: {0}", _DMOutput.HDMI_Serial_Number_String_fb, _DMOutput.DMOutputPort);                       
             CrestronConsole.PrintLine("{1} Master Mute Off State: {0}", _DMOutput.Master_Mute_Off_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Master Mute On State: {0}", _DMOutput.Master_Mute_On_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Master Volume Value: {0}",  (double)_DMOutput.Master_Volume_fb/10,_DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Max Volume Value: {0}", (double)_DMOutput.Max_Volume_fb/10, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Mic Level Value: {0}",  (double)_DMOutput.Mic_Level_fb/10,_DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Mic Mute Off State: {0}", _DMOutput.Mic_Mute_Off_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Mic Mute On State: {0}", _DMOutput.Mic_Mute_On_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Mic Pan: {0}",  _DMOutput.Mic_Pan_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Min Volume Value: {0}", (double)_DMOutput.Min_Volume_fb / 10, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Mixer Bypassed State: {0}", _DMOutput.Mixer_Bypassed_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Preset Ready Pulse State: {0}", _DMOutput.Preset_Ready_Pulse_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Recalling Preset State: {0}", _DMOutput.Recalling_Preset_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Scaler Display Mode: {0}", _DMOutput.Scaler_Display_Mode_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Scaler Enabled State: {0}", _DMOutput.Scaler_Enabled_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Scaler Out Standby Timeout: {0}", _DMOutput.Scaler_Out_Standby_Timeout_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Scaler Underscan Mode: {0}", _DMOutput.Scaler_Underscan_Mode_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Scaler User Resolution Index: {0}",  _DMOutput.Scaler_User_Resolution_Index_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Source 3D Status: {0}",  _DMOutput.Source_3D_Status_fb.ToString(), _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Source Balance Value: {0}", _DMOutput.Source_Balance_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Source Level Value: {0}", (double)_DMOutput.Source_Level_fb / 10, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Source Mute Off State: {0}", _DMOutput.Source_Mute_Off_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Source Mute On State: {0}", _DMOutput.Source_Mute_On_fb, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} Startup Volume Value: {0}", (double)_DMOutput.Startup_Volume_fb / 10, _DMOutput.DMOutputPort); 
             CrestronConsole.PrintLine("{1} VU Value: {0}", (double)_DMOutput.VU_fb / 10, _DMOutput.DMOutputPort); 


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
        int GetFirstParameterInteger(string value, string MessageHelp)
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
        void MasterVolUp(string State)
        {
            if (State.ToUpper() == "START") _DMOutput.Master_Volume_Up(true);
            else if (State.ToUpper() == "STOP") _DMOutput.Master_Volume_Up(false);
            else { CrestronConsole.ConsoleCommandResponse("TMasterVol" + _DMOutput.DMOutputPort + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Raising Master Volume {0}...\n", State.ToUpper());
        }
        void MasterVolDown(string State)
        {
            if (State.ToUpper() == "START") _DMOutput.Master_Volume_Down(true);
            else if (State.ToUpper() == "STOP") _DMOutput.Master_Volume_Down(false);
            else { CrestronConsole.ConsoleCommandResponse("TMasterVol" + _DMOutput.DMOutputPort + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Lowering Master Volume {0}...\n", State.ToUpper());
        }
        void MasterMute(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.Master_Mute_On();
            else if (State.ToUpper() == "OFF") _DMOutput.Master_Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("TMasterMute" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Master Mute to {0}...\n", State.ToUpper());
        }
        void MasterMuteToggle(string State)
        {
            if (State == "")
            {
                _DMOutput.Master_Mute_Toggle();
                CrestronConsole.ConsoleCommandResponse("CMD:Toggling Master Mute...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TMasterMuteToggle" + _DMOutput.DMOutputPort); return; }
        }
        void MicLevelUp(string State)
        {
            if (State.ToUpper() == "START") _DMOutput.Mic_Level_Up(true);
            else if (State.ToUpper() == "STOP") _DMOutput.Mic_Level_Up(false);
            else { CrestronConsole.ConsoleCommandResponse("TMicLevel" + _DMOutput.DMOutputPort + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Raising Mic Level {0}...\n", State.ToUpper());
        }
        void MicLevelDown(string State)
        {
            if (State.ToUpper() == "START") _DMOutput.Mic_Level_Down(true);
            else if (State.ToUpper() == "STOP") _DMOutput.Mic_Level_Down(false);
            else { CrestronConsole.ConsoleCommandResponse("TMicLevel" + _DMOutput.DMOutputPort + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Lowering Mic Level {0}...\n", State.ToUpper());
        }
        void MicMute(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.Mic_Mute_On();
            else if (State.ToUpper() == "OFF") _DMOutput.Mic_Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("TMicMute" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Mic Mute to {0}...\n", State.ToUpper());
        }
        void MicMuteToggle(string State)
        {
            if (State == "")
            {
                _DMOutput.Mic_Mute_Toggle();
                CrestronConsole.ConsoleCommandResponse("CMD:Toggling Mic Mute}...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TMicMuteToggle" + _DMOutput.DMOutputPort); return; }
        }
        void SourceLevelUp(string State)
        {
            if (State.ToUpper() == "START") _DMOutput.Source_Level_Up(true);
            else if (State.ToUpper() == "STOP") _DMOutput.Source_Level_Up(false);
            else { CrestronConsole.ConsoleCommandResponse("TSourceLevel" + _DMOutput.DMOutputPort + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Raising Source Level {0}...\n", State.ToUpper());
        }
        void SourceLevelDown(string State)
        {
            if (State.ToUpper() == "START") _DMOutput.Source_Level_Down(true);
            else if (State.ToUpper() == "STOP") _DMOutput.Source_Level_Down(false);
            else { CrestronConsole.ConsoleCommandResponse("TSourceLevel" + _DMOutput.DMOutputPort + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Lowering Source Level {0}...\n", State.ToUpper());
        }
        void SourceMute(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.Source_Mute_On();
            else if (State.ToUpper() == "OFF") _DMOutput.Source_Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("TSourceMute" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Source Mute to {0}...\n", State.ToUpper());
        }
        void SourceMuteToggle(string State)
        {
            if (State == "")
            {
                _DMOutput.Source_Mute_Toggle();
                CrestronConsole.ConsoleCommandResponse("CMD:Toggling Source Mute...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TSourceMuteToggle" + _DMOutput.DMOutputPort); return; }
        }
        void DMOutputEnable(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.DM_Output_Enabled();
            else if (State.ToUpper() == "OFF") _DMOutput.DM_Output_Disabled();
            else { CrestronConsole.ConsoleCommandResponse("TDMOutputEnable" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing DM Output to {0}...\n", State.ToUpper());
        }
        void DMForceHDCPEnable(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.DM_Force_HDCP_Enable();
            else if (State.ToUpper() == "OFF") _DMOutput.DM_Force_HDCP_Disable();
            else { CrestronConsole.ConsoleCommandResponse("TDMForceHDCPEnable" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing DM Force HDCP to {0}...\n", State.ToUpper());
        }
        void HDMIOutputEnable(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.HDMI_Output_Enabled();
            else if (State.ToUpper() == "OFF") _DMOutput.HDMI_Output_Disabled();
            else { CrestronConsole.ConsoleCommandResponse("THDMIOutputEnable" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing HDMI Output to {0}...\n", State.ToUpper());
        }
        void HDMIForceHDCPEnable(string State)
        {
            if (State.ToUpper() == "ON") _DMOutput.HDMI_Force_HDCP_Enable();
            else if (State.ToUpper() == "OFF") _DMOutput.HDMI_Force_HDCP_Disable();
            else { CrestronConsole.ConsoleCommandResponse("THDMIForceHDCPEnable" + _DMOutput.DMOutputPort + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing HDMI Force HDCP to {0}...\n", State.ToUpper());
        }
        void SavePreset(string State)
        {
            if (State == "")
            {
                _DMOutput.Save_Preset();
                CrestronConsole.ConsoleCommandResponse("CMD:Saving Preset...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TSavePreset" + _DMOutput.DMOutputPort); return; }
        }
        void RecallPreset(string State)
        {
            if (State == "")
            {
                _DMOutput.Recall_Preset();
                CrestronConsole.ConsoleCommandResponse("CMD:Recalling Preset...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TRecallPreset" + _DMOutput.DMOutputPort); return; }
        }
        void PresetNumber(string Preset)
        {
            string MessageHelp = "PresetNumber" + _DMOutput.DMOutputPort + " value (1 to 5)";
            double preset = GetFirstParameterInteger(Preset, MessageHelp);
            if (preset >= 1 && preset <= 5)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Setting Preset to {0}", preset);
                _DMOutput.Preset_Number((ushort)preset);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void MasterVolume(string value)
        {
            string MessageHelp = "MasterVolume" + _DMOutput.DMOutputPort + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Master Volume to {0}", Gain);
                _DMOutput.Master_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void MicLevel(string value)
        {
            string MessageHelp = "MicLevel" + _DMOutput.DMOutputPort + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Mic Level to {0}", Gain);
                _DMOutput.Mic_Level((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void MicPan(string value)
        {
            string MessageHelp = "MicPan" + _DMOutput.DMOutputPort + " value (-32768 to 32767)";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -32768 && Gain <= 32767)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Mic Pan to {0}", Gain);
                _DMOutput.Mic_Pan((short)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SourceLevel(string value)
        {
            string MessageHelp = "TestGateHold" + _DMOutput.DMOutputPort + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Source Level to {0}", Gain);
                _DMOutput.Source_Level((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SourceBalance(string value)
        {
            string MessageHelp = "TestCompressorThreshold" + _DMOutput.DMOutputPort + " value (-32768 to 32767)";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -32768 && Gain <= 32767)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Source Balance to {0}", Gain);
                _DMOutput.Source_Balance((short)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void MinVolume(string value)
        {
            string MessageHelp = "MinVolume" + _DMOutput.DMOutputPort + " value (-80.0 to 40.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 40)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Minimum Volume to {0}", Gain);
                _DMOutput.Min_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void MaxVolume(string value)
        {
            string MessageHelp = "MaxVolume" + _DMOutput.DMOutputPort + " value (-30.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -30 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Maximum Volume to {0}", Gain);
                _DMOutput.Max_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void StartupVolume(string value)
        {
            string MessageHelp = "StartupVolume" + _DMOutput.DMOutputPort + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Startup Volume to {0}", Gain);
                _DMOutput.Startup_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SclrEnable(string value)
        {
            string MessageHelp = "TSclrEnable" + _DMOutput.DMOutputPort + " [0,1]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(eScalerEnableState),mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Scaler to {0}", ((eScalerEnableState)mode).ToString());
                _DMOutput.Scaler_Enabled((eScalerEnableState)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SclrUnderscanMode(string value)
        {
            string MessageHelp = "TSclrUnderscanMode" + _DMOutput.DMOutputPort + " [0,1,2,3]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(eDmScanMode), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Scaler Undescan Mode to {0}", ((eDmScanMode)mode).ToString());
                _DMOutput.Scaler_Underscan_Mode((eDmScanMode)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SclrDisplayMode(string value)
        {
            string MessageHelp = "TSclrDisplayMode" + _DMOutput.DMOutputPort + " [0,1,2,3]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(HDScalerScaler.eDisplayMode), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Scaler Display Mode to {0}", ((HDScalerScaler.eDisplayMode)mode).ToString());
                _DMOutput.Scaler_Display_Mode((HDScalerScaler.eDisplayMode)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SclrUsrResIndex(string value)
        {
            string MessageHelp = "TSclrUsrResIndex" + _DMOutput.DMOutputPort + " [1..47](except 2 or 4)";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(HDScalerScaler.eOutputResolution), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Scaler User Resolution to {0}", ((HDScalerScaler.eOutputResolution)mode).ToString());
                _DMOutput.Scaler_User_Resolution_Index((HDScalerScaler.eOutputResolution)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SclrOutStbyTimeout(string value)
        {
            string MessageHelp = "TSclrOutStbyTimeout" + _DMOutput.DMOutputPort + " [0,1,2,3,4,5,6]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(eDmStandbyTimeout), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Scaler Standby Timeout to {0}", ((eDmStandbyTimeout)mode).ToString());
                _DMOutput.Scaler_Out_Standby_Timeout((eDmStandbyTimeout)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void DMCECTx(string message)
        {
            string MessageHelp = "TDMCECTx" + _DMOutput.DMOutputPort + " message";
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
                _DMOutput.DM_CEC_Transmit(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void HDMICECTx(string message)
        {
            string MessageHelp = "THDMICECTx" + _DMOutput.DMOutputPort + " message";
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
                _DMOutput.HDMI_CEC_Transmit(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }

}