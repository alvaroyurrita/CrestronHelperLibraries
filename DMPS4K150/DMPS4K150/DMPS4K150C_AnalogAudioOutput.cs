using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Cards;
using System.Text.RegularExpressions;
using eDmps34K150COutputs = Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150COutputs;



namespace DMPS4K150
{
    public class DMPS4K150C_AnalogAudioOutput
    {
        #region Public Events and Properties
        public event Action<bool> Master_Mute_On_Changed;
        public bool Master_Mute_On_fb
        {
            get { return _AnalogAudioOutput.MasterMuteOnFeedBack.BoolValue; }
            private set { if (Master_Mute_On_Changed != null) Master_Mute_On_Changed(Master_Mute_On_fb); }
        }
        public event Action<bool> Master_Mute_Off_Changed;
        public bool Master_Mute_Off_fb
        {
            get { return _AnalogAudioOutput.MasterMuteOffFeedBack.BoolValue; }
            private set { if (Master_Mute_Off_Changed != null) Master_Mute_Off_Changed(Master_Mute_Off_fb); }
        }
        public event Action<bool> Mic_Mute_On_Changed;
        public bool Mic_Mute_On_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MicMuteOnFeedback[1].BoolValue; }
            private set { if (Mic_Mute_On_Changed != null) Mic_Mute_On_Changed(Mic_Mute_On_fb); }
        }
        public event Action<bool> Mic_Mute_Off_Changed;
        public bool Mic_Mute_Off_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MicMuteOffFeedback[1].BoolValue; }
            private set { if (Mic_Mute_Off_Changed != null) Mic_Mute_Off_Changed(Mic_Mute_Off_fb); }
        }
        public event Action<bool> Source_Mute_On_Changed;
        public bool Source_Mute_On_fb
        {
            get { return _AnalogAudioOutput.SourceMuteOnFeedBack.BoolValue; }
            private set { if (Source_Mute_On_Changed != null) Source_Mute_On_Changed(Source_Mute_On_fb); }
        }
        public event Action<bool> Source_Mute_Off_Changed;
        public bool Source_Mute_Off_fb
        {
            get { return _AnalogAudioOutput.SourceMuteOffFeedBack.BoolValue; }
            private set { if (Source_Mute_Off_Changed != null) Source_Mute_Off_Changed(Source_Mute_Off_fb); }
        }
        public event Action<bool> Mono_Output_Changed;
        public bool Mono_Output_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MonoOutputFeedback.BoolValue; }
            private set { if (Mono_Output_Changed != null) Mono_Output_Changed(Mono_Output_fb); }
        }
        public event Action<bool> Stereo_Output_Changed;
        public bool Stereo_Output_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.StereoOutputFeedback.BoolValue; }
            private set { if (Stereo_Output_Changed != null) Stereo_Output_Changed(Stereo_Output_fb); }
        }
        public event Action<bool> Limiter_Enable_Changed;
        public bool Limiter_Enable_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterEnableFeedback.BoolValue; }
            private set { if (Limiter_Enable_Changed != null) Limiter_Enable_Changed(Limiter_Enable_fb); }
        }
        public event Action<bool> Limiter_Disable_Changed;
        public bool Limiter_Disable_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterDisableFeedback.BoolValue; }
            private set { if (Limiter_Disable_Changed != null) Limiter_Disable_Changed(Limiter_Disable_fb); }
        }
        public event Action<bool> Limiter_Soft_Knee_Enable_Changed;
        public bool Limiter_Soft_Knee_Enable_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterSoftKneeOnFeedback.BoolValue; }
            private set { if (Limiter_Soft_Knee_Enable_Changed != null) Limiter_Soft_Knee_Enable_Changed(Limiter_Soft_Knee_Enable_fb); }
        }
        public event Action<bool> Limiter_Soft_Knee_Disable_Changed;
        public bool Limiter_Soft_Knee_Disable_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterSoftKneeOffFeedback.BoolValue; }
            private set { if (Limiter_Soft_Knee_Disable_Changed != null) Limiter_Soft_Knee_Disable_Changed(Limiter_Soft_Knee_Disable_fb); }
        }
        public event Action<bool> Mixer_Bypassed_Changed;
        public bool Mixer_Bypassed_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MixerBypassedFeedback.BoolValue; }
            private set { if (Mixer_Bypassed_Changed != null) Mixer_Bypassed_Changed(Mixer_Bypassed_fb); }
        }
        public event Action<bool> Recalling_Preset_Changed;
        public bool Recalling_Preset_fb
        {
            get { return _AnalogAudioOutput.RecallingPresetFeedback.BoolValue; }
            private set { if (Recalling_Preset_Changed != null) Recalling_Preset_Changed(Recalling_Preset_fb); }
        }
        public event Action<bool> Preset_Ready_Pulse_Changed;
        public bool Preset_Ready_Pulse_fb
        {
            get { return _AnalogAudioOutput.PresetReadyPulseFeedback.BoolValue; }
            private set { if (Preset_Ready_Pulse_Changed != null) Preset_Ready_Pulse_Changed(Preset_Ready_Pulse_fb); }
        }

        public event Action<short> Master_Volume_Changed;
        public short Master_Volume_fb
        {
            get { return _AnalogAudioOutput.MasterVolumeFeedBack.ShortValue; }
            private set { if (Master_Volume_Changed != null) Master_Volume_Changed(Master_Volume_fb); }
        }
        public event Action<short> Mic_Level_Changed;
        public short Mic_Level_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MicLevelFeedback[1].ShortValue; }
            private set { if (Mic_Level_Changed != null) Mic_Level_Changed(Mic_Level_fb); }
        }
        public event Action<short> Mic_Pan_Changed;
        public short Mic_Pan_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MicPanFeedback[1].ShortValue; }
            private set { if (Mic_Pan_Changed != null) Mic_Pan_Changed(Mic_Pan_fb); }
        }
        public event Action<short> Source_Level_Changed;
        public short Source_Level_fb
        {
            get { return _AnalogAudioOutput.SourceLevelFeedBack.ShortValue; }
            private set { if (Source_Level_Changed != null) Source_Level_Changed(Source_Level_fb); }
        }
        public event Action<short> Source_Balance_Changed;
        public short Source_Balance_fb
        {
            get { return _AnalogAudioOutput.SourceBalanceFeedBack.ShortValue; }
            private set { if (Source_Balance_Changed != null) Source_Balance_Changed(Source_Balance_fb); }
        }
        public event Action<ushort> Delay_Changed;
        public ushort Delay_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.DelayFeedback.UShortValue; }
            private set { if (Delay_Changed != null) Delay_Changed(Delay_fb); }
        }
        public event Action<short> Min_Volume_Changed;
        public short Min_Volume_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MinVolumeFeedback.ShortValue; }
            private set { if (Min_Volume_Changed != null) Min_Volume_Changed(Min_Volume_fb); }
        }
        public event Action<short> Max_Volume_Changed;
        public short Max_Volume_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.MaxVolumeFeedback.ShortValue; }
            private set { if (Max_Volume_Changed != null) Max_Volume_Changed(Max_Volume_fb); }
        }
        public event Action<short> Startup_Volume_Changed;
        public short Startup_Volume_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.StartupVolumeFeedback.ShortValue; }
            private set { if (Startup_Volume_Changed != null) Startup_Volume_Changed(Startup_Volume_fb); }
        }
        public event Action<ushort> VU_Changed;
        public ushort VU_fb
        {
            get { return _AnalogAudioOutput.OutputMixer.OutputVuFeedback.UShortValue; }
            private set { if (VU_Changed != null) VU_Changed(VU_fb); }
        }
        public event Action<short> Bass_Changed;
        public short Bass_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.BassFeedback.ShortValue; }
            private set { if (Bass_Changed != null) Bass_Changed(Bass_fb); }
        }
        public event Action<short> Treble_Changed;
        public short Treble_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.TrebleFeedback.ShortValue; }
            private set { if (Treble_Changed != null) Treble_Changed(Treble_fb); }
        }
        public event Action<short> Limiter_Threshold_Changed;
        public short Limiter_Threshold_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterThresholdFeedback.ShortValue; }
            private set { if (Limiter_Threshold_Changed != null) Limiter_Threshold_Changed(Limiter_Threshold_fb); }
        }
        public event Action<ushort> Limiter_Attack_Changed;
        public ushort Limiter_Attack_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterAttackFeedback.UShortValue; }
            private set { if (Limiter_Attack_Changed != null) Limiter_Attack_Changed(Limiter_Attack_fb); }
        }
        public event Action<ushort> Limiter_Release_Changed;
        public ushort Limiter_Release_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterReleaseFeedback.UShortValue; }
            private set { if (Limiter_Release_Changed != null) Limiter_Release_Changed(Limiter_Release_fb); }
        }
        public event Action<ushort> Limiter_Ratio_Changed;
        public ushort Limiter_Ratio_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.LimiterRatioFeedback.UShortValue; }
            private set { if (Limiter_Ratio_Changed != null) Limiter_Ratio_Changed(Limiter_Ratio_fb); }
        }
        public event Action<short> GEQ_Gain_31_5Hz_Changed;
        public short GEQ_Gain_31_5Hz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain315HzFeedback.ShortValue; }
            private set { if (GEQ_Gain_31_5Hz_Changed != null) GEQ_Gain_31_5Hz_Changed(GEQ_Gain_31_5Hz_fb); }
        }
        public event Action<short> GEQ_Gain_63Hz_Changed;
        public short GEQ_Gain_63Hz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain63HzFeedback.ShortValue; }
            private set { if (GEQ_Gain_63Hz_Changed != null) GEQ_Gain_63Hz_Changed(GEQ_Gain_63Hz_fb); }
        }        
        public event Action<short> GEQ_Gain_125Hz_Changed;
        public short GEQ_Gain_125Hz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain125HzFeedback.ShortValue; }
            private set { if (GEQ_Gain_125Hz_Changed != null) GEQ_Gain_125Hz_Changed(GEQ_Gain_125Hz_fb); }
        }
        public event Action<short> GEQ_Gain_250Hz_Changed;
        public short GEQ_Gain_250Hz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain250HzFeedback.ShortValue; }
            private set { if (GEQ_Gain_250Hz_Changed != null) GEQ_Gain_250Hz_Changed(GEQ_Gain_250Hz_fb); }
        }
        public event Action<short> GEQ_Gain_500Hz_Changed;
        public short GEQ_Gain_500Hz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain500HzFeedback.ShortValue; }
            private set { if (GEQ_Gain_500Hz_Changed != null) GEQ_Gain_500Hz_Changed(GEQ_Gain_500Hz_fb); }
        }
        public event Action<short> GEQ_Gain_1KHz_Changed;
        public short GEQ_Gain_1KHz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain1KHzFeedback.ShortValue; }
            private set { if (GEQ_Gain_1KHz_Changed != null) GEQ_Gain_1KHz_Changed(GEQ_Gain_1KHz_fb); }
        }
        public event Action<short> GEQ_Gain_2KHz_Changed;
        public short GEQ_Gain_2KHz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain2KHzFeedback.ShortValue; }
            private set { if (GEQ_Gain_2KHz_Changed != null) GEQ_Gain_2KHz_Changed(GEQ_Gain_2KHz_fb); }
        }
        public event Action<short> GEQ_Gain_4KHz_Changed;
        public short GEQ_Gain_4KHz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain4KHzFeedback.ShortValue; }
            private set { if (GEQ_Gain_4KHz_Changed != null) GEQ_Gain_4KHz_Changed(GEQ_Gain_4KHz_fb); }
        }
        public event Action<short> GEQ_Gain_8KHz_Changed;
        public short GEQ_Gain_8KHz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain8KHzFeedback.ShortValue; }
            private set { if (GEQ_Gain_8KHz_Changed != null) GEQ_Gain_8KHz_Changed(GEQ_Gain_8KHz_fb); }
        }
        public event Action<short> GEQ_Gain_16KHz_Changed;
        public short GEQ_Gain_16KHz_fb
        {
            get { return _AnalogAudioOutput.OutputEqualizer.GeqGain16KHzFeedback.ShortValue; }
            private set { if (GEQ_Gain_16KHz_Changed != null) GEQ_Gain_16KHz_Changed(GEQ_Gain_16KHz_fb); }
        }

        #endregion

        #region Public Methods
        public void Master_Volume_Up(bool State) { _AnalogAudioOutput.MasterVolumeUp.BoolValue = State; }
        public void Master_Volume_Down(bool State) { _AnalogAudioOutput.MasterVolumeDown.BoolValue = State; }
        public void Master_Mute_On() { _AnalogAudioOutput.MasterMuteOn(); }
        public void Master_Mute_Off() { _AnalogAudioOutput.MasterMuteOff(); }
        public void Master_Mute_Toggle() { _AnalogAudioOutput.MasterMuteToggle(); }
        public void Mic_Level_Up(bool State) { _AnalogAudioOutput.OutputMixer.MicLevelUp[1].BoolValue = State; }
        public void Mic_Level_Down(bool State) { _AnalogAudioOutput.OutputMixer.MicLevelDown[1].BoolValue = State; }
        public void Mic_Mute_On() { _AnalogAudioOutput.OutputMixer.MicMuteOn(1); }
        public void Mic_Mute_Off() { _AnalogAudioOutput.OutputMixer.MicMuteOff(1); }
        public void Mic_Mute_Toggle() { _AnalogAudioOutput.OutputMixer.MicMuteToggle(1); }
        public void Source_Level_Up(bool State) { _AnalogAudioOutput.SourceLevelUp.BoolValue = State; }
        public void Source_Level_Down(bool State) { _AnalogAudioOutput.SourceLevelDown.BoolValue = State; }
        public void Source_Mute_On() { _AnalogAudioOutput.SourceMuteOn(); }
        public void Source_Mute_Off() { _AnalogAudioOutput.SourceMuteOff(); }
        public void Source_Mute_Toggle() { _AnalogAudioOutput.SourceMuteToggle(); }
        public void Mono_Output() { _AnalogAudioOutput.OutputMixer.MonoOutput(); }
        public void Stereo_Output() { _AnalogAudioOutput.OutputMixer.StereoOutput(); }
        public void Bass_Up() { _AnalogAudioOutput.OutputEqualizer.BassUp.BoolValue = true; }
        public void Bass_Down() { _AnalogAudioOutput.OutputEqualizer.BassDown.BoolValue = true; }
        public void Bass_Flat() { _AnalogAudioOutput.OutputEqualizer.BassFlat(); }
        public void Treble_Up() { _AnalogAudioOutput.OutputEqualizer.TrebleUp.BoolValue = true; }
        public void Treble_Down() { _AnalogAudioOutput.OutputEqualizer.TrebleDown.BoolValue = true; }
        public void Treble_Flat() { _AnalogAudioOutput.OutputEqualizer.TrebleFlat(); }
        public void Limiter_Enable() { _AnalogAudioOutput.OutputEqualizer.LimiterEnable(); }
        public void Limiter_Disable() { _AnalogAudioOutput.OutputEqualizer.LimiterDisable(); }
        public void Limiter_Soft_Knee_Enable() { _AnalogAudioOutput.OutputEqualizer.LimiterSoftKneeOn(); }
        public void Limiter_Soft_Knee_Disable() { _AnalogAudioOutput.OutputEqualizer.LimiterSoftKneeOff(); }
        public void Save_Preset() { _AnalogAudioOutput.SavePreset(); }
        public void Recall_Preset() { _AnalogAudioOutput.RecallPreset(); }

        public void Preset_Number(ushort Preset)
        {
            if (Preset >= 1 && Preset <= 5) { _AnalogAudioOutput.PresetNumber.UShortValue = Preset; } 
        }
        public void Master_Volume(short Volume)
        {
            if (Volume >= -800 && Volume <= 100) { _AnalogAudioOutput.MasterVolume.ShortValue = Volume; }
        }
        public void Mic_Level(short Level)
        {
            if (Level >= -800 && Level <= 100) { _AnalogAudioOutput.OutputMixer.MicLevel[1].ShortValue = Level; }
        }
        public void Mic_Pan(short Pan)
        {
            if (Pan >= -32768 && Pan <= 32767) { _AnalogAudioOutput.OutputMixer.MicPan[1].ShortValue = Pan; }
        }
        public void Source_Level(short Level)
        {
            if (Level >= -800 && Level <= 100) { _AnalogAudioOutput.SourceLevel.ShortValue = Level; }
        }
        public void Source_Balance(short Balance)
        {
            if (Balance >= -32768 && Balance <= 32767) { _AnalogAudioOutput.SourceBalance.ShortValue = Balance; }
        }
        public void Delay(ushort Time)
        {
            if (Time >= 1 && Time <= 850) { _AnalogAudioOutput.OutputMixer.Delay.UShortValue = Time; }
        }
        public void Min_Volume(short Volume)
        {
            if (Volume >= -800 && Volume <= -400) { _AnalogAudioOutput.OutputMixer.MinVolume.ShortValue = Volume; }
        }
        public void Max_Volume(short Volume)
        {
            if (Volume >= -300 && Volume <= 100) { _AnalogAudioOutput.OutputMixer.MaxVolume.ShortValue = Volume; }
        }
        public void Startup_Volume(short Volume)
        {
            if (Volume >= -800 && Volume <= 100) { _AnalogAudioOutput.OutputMixer.StartupVolume.ShortValue = Volume; }
        }
        public void Bass(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.Bass.ShortValue = Level; }
        }
        public void Treble(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.Treble.ShortValue = Level; }
        }
        public void Limiter_Threshold(short Level)
        {
            if (Level >= -800 && Level <= 0) { _AnalogAudioOutput.OutputEqualizer.LimiterThreshold.ShortValue = Level; }
        }
        public void Limiter_Attack(ushort Time)
        {
            if (Time >= 1 && Time <= 250) { _AnalogAudioOutput.OutputEqualizer.LimiterAttack.UShortValue = Time; }
        }
        public void Limiter_Release(ushort Time)
        {
            if (Time >= 1 && Time <= 1000) { _AnalogAudioOutput.OutputEqualizer.LimiterRelease.UShortValue = Time; }
        }
        public void Limiter_Ratio(ushort Time)
        {
            if (Time >= 1 && Time <= 10) { _AnalogAudioOutput.OutputEqualizer.LimiterRatio.UShortValue = Time; }
        }
        public void GEQ_Gain_31_5Hz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain315Hz.ShortValue = Level; }
        }
        public void GEQ_Gain_63Hz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain63Hz.ShortValue = Level; }
        }
        public void GEQ_Gain_125Hz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain125Hz.ShortValue = Level; }
        }
        public void GEQ_Gain_250Hz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain250Hz.ShortValue = Level; }
        }
        public void GEQ_Gain_500Hz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain500Hz.ShortValue = Level; }
        }
        public void GEQ_Gain_1KHz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain1KHz.ShortValue = Level; }
        }
        public void GEQ_Gain_2KHz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain2KHz.ShortValue = Level; }
        }
        public void GEQ_Gain_4KHz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain4KHz.ShortValue = Level; }
        }
        public void GEQ_Gain_8KHz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain8KHz.ShortValue = Level; }
        }
        public void GEQ_Gain_16KHz(short Level)
        {
            if (Level >= -120 && Level <= 120) { _AnalogAudioOutput.OutputEqualizer.GeqGain16KHz.ShortValue = Level; }
        }
        #endregion

        #region Private Fields

        private Card.Dmps3HdmiAudioOutput.Dmps3AudioOutputStream _AnalogAudioOutput;
        private DMPS4K150C_SwitcherOutput _SwitcherOutput;


        //singleton
        private static DMPS4K150C_AnalogAudioOutput AnalogAudioOutput;

        private ControlSystem _ControlSystem;
    
        #endregion

        //singleton creator
        public static DMPS4K150C_AnalogAudioOutput GetDMPS4K150C_Mic(ControlSystem ControlSystem)
        {
            return AnalogAudioOutput ?? (AnalogAudioOutput = new DMPS4K150C_AnalogAudioOutput(ControlSystem));
        }

        private DMPS4K150C_AnalogAudioOutput(ControlSystem ControlSystem)
        {

            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            _AnalogAudioOutput = ((Card.Dmps3DmHdmiAudioOutput)ControlSystem.SwitcherOutputs[1]).AudioOutputStream;
            _SwitcherOutput = DMPS4K150C_SwitcherOutput.GetDMPS4K150C_SwitcherOutput(_ControlSystem);
            _SwitcherOutput.DmpsAudioOutputStreamChanged += new DMPS4K150C_SwitcherOutput.SwitcherOutputEventHandler(_SwitcherOutput_DmpsAudioOutputStreamChanged);
        }

        void _SwitcherOutput_DmpsAudioOutputStreamChanged(IDmCardStreamBase stream, DMOutputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMOutputEventIds.MasterMuteOnFeedBackEventId:
                    Master_Mute_On_fb = _AnalogAudioOutput.MasterMuteOnFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.MasterMuteOffFeedBackEventId:
                    Master_Mute_Off_fb = _AnalogAudioOutput.MasterMuteOffFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.Mic1MuteOnFeedBackEventId:
                    Mic_Mute_On_fb = _AnalogAudioOutput.OutputMixer.MicMuteOnFeedback[1].BoolValue;
                    break;
                case DMOutputEventIds.Mic1MuteOffFeedBackEventId:
                    Mic_Mute_Off_fb = _AnalogAudioOutput.OutputMixer.MicMuteOffFeedback[1].BoolValue;
                    break;
                case DMOutputEventIds.SourceMuteOnFeedBackEventId:
                    Source_Mute_On_fb = _AnalogAudioOutput.SourceMuteOnFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.SourceMuteOffFeedBackEventId:
                    Source_Mute_Off_fb = _AnalogAudioOutput.SourceMuteOffFeedBack.BoolValue;
                    break;
                case DMOutputEventIds.MonoOutputFeedBackEventId:
                    Mono_Output_fb = _AnalogAudioOutput.OutputMixer.MonoOutputFeedback.BoolValue;
                    break;
                case DMOutputEventIds.StereoOutputFeedBackEventId:
                    Stereo_Output_fb = _AnalogAudioOutput.OutputMixer.StereoOutputFeedback.BoolValue;
                    break;
                case DMOutputEventIds.LimiterEnableFeedbackEventId:
                    Limiter_Enable_fb = _AnalogAudioOutput.OutputEqualizer.LimiterEnableFeedback.BoolValue;
                    break;
                case DMOutputEventIds.LimiterDisableFeedbackEventId:
                    Limiter_Disable_fb = _AnalogAudioOutput.OutputEqualizer.LimiterDisableFeedback.BoolValue;
                    break;
                case DMOutputEventIds.LimiterSoftKneeOnFeedbackEventId:
                    Limiter_Soft_Knee_Enable_fb = _AnalogAudioOutput.OutputEqualizer.LimiterSoftKneeOnFeedback.BoolValue;
                    break;
                case DMOutputEventIds.LimiterSoftKneeOffFeedbackEventId:
                    Limiter_Soft_Knee_Disable_fb = _AnalogAudioOutput.OutputEqualizer.LimiterSoftKneeOffFeedback.BoolValue;
                    break;
                case DMOutputEventIds.MixerBypassedFeedBackEventId:
                    Mixer_Bypassed_fb = _AnalogAudioOutput.OutputMixer.MixerBypassedFeedback.BoolValue;
                    break;
                case DMOutputEventIds.RecallingPresetFeedbackEventId:
                    Recalling_Preset_fb = _AnalogAudioOutput.RecallingPresetFeedback.BoolValue;
                    break;
                case DMOutputEventIds.PresetReadyPulseFeedbackEventId:
                    Preset_Ready_Pulse_fb = _AnalogAudioOutput.PresetReadyPulseFeedback.BoolValue;
                    break;
                case DMOutputEventIds.MasterVolumeFeedBackEventId:
                    Master_Volume_fb = _AnalogAudioOutput.MasterVolumeFeedBack.ShortValue;
                    break;
                case DMOutputEventIds.Mic1LevelFeedBackEventId:
                    Mic_Level_fb = _AnalogAudioOutput.OutputMixer.MicLevelFeedback[1].ShortValue;
                    break;
                case DMOutputEventIds.Mic1PanFeedBackEventId:
                    Mic_Pan_fb = _AnalogAudioOutput.OutputMixer.MicPanFeedback[1].ShortValue; ;
                    break;
                case DMOutputEventIds.SourceLevelFeedBackEventId:
                    Source_Level_fb = _AnalogAudioOutput.SourceLevelFeedBack.ShortValue;
                    break;
                case DMOutputEventIds.SourceBalanceFeedBackEventId:
                    Source_Balance_fb = _AnalogAudioOutput.SourceBalanceFeedBack.ShortValue; ;
                    break;
                case DMOutputEventIds.DelayFeedBackEventId:
                    Delay_fb = _AnalogAudioOutput.OutputMixer.DelayFeedback.UShortValue;
                    break;
                case DMOutputEventIds.MinVolumeFeedBackEventId:
                    Min_Volume_fb = _AnalogAudioOutput.OutputMixer.MinVolumeFeedback.ShortValue;
                    break;
                case DMOutputEventIds.MaxVolumeFeedBackEventId:
                    Max_Volume_fb = _AnalogAudioOutput.OutputMixer.MaxVolumeFeedback.ShortValue;
                    break;
                case DMOutputEventIds.StartupVolumeFeedBackEventId:
                    Startup_Volume_fb = _AnalogAudioOutput.OutputMixer.StartupVolumeFeedback.ShortValue;
                    break;
                case DMOutputEventIds.OutputVuFeedBackEventId:
                    VU_fb = _AnalogAudioOutput.OutputMixer.OutputVuFeedback.UShortValue;
                    break;
                case DMOutputEventIds.BassEventId:
                    Bass_fb = _AnalogAudioOutput.OutputEqualizer.BassFeedback.ShortValue;
                    break;
                case DMOutputEventIds.TrebleEventId:
                    Treble_fb = _AnalogAudioOutput.OutputEqualizer.TrebleFeedback.ShortValue;
                    break;
                case DMOutputEventIds.LimiterThresholdFeedbackEventId:
                    Limiter_Threshold_fb = _AnalogAudioOutput.OutputEqualizer.LimiterThresholdFeedback.ShortValue;
                    break;
                case DMOutputEventIds.LimiterAttackFeedbackEventId:
                    Limiter_Attack_fb = _AnalogAudioOutput.OutputEqualizer.LimiterAttackFeedback.UShortValue;
                    break;
                case DMOutputEventIds.LimiterReleaseFeedbackEventId:
                    Limiter_Release_fb = _AnalogAudioOutput.OutputEqualizer.LimiterReleaseFeedback.UShortValue;
                    break;
                case DMOutputEventIds.LimiterRatioFeedbackEventId:
                    Limiter_Ratio_fb = _AnalogAudioOutput.OutputEqualizer.LimiterRatioFeedback.UShortValue;
                    break;
                case DMOutputEventIds.GeqGain315HzFeedbackEventId:
                    GEQ_Gain_31_5Hz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain315HzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain63HzFeedbackEventId:
                    GEQ_Gain_63Hz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain63HzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain125HzFeedbackEventId:
                    GEQ_Gain_125Hz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain125HzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain250HzFeedbackEventId:
                    GEQ_Gain_250Hz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain250HzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain500HzFeedbackEventId:
                    GEQ_Gain_500Hz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain500HzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain1KHzFeedbackEventId:
                    GEQ_Gain_1KHz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain1KHzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain2KHzFeedbackEventId:
                    GEQ_Gain_2KHz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain2KHzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain4KHzFeedbackEventId:
                    GEQ_Gain_4KHz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain4KHzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain8KHzFeedbackEventId:
                    GEQ_Gain_8KHz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain8KHzFeedback.ShortValue;
                    break;
                case DMOutputEventIds.GeqGain16KHzFeedbackEventId:
                    GEQ_Gain_16KHz_fb = _AnalogAudioOutput.OutputEqualizer.GeqGain16KHzFeedback.ShortValue;
                    break;
                default:
                    break;
            }

        }

    }
}