using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Cards;
using Crestron.SimplSharpPro.DeviceSupport;


namespace DMPS4K150
{


    public class DMPS4K150C_DM_Output 
    {

        #region Public Events and Properties
        public event Action<bool> Master_Mute_On_Changed;
        public bool Master_Mute_On_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.MasterMuteOnFeedBack.BoolValue; }
            private set { if (Master_Mute_On_Changed != null) Master_Mute_On_Changed(Master_Mute_On_fb); }
        }
        public event Action<bool> Master_Mute_Off_Changed;
        public bool Master_Mute_Off_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.MasterMuteOffFeedBack.BoolValue; }
            private set { if (Master_Mute_Off_Changed != null) Master_Mute_Off_Changed(Master_Mute_Off_fb); }
        }
        public event Action<bool> Mic_Mute_On_Changed;
        public bool Mic_Mute_On_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteOnFeedback[1].BoolValue; }
            private set { if (Mic_Mute_On_Changed != null) Mic_Mute_On_Changed(Mic_Mute_On_fb); }
        }
        public event Action<bool> Mic_Mute_Off_Changed;
        public bool Mic_Mute_Off_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteOffFeedback[1].BoolValue; }
            private set { if (Mic_Mute_Off_Changed != null) Mic_Mute_Off_Changed(Mic_Mute_Off_fb); }
        }
        public event Action<bool> Source_Mute_On_Changed;
        public bool Source_Mute_On_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.SourceMuteOnFeedBack.BoolValue; }
            private set { if (Source_Mute_On_Changed != null) Source_Mute_On_Changed(Source_Mute_On_fb); }
        }
        public event Action<bool> Source_Mute_Off_Changed;
        public bool Source_Mute_Off_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.SourceMuteOffFeedBack.BoolValue; }
            private set { if (Source_Mute_Off_Changed != null) Source_Mute_Off_Changed(Source_Mute_Off_fb); }
        }
        public event Action<bool> Mixer_Bypassed_Changed;
        public bool Mixer_Bypassed_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.SourceMuteOffFeedBack.BoolValue; }
            private set { if (Mixer_Bypassed_Changed != null) Mixer_Bypassed_Changed(Mixer_Bypassed_fb); }
        }

        public event Action<bool> DM_Output_Disabled_By_HDCP_Changed;
        public bool DM_Output_Disabled_By_HDCP_fb
        {
            get { return _DMOutput.DmOutputPort.DisabledByHdcpFeedback.BoolValue; }
            private set { if (DM_Output_Disabled_By_HDCP_Changed != null) DM_Output_Disabled_By_HDCP_Changed(DM_Output_Disabled_By_HDCP_fb); }
        }
        public event Action<bool> DM_Output_Enabled_Changed;
        public bool DM_Output_Enabled_fb
        {
            get { return _DMOutput.DmOutputPort.OutputEnabledFeedback.BoolValue; }
            private set { if (DM_Output_Enabled_Changed != null) DM_Output_Enabled_Changed(DM_Output_Enabled_fb); }
        }
        public event Action<bool> DM_Output_Disabled_Changed;
        public bool DM_Output_Disabled_fb
        {
            get { return _DMOutput.DmOutputPort.OutputDisabledFeedback.BoolValue; }
            private set { if (DM_Output_Disabled_Changed != null) DM_Output_Disabled_Changed(DM_Output_Disabled_fb); }
        }
        public event Action<bool> DM_Force_HDCP_Enable_Changed;
        public bool DM_Force_HDCP_Enable_fb
        {
            get { return _DMOutput.DmOutputPort.ForceHdcpEnabledFeedback.BoolValue; }
            private set { if (DM_Force_HDCP_Enable_Changed != null) DM_Force_HDCP_Enable_Changed(DM_Force_HDCP_Enable_fb); }
        }
        public event Action<bool> DM_Force_HDCP_Disable_Changed;
        public bool DM_Force_HDCP_Disable_fb
        {
            get { return _DMOutput.DmOutputPort.ForceHdcpEnabledFeedback.BoolValue; }
            private set { if (DM_Force_HDCP_Disable_Changed != null) DM_Force_HDCP_Disable_Changed(DM_Force_HDCP_Disable_fb); }
        }

        public event Action<bool> HDMI_Output_Disabled_By_HDCP_Changed;
        public bool HDMI_Output_Disabled_By_HDCP_fb
        {
            get { return _DMOutput.HdmiOutputPort.DisabledByHdcpFeedback.BoolValue; }
            private set { if (HDMI_Output_Disabled_By_HDCP_Changed != null) HDMI_Output_Disabled_By_HDCP_Changed(HDMI_Output_Disabled_By_HDCP_fb); }
        }
        public event Action<bool> HDMI_Output_Enabled_Changed;
        public bool HDMI_Output_Enabled_fb
        {
            get { return _DMOutput.HdmiOutputPort.OutputDisabledFeedback.BoolValue; }
            private set { if (HDMI_Output_Enabled_Changed != null) HDMI_Output_Enabled_Changed(HDMI_Output_Enabled_fb); }
        }
        public event Action<bool> HDMI_Output_Disabled_Changed;
        public bool HDMI_Output_Disabled_fb
        {
            get { return _DMOutput.HdmiOutputPort.OutputEnabledFeedback.BoolValue; }
            private set { if (HDMI_Output_Disabled_Changed != null) HDMI_Output_Disabled_Changed(HDMI_Output_Disabled_fb); }
        }
        public event Action<bool> HDMI_Force_HDCP_Enable_Changed;
        public bool HDMI_Force_HDCP_Enable_fb
        {
            get { return _DMOutput.HdmiOutputPort.ForceHdcpEnabledFeedback.BoolValue; }
            private set { if (HDMI_Force_HDCP_Enable_Changed != null) HDMI_Force_HDCP_Enable_Changed(HDMI_Force_HDCP_Enable_fb); }
        }
        public event Action<bool> HDMI_Force_HDCP_Disable_Changed;
        public bool HDMI_Force_HDCP_Disable_fb
        {
            get { return _DMOutput.HdmiOutputPort.ForceHdcpDisabledFeedback.BoolValue; }
            private set { if (HDMI_Force_HDCP_Disable_Changed != null) HDMI_Force_HDCP_Disable_Changed(HDMI_Force_HDCP_Disable_fb); }
        }
        public event Action<bool> DM_CEC_Error_Changed;
        public bool DM_CEC_Error_fb
        {
            get { return _DMOutput.DmOutputPort.StreamCec.ErrorFeedback.BoolValue; }
            private set { if (DM_CEC_Error_Changed != null) DM_CEC_Error_Changed(DM_CEC_Error_fb); }
        }
        public event Action<bool> HDMI_CEC_Error_Changed;
        public bool HDMI_CEC_Error_fb
        {
            get { return _DMOutput.HdmiOutputPort.StreamCec.ErrorFeedback.BoolValue; }
            private set { if (HDMI_CEC_Error_Changed != null) HDMI_CEC_Error_Changed(HDMI_CEC_Error_fb); }
        }
        public event Action<bool> Recalling_Preset_Changed;
        public bool Recalling_Preset_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.RecallingPresetFeedback.BoolValue; }
            private set { if (Recalling_Preset_Changed != null) Recalling_Preset_Changed(Recalling_Preset_fb); }
        }
        public event Action<bool> Preset_Ready_Pulse_Changed;
        public bool Preset_Ready_Pulse_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.PresetReadyPulseFeedback.BoolValue; }
            private set { if (Preset_Ready_Pulse_Changed != null) Preset_Ready_Pulse_Changed(Preset_Ready_Pulse_fb); }
        }
        public event Action<bool> ENDPOINT_ONLINE_Changed;
        public bool ENDPOINT_ONLINE_fb
        {
            get { return _DMOutput.EndpointOnlineFeedback; }
            private set { if (ENDPOINT_ONLINE_Changed != null) ENDPOINT_ONLINE_Changed(ENDPOINT_ONLINE_fb); }
        }

        public event Action<short> Master_Volume_Changed;
        public short Master_Volume_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.MasterVolumeFeedBack.ShortValue; }
            private set { if (Master_Volume_Changed != null) Master_Volume_Changed(Master_Volume_fb); }
        }
        public event Action<short> Mic_Level_Changed;
        public short Mic_Level_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.MicLevelFeedback[1].ShortValue; }
            private set { if (Mic_Level_Changed != null) Mic_Level_Changed(Mic_Level_fb); }
        }
        public event Action<short> Mic_Pan_Changed;
        public short Mic_Pan_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.MicPanFeedback[1].ShortValue; }
            private set { if (Mic_Pan_Changed != null) Mic_Pan_Changed(Mic_Pan_fb); }
        }
        public event Action<short> Source_Level_Changed;
        public short Source_Level_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.SourceLevelFeedBack.ShortValue; }
            private set { if (Source_Level_Changed != null) Source_Level_Changed(Source_Level_fb); }
        }
        public event Action<short> Source_Balance_Changed;
        public short Source_Balance_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.SourceBalanceFeedBack.ShortValue; }
            private set { if (Source_Balance_Changed != null) Source_Balance_Changed(Source_Balance_fb); }
        }

        public event Action<short> Min_Volume_Changed;
        public short Min_Volume_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.MinVolumeFeedback.ShortValue; }
            private set { if (Min_Volume_Changed != null) Min_Volume_Changed(Min_Volume_fb); }
        }
        public event Action<short> Max_Volume_Changed;
        public short Max_Volume_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.MaxVolumeFeedback.ShortValue; }
            private set { if (Max_Volume_Changed != null) Max_Volume_Changed(Max_Volume_fb); }
        }
        public event Action<short> Startup_Volume_Changed;
        public short Startup_Volume_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.StartupVolumeFeedback.ShortValue; }
            private set { if (Startup_Volume_Changed != null) Startup_Volume_Changed(Startup_Volume_fb); }
        }
        public event Action<ushort> VU_Changed;
        public ushort VU_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.OutputMixer.OutputVuFeedback.UShortValue; }
            private set { if (VU_Changed != null) VU_Changed(VU_fb); }
        }

        public event Action<eDmStream3DStatus> Source_3D_Status_Changed;
        public eDmStream3DStatus Source_3D_Status_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.Stream3DStatusFeedback; }
            private set { if (Source_3D_Status_Changed != null) Source_3D_Status_Changed(Source_3D_Status_fb); }
        }

        public event Action<eDmStreamDeepColor> DM_Deep_Color_Mode_Changed;
        public eDmStreamDeepColor DM_Deep_Color_Mode_fb
        {
            get { return _DMOutput.DmOutputPort.DeepColorModeFeedback; }
            private set { if (DM_Deep_Color_Mode_Changed != null) DM_Deep_Color_Mode_Changed(DM_Deep_Color_Mode_fb); }
        }
        public event Action<eDmStreamDeepColor> HDMI_Deep_Color_Mode_Changed;
        public eDmStreamDeepColor HDMI_Deep_Color_Mode_fb
        {
            get { return _DMOutput.HdmiOutputPort.DeepColorModeFeedback; }
            private set { if (HDMI_Deep_Color_Mode_Changed != null) HDMI_Deep_Color_Mode_Changed(HDMI_Deep_Color_Mode_fb); }
        }

        public event Action<eScalerEnableState> Scaler_Enabled_Changed;
        public eScalerEnableState Scaler_Enabled_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.Scaler.EnabledFeedback; }
            private set { if (Scaler_Enabled_Changed != null) Scaler_Enabled_Changed(Scaler_Enabled_fb); }
        }
        public event Action<eDmScanMode> Scaler_Underscan_Mode_Changed;
        public eDmScanMode Scaler_Underscan_Mode_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.Scaler.UnderscanModeFeedback; }
            private set { if (Scaler_Underscan_Mode_Changed != null) Scaler_Underscan_Mode_Changed(Scaler_Underscan_Mode_fb); }
        }
        public event Action<HDScalerScaler.eDisplayMode> Scaler_Display_Mode_Changed;
        public HDScalerScaler.eDisplayMode Scaler_Display_Mode_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.Scaler.DisplayModeFeedback; }
            private set { if (Scaler_Display_Mode_Changed != null) Scaler_Display_Mode_Changed(Scaler_Display_Mode_fb); }
        }
        public event Action<HDScalerScaler.eOutputResolution> Scaler_User_Resolution_Index_Changed;
        public HDScalerScaler.eOutputResolution Scaler_User_Resolution_Index_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.Scaler.UserResolutionIndexFeedback; }
            private set { if (Scaler_User_Resolution_Index_Changed != null) Scaler_User_Resolution_Index_Changed(Scaler_User_Resolution_Index_fb); }
        }
        public event Action<eDmStandbyTimeout> Scaler_Out_Standby_Timeout_Changed;
        public eDmStandbyTimeout Scaler_Out_Standby_Timeout_fb
        {
            get { return _DMOutput.DmHdmiOutputStream.Scaler.StandbyTimeoutFeedback; }
            private set { if (Scaler_Out_Standby_Timeout_Changed != null) Scaler_Out_Standby_Timeout_Changed(Scaler_Out_Standby_Timeout_fb); }
        }

        public event Action<string> DM_Manf_String_Changed;
        public string DM_Manf_String_fb
        {
            get { return _DMOutput.DmOutputPort.ConnectedDevice.Manufacturer.StringValue; }
            private set { if (DM_Manf_String_Changed != null) DM_Manf_String_Changed(DM_Manf_String_fb); }
        }
        public event Action<string> DM_Name_String_Changed;
        public string DM_Name_String_fb
        {
            get { return _DMOutput.DmOutputPort.ConnectedDevice.Name.StringValue; }
            private set { if (DM_Name_String_Changed != null) DM_Name_String_Changed(DM_Name_String_fb); }
        }
        public event Action<string> DM_Pref_Timing_String_Changed;
        public string DM_Pref_Timing_String_fb
        {
            get { return _DMOutput.DmOutputPort.ConnectedDevice.PreferredTiming.StringValue; }
            private set { if (DM_Pref_Timing_String_Changed != null) DM_Pref_Timing_String_Changed(DM_Pref_Timing_String_fb); }
        }
        public event Action<string> DM_Serial_Number_String_Changed;
        public string DM_Serial_Number_String_fb
        {
            get { return _DMOutput.DmOutputPort.ConnectedDevice.SerialNumber.StringValue; }
            private set { if (DM_Serial_Number_String_Changed != null) DM_Serial_Number_String_Changed(DM_Serial_Number_String_fb); }
        }

        public event Action<string> HDMI_Manf_String_Changed;
        public string HDMI_Manf_String_fb
        {
            get { return _DMOutput.HdmiOutputPort.ConnectedDevice.Manufacturer.StringValue; }
            private set { if (HDMI_Manf_String_Changed != null) HDMI_Manf_String_Changed(HDMI_Manf_String_fb); }
        }
        public event Action<string> HDMI_Name_String_Changed;
        public string HDMI_Name_String_fb
        {
            get { return _DMOutput.HdmiOutputPort.ConnectedDevice.Name.StringValue; }
            private set { if (HDMI_Name_String_Changed != null) HDMI_Name_String_Changed(HDMI_Name_String_fb); }
        }
        public event Action<string> HDMI_Pref_Timing_String_Changed;
        public string HDMI_Pref_Timing_String_fb
        {
            get { return _DMOutput.HdmiOutputPort.ConnectedDevice.PreferredTiming.StringValue; }
            private set { if (HDMI_Pref_Timing_String_Changed != null) HDMI_Pref_Timing_String_Changed(HDMI_Pref_Timing_String_fb); }
        }
        public event Action<string> HDMI_Serial_Number_String_Changed;
        public string HDMI_Serial_Number_String_fb
        {
            get { return _DMOutput.HdmiOutputPort.ConnectedDevice.SerialNumber.StringValue; }
            private set { if (HDMI_Serial_Number_String_Changed != null) HDMI_Serial_Number_String_Changed(HDMI_Serial_Number_String_fb); }
        }

        public event Action<string> DM_CEC_Receive_Changed;
        public string DM_CEC_Receive_fb
        {
            get { return _DMOutput.DmOutputPort.StreamCec.Received.StringValue; }
            private set { if (DM_CEC_Receive_Changed != null) DM_CEC_Receive_Changed(DM_CEC_Receive_fb); }
        }
        public event Action<string> DM_CEC_Display_Physical_Address_Changed;
        public string DM_CEC_Display_Physical_Address_fb
        {
            get { return _DMOutput.DmOutputPort.StreamCec.PhysicalAddress.StringValue; }
            private set { if (DM_CEC_Display_Physical_Address_Changed != null) DM_CEC_Display_Physical_Address_Changed(DM_CEC_Display_Physical_Address_fb); }
        }

        public event Action<string> HDMI_CEC_Receive_Changed;
        public string HDMI_CEC_Receive_fb
        {
            get { return _DMOutput.HdmiOutputPort.StreamCec.Received.StringValue; }
            private set { if (HDMI_CEC_Receive_Changed != null) HDMI_CEC_Receive_Changed(HDMI_CEC_Receive_fb); }
        }
        public event Action<string> HDMI_CEC_Display_Physical_Address_Changed;
        public string HDMI_CEC_Display_Physical_Address_fb
        {
            get { return _DMOutput.HdmiOutputPort.StreamCec.PhysicalAddress.StringValue; }
            private set { if (HDMI_CEC_Display_Physical_Address_Changed != null) HDMI_CEC_Display_Physical_Address_Changed(HDMI_CEC_Display_Physical_Address_fb); }
        }

        public string DMOutputPort { get; private set; }
        #endregion

        #region Public Methods
        public void Master_Volume_Up(bool State) { _DMOutput.DmHdmiOutputStream.MasterVolumeUp.BoolValue = State; }
        public void Master_Volume_Down(bool State) { _DMOutput.DmHdmiOutputStream.MasterVolumeDown.BoolValue = State; }
        public void Master_Mute_On() { _DMOutput.DmHdmiOutputStream.MasterMuteOn(); }
        public void Master_Mute_Off() { _DMOutput.DmHdmiOutputStream.MasterMuteOff(); }
        public void Master_Mute_Toggle() { _DMOutput.DmHdmiOutputStream.MasterMuteToggle(); }
        public void Mic_Level_Up(bool State) { _DMOutput.DmHdmiOutputStream.OutputMixer.MicLevelUp[1].BoolValue = State; }
        public void Mic_Level_Down(bool State) { _DMOutput.DmHdmiOutputStream.OutputMixer.MicLevelDown[1].BoolValue = State; }
        public void Mic_Mute_On() { _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteOn(1); }
        public void Mic_Mute_Off() { _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteOff(1); }
        public void Mic_Mute_Toggle() { _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteToggle(1); }
        public void Source_Level_Up(bool State) { _DMOutput.DmHdmiOutputStream.SourceLevelUp.BoolValue = State; }
        public void Source_Level_Down(bool State) { _DMOutput.DmHdmiOutputStream.SourceLevelDown.BoolValue = State; }
        public void Source_Mute_On() { _DMOutput.DmHdmiOutputStream.SourceMuteOn(); }
        public void Source_Mute_Off() { _DMOutput.DmHdmiOutputStream.SourceMuteOff(); }
        public void Source_Mute_Toggle() { _DMOutput.DmHdmiOutputStream.SourceMuteToggle(); }

        public void DM_Output_Enabled() { _DMOutput.DmOutputPort.OutputEnable(); }
        public void DM_Output_Disabled() { _DMOutput.DmOutputPort.OutputDisable(); }
        public void DM_Force_HDCP_Enable() { _DMOutput.DmOutputPort.ForceHdcpEnable(); }
        public void DM_Force_HDCP_Disable() { _DMOutput.DmOutputPort.ForceHdcpDisable(); }

        public void HDMI_Output_Enabled() { _DMOutput.HdmiOutputPort.OutputEnable(); }
        public void HDMI_Output_Disabled() { _DMOutput.HdmiOutputPort.OutputDisable(); }
        public void HDMI_Force_HDCP_Enable() { _DMOutput.HdmiOutputPort.ForceHdcpEnable(); }
        public void HDMI_Force_HDCP_Disable() { _DMOutput.HdmiOutputPort.ForceHdcpDisable(); }

        public void Save_Preset() { _DMOutput.DmHdmiOutputStream.SavePreset(); }
        public void Recall_Preset() { _DMOutput.DmHdmiOutputStream.RecallPreset(); }

        public void Preset_Number(ushort Preset)
        {
            if (Preset >= 1 && Preset <= 5) { _DMOutput.DmHdmiOutputStream.PresetNumber.UShortValue = Preset; } 
        }
        public void Master_Volume(short Volume)
        {
            if (Volume >= -800 && Volume <= 100) { _DMOutput.DmHdmiOutputStream.MasterVolume.ShortValue = Volume; }
        }
        public void Mic_Level(short Level)
        {
            if (Level >= -800 && Level <= 100) { _DMOutput.DmHdmiOutputStream.OutputMixer.MicLevel[1].ShortValue = Level; }
        }
        public void Mic_Pan(short Pan)
        {
            if (Pan >= -32768 && Pan <= 32767) { _DMOutput.DmHdmiOutputStream.OutputMixer.MicPan[1].ShortValue = Pan; }
        }
        public void Source_Level(short Level)
        {
            if (Level >= -800 && Level <= 100) { _DMOutput.DmHdmiOutputStream.SourceLevel.ShortValue = Level; }
        }
        public void Source_Balance(short Balance)
        {
            if (Balance >= -32768 && Balance <= 32767) { _DMOutput.DmHdmiOutputStream.SourceBalance.ShortValue = Balance; }
        }
        public void Min_Volume(short Volume)
        {
            if (Volume >= -800 && Volume <= -400) { _DMOutput.DmHdmiOutputStream.OutputMixer.MinVolume.ShortValue = Volume; }
        }
        public void Max_Volume(short Volume)
        {
            if (Volume >= -300 && Volume <= 100) { _DMOutput.DmHdmiOutputStream.OutputMixer.MaxVolume.ShortValue = Volume; }
        }
        public void Startup_Volume(short Volume)
        {
            if (Volume >= -800 && Volume <= 100) { _DMOutput.DmHdmiOutputStream.OutputMixer.StartupVolume.ShortValue = Volume; }
        }

        public void Scaler_Enabled(eScalerEnableState State){_DMOutput.DmHdmiOutputStream.Scaler.Enabled = State;}
        public void Scaler_Underscan_Mode(eDmScanMode Mode) {_DMOutput.DmHdmiOutputStream.Scaler.UnderscanMode = Mode;} 
        public void Scaler_Display_Mode(HDScalerScaler.eDisplayMode Mode) {_DMOutput.DmHdmiOutputStream.Scaler.DisplayMode = Mode;}
        public void Scaler_User_Resolution_Index(HDScalerScaler.eOutputResolution Index) { _DMOutput.DmHdmiOutputStream.Scaler.UserResolutionIndex = Index; }
        public void Scaler_Out_Standby_Timeout(eDmStandbyTimeout Index) { _DMOutput.DmHdmiOutputStream.Scaler.StandbyTimeout = Index; }

        public void DM_CEC_Transmit(string Message) { _DMOutput.DmOutputPort.StreamCec.Send.StringValue = Message; }
        public void HDMI_CEC_Transmit(string Message) { _DMOutput.HdmiOutputPort.StreamCec.Send.StringValue = Message; }
        #endregion

        #region Private Fields
        private Card.Dmps3DmHdmiAudioOutput _DMOutput;
        private ControlSystem _ControlSystem;
        private DMPS4K150C_SwitcherOutput _SwitcherOutput;


        //singletons
        private static DMPS4K150C_DM_Output DMOutput1;

        #endregion

        //factory to prevent duplicate instansiations.
        public static DMPS4K150C_DM_Output GetDMOutput(ControlSystem ControlSystem, ControlSystem.eDmps34K150COutputs Output)
        {

            if (TestOutputRange(Output))
            {
                switch (Output)
                {
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150COutputs.DmHdmiAnalogOutput:
                        return DMOutput1 ?? (DMOutput1 = new DMPS4K150C_DM_Output(ControlSystem, Output));
                    default:
                        return null;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        private DMPS4K150C_DM_Output(ControlSystem ControlSystem, ControlSystem.eDmps34K150COutputs Output)
        {
            //this.DMOutputPort = Output.ToString();
            this.DMOutputPort = "DM1Out";

            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            _SwitcherOutput = DMPS4K150C_SwitcherOutput.GetDMPS4K150C_SwitcherOutput(_ControlSystem);
            _DMOutput = _ControlSystem.SwitcherOutputs[(uint)Output] as Card.Dmps3DmHdmiAudioOutput;

            _SwitcherOutput.DmpsDmHdmiOutputStreamChanged += new DMPS4K150C_SwitcherOutput.SwitcherOutputEventHandler(_SwitcherOutput_DMHDMIOutputStreamChanged);
            _SwitcherOutput.HdmiOutputStreamChanged += new DMPS4K150C_SwitcherOutput.SwitcherOutputEventHandler(_SwitcherOutput_HdmiOutputStreamChanged);
            _SwitcherOutput.DmOutputStreamChanged += new DMPS4K150C_SwitcherOutput.SwitcherOutputEventHandler(_SwitcherOutput_DmOutputStreamChanged);
            _SwitcherOutput.DMOutputChanged += new DMPS4K150C_SwitcherOutput.SwitcherOutputEventHandler(_SwitcherOutput_DMOutputChanged);
            
            _DMOutput.DmOutputPort.StreamCec.CecChange += new CecChangeEventHandler(DMStreamCec_CecChange);
            _DMOutput.DmOutputPort.ConnectedDevice.DeviceInformationChange += new ConnectedDeviceChangeEventHandler(DMConnectedDevice_DeviceInformationChange);

            _DMOutput.HdmiOutputPort.StreamCec.CecChange += new CecChangeEventHandler(HDMIStreamCec_CecChange);
            _DMOutput.HdmiOutputPort.ConnectedDevice.DeviceInformationChange += new ConnectedDeviceChangeEventHandler(HDMIConnectedDevice_DeviceInformationChange);


        }

        void _SwitcherOutput_DMOutputChanged(IDmCardStreamBase stream, DMOutputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMOutputEventIds.EndpointOnlineEventId:
                    ENDPOINT_ONLINE_fb = _DMOutput.EndpointOnlineFeedback;
                    break;
                default:
                    break;
            }
        }

        void DMConnectedDevice_DeviceInformationChange(ConnectedDeviceInformation connectedDevice, ConnectedDeviceEventArgs args)
        {
            switch (args.EventId)
            {
                case ConnectedDeviceEventIds.ManufacturerEventId:
                    DM_Manf_String_fb = _DMOutput.DmOutputPort.ConnectedDevice.Manufacturer.StringValue;
                    break;
                case ConnectedDeviceEventIds.NameEventId:
                    DM_Name_String_fb = _DMOutput.DmOutputPort.ConnectedDevice.Name.StringValue;
                    break;
                case ConnectedDeviceEventIds.PreferredTimingEventId:
                    DM_Pref_Timing_String_fb = _DMOutput.DmOutputPort.ConnectedDevice.PreferredTiming.StringValue;
                    break;
                case ConnectedDeviceEventIds.SerialNumberEventId:
                    DM_Serial_Number_String_fb = _DMOutput.DmOutputPort.ConnectedDevice.SerialNumber.StringValue;
                    break;
                default:
                    break;
            }
        }

        void DMStreamCec_CecChange(Cec cecDevice, CecEventArgs args)
        {
            switch (args.EventId)
            {
                case CecEventIds.ErrorFeedbackEventId:
                    DM_CEC_Error_fb = _DMOutput.DmOutputPort.StreamCec.ErrorFeedback.BoolValue;
                    break;
                case CecEventIds.CecMessageReceivedEventId:
                    DM_CEC_Receive_fb = _DMOutput.DmOutputPort.StreamCec.Received.StringValue;
                    break;
                case CecEventIds.PhysicalAddressEventId:
                    DM_CEC_Display_Physical_Address_fb = _DMOutput.DmOutputPort.StreamCec.PhysicalAddress.StringValue;
                    break;
                default:
                    break;
            }
        }

        void HDMIConnectedDevice_DeviceInformationChange(ConnectedDeviceInformation connectedDevice, ConnectedDeviceEventArgs args)
        {
            switch (args.EventId)
            {
                case ConnectedDeviceEventIds.ManufacturerEventId:
                    HDMI_Manf_String_fb = _DMOutput.HdmiOutputPort.ConnectedDevice.Manufacturer.StringValue;
                    break;
                case ConnectedDeviceEventIds.NameEventId:
                    HDMI_Name_String_fb = _DMOutput.HdmiOutputPort.ConnectedDevice.Name.StringValue;
                    break;
                case ConnectedDeviceEventIds.PreferredTimingEventId:
                    HDMI_Pref_Timing_String_fb = _DMOutput.HdmiOutputPort.ConnectedDevice.PreferredTiming.StringValue;
                    break;
                case ConnectedDeviceEventIds.SerialNumberEventId:
                    HDMI_Serial_Number_String_fb = _DMOutput.HdmiOutputPort.ConnectedDevice.SerialNumber.StringValue;
                    break;
                default:
                    break;
            }
        }

        void HDMIStreamCec_CecChange(Cec cecDevice, CecEventArgs args)
        {
            switch (args.EventId)
            {
                case CecEventIds.ErrorFeedbackEventId:
                    HDMI_CEC_Error_fb = _DMOutput.HdmiOutputPort.StreamCec.ErrorFeedback.BoolValue;
                    break;
                case CecEventIds.CecMessageReceivedEventId:
                    HDMI_CEC_Receive_fb = _DMOutput.HdmiOutputPort.StreamCec.Received.StringValue;
                    break;
                case CecEventIds.PhysicalAddressEventId:
                    HDMI_CEC_Display_Physical_Address_fb = _DMOutput.HdmiOutputPort.StreamCec.PhysicalAddress.StringValue;
                    break;
                default:
                    break;
            }
        }

        void _SwitcherOutput_HdmiOutputStreamChanged(IDmCardStreamBase stream, DMOutputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMOutputEventIds.DisabledByHdcpEventId:
                    HDMI_Output_Disabled_By_HDCP_fb = _DMOutput.HdmiOutputPort.DisabledByHdcpFeedback.BoolValue;
                    break;
                case DMOutputEventIds.OutputEnabledEventId:
                    HDMI_Output_Enabled_fb = _DMOutput.HdmiOutputPort.OutputDisabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.OutputDisabledEventId:
                    HDMI_Output_Disabled_fb = _DMOutput.HdmiOutputPort.OutputEnabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.ForceHdcpEnabledEventId:
                    HDMI_Force_HDCP_Enable_fb = _DMOutput.HdmiOutputPort.ForceHdcpEnabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.ForceHdcpDisabledEventId:
                    HDMI_Force_HDCP_Disable_fb = _DMOutput.HdmiOutputPort.ForceHdcpDisabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.StreamDeepColorModeEventId:
                    HDMI_Deep_Color_Mode_fb = _DMOutput.HdmiOutputPort.DeepColorModeFeedback;
                    break;
                default:
                    break;
            }
        }

        void _SwitcherOutput_DmOutputStreamChanged(IDmCardStreamBase stream, DMOutputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMOutputEventIds.DisabledByHdcpEventId:
                    DM_Output_Disabled_By_HDCP_fb = _DMOutput.DmOutputPort.DisabledByHdcpFeedback.BoolValue;
                    break;
                case DMOutputEventIds.OutputEnabledEventId:
                    DM_Output_Enabled_fb = _DMOutput.DmOutputPort.OutputDisabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.OutputDisabledEventId:
                    DM_Output_Disabled_fb = _DMOutput.DmOutputPort.OutputEnabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.ForceHdcpEnabledEventId:
                    DM_Force_HDCP_Enable_fb = _DMOutput.DmOutputPort.ForceHdcpEnabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.ForceHdcpDisabledEventId:
                    DM_Force_HDCP_Disable_fb = _DMOutput.DmOutputPort.ForceHdcpDisabledFeedback.BoolValue;
                    break;
                case DMOutputEventIds.StreamDeepColorModeEventId:
                    DM_Deep_Color_Mode_fb = _DMOutput.DmOutputPort.DeepColorModeFeedback;
                    break;
                default:
                    break;
            }
        }

        void _SwitcherOutput_DMHDMIOutputStreamChanged(IDmCardStreamBase stream, DMOutputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMOutputEventIds.Stream3DStatusEventId:
                    Source_3D_Status_fb = _DMOutput.DmHdmiOutputStream.Stream3DStatusFeedback;
                    break;
                case DMOutputEventIds.ScalerEnabledEventId:
                    Scaler_Enabled_fb = _DMOutput.DmHdmiOutputStream.Scaler.EnabledFeedback;
                    break;
                case DMOutputEventIds.UnderscanEventId:
                    Scaler_Underscan_Mode_fb = _DMOutput.DmHdmiOutputStream.Scaler.UnderscanModeFeedback;
                    break;
                case DMOutputEventIds.MasterMuteOnFeedBackEventId:
                    Master_Mute_On_fb = _DMOutput.DmHdmiOutputStream.MasterMuteOnFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.MasterMuteOffFeedBackEventId:
                    Master_Mute_Off_fb = _DMOutput.DmHdmiOutputStream.MasterMuteOffFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.Mic1MuteOnFeedBackEventId:
                    Mic_Mute_On_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteOnFeedback[1].BoolValue;
                    break;
                case DMOutputEventIds.Mic1MuteOffFeedBackEventId:
                    Mic_Mute_Off_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.MicMuteOffFeedback[1].BoolValue;
                    break;
                case DMOutputEventIds.SourceMuteOnFeedBackEventId:
                    Source_Mute_On_fb = _DMOutput.DmHdmiOutputStream.SourceMuteOnFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.SourceMuteOffFeedBackEventId:
                    Source_Mute_Off_fb = _DMOutput.DmHdmiOutputStream.SourceMuteOffFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.MixerBypassedFeedBackEventId:
                    Mixer_Bypassed_fb = _DMOutput.DmHdmiOutputStream.SourceMuteOffFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.PresetReadyPulseFeedbackEventId:
                    Preset_Ready_Pulse_fb = _DMOutput.DmHdmiOutputStream.PresetReadyPulseFeedback.BoolValue;
                    break;
                case DMOutputEventIds.MasterVolumeFeedBackEventId:
                    Master_Volume_fb = _DMOutput.DmHdmiOutputStream.MasterVolumeFeedBack.ShortValue;
                    break;
                case DMOutputEventIds.Mic1LevelFeedBackEventId:
                    Mic_Level_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.MicLevelFeedback[1].ShortValue;
                    break;
                case DMOutputEventIds.Mic1PanFeedBackEventId:
                    Mic_Pan_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.MicPanFeedback[1].ShortValue;
                    break;
                case DMOutputEventIds.SourceLevelFeedBackEventId:
                    Source_Level_fb = _DMOutput.DmHdmiOutputStream.SourceLevelFeedBack.ShortValue;
                    break;
                case DMOutputEventIds.SourceBalanceFeedBackEventId:
                    Source_Balance_fb = _DMOutput.DmHdmiOutputStream.SourceBalanceFeedBack.ShortValue;
                    break;
                case DMOutputEventIds.MinVolumeFeedBackEventId:
                    Min_Volume_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.MinVolumeFeedback.ShortValue;
                    break;
                case DMOutputEventIds.MaxVolumeFeedBackEventId:
                    Max_Volume_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.MaxVolumeFeedback.ShortValue;
                    break;
                case DMOutputEventIds.OutputVuFeedBackEventId:
                    VU_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.OutputVuFeedback.UShortValue;
                    break;
                case DMOutputEventIds.StartupVolumeFeedBackEventId:
                    Startup_Volume_fb = _DMOutput.DmHdmiOutputStream.OutputMixer.StartupVolumeFeedback.ShortValue;
                    break;
                case DMOutputEventIds.RecallingPresetFeedbackEventId:
                    Recalling_Preset_fb = _DMOutput.DmHdmiOutputStream.RecallingPresetFeedback.BoolValue;
                    break;
                case 406:
                    Scaler_Enabled_fb = _DMOutput.DmHdmiOutputStream.Scaler.EnabledFeedback;
                    break;
                case 403:
                    Scaler_User_Resolution_Index_fb = _DMOutput.DmHdmiOutputStream.Scaler.UserResolutionIndexFeedback;
                    break;
                case 401:
                    Scaler_Underscan_Mode_fb = _DMOutput.DmHdmiOutputStream.Scaler.UnderscanModeFeedback;
                    break;
                case 402:
                    Scaler_Display_Mode_fb = _DMOutput.DmHdmiOutputStream.Scaler.DisplayModeFeedback;
                    break;
                case 404:
                    Scaler_Out_Standby_Timeout_fb = _DMOutput.DmHdmiOutputStream.Scaler.StandbyTimeoutFeedback;
                    break;

                default:
                    break;
            }
        }

        private static bool TestOutputRange(ControlSystem.eDmps34K150COutputs Output)
        {
            if (Output >= ControlSystem.eDmps34K150COutputs.DmHdmiAnalogOutput && Output <= ControlSystem.eDmps34K150COutputs.DmHdmiAnalogOutput) return true;
            else return false;
        }

    }
}