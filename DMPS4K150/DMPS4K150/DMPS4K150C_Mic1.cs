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
using eDmps34K150CInputs = Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs;
using eDmps34K150COutputs = Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150COutputs;



namespace DMPS4K150
{
    public class DMPS4K150C_Mic1
    {
        #region Public Events and Properties
        public event Action<bool> Mute_On_Changed;
        public bool Mute_On_fb
        {
            get { return Mic1.MuteOnFeedBack.BoolValue; }
            private set { if (Mute_On_Changed != null) Mute_On_Changed(Mute_On_fb); }
        }
        public event Action<bool> Mute_Off_Changed;
        public bool Mute_Off_fb
        {
            get { return Mic1.MuteOnFeedBack.BoolValue; }
            private set { if (Mute_Off_Changed != null) Mute_Off_Changed(Mute_Off_fb); }
        }
        public event Action<bool> Gating_Changed;
        public bool Gating_fb
        {
            get { return Mic1.GatingFeedBack.BoolValue; }
            private set { if (Gating_Changed != null) Gating_Changed(Gating_fb); }
        }
        public event Action<bool> Nominal_Changed;
        public bool Nominal_fb
        {
            get { return Mic1.NominalFeedBack.BoolValue; }
            private set { if (Nominal_Changed != null) Nominal_Changed(Nominal_fb); }
        }
        public event Action<bool> Clipping_Changed;
        public bool Clipping_fb
        {
            get { return Mic1.ClipFeedBack.BoolValue; }
            private set { if (Clipping_Changed != null) Clipping_Changed(Clipping_fb); }
        }
        public event Action<bool> Phantom_Power_On_Changed;
        public bool Phantom_Power_On_fb
        {
            get { return Mic1.PhantomPowerOnFeedBack.BoolValue; }
            private set { if (Phantom_Power_On_Changed != null) Phantom_Power_On_Changed(Phantom_Power_On_fb); }
        }
        public event Action<bool> Phantom_Power_Off_Changed;
        public bool Phantom_Power_Off_fb
        {
            get { return Mic1.PhantomPowerOffFeedBack.BoolValue; }
            private set { if (Phantom_Power_Off_Changed != null) Phantom_Power_Off_Changed(Phantom_Power_Off_fb); }
        }
        public event Action<bool> Gate_Enable_Changed;
        public bool Gate_Enable_fb
        {
            get { return Mic1.GateEnableFeedBack.BoolValue; }
            private set { if (Gate_Enable_Changed != null) Gate_Enable_Changed(Gate_Enable_fb); }
        }
        public event Action<bool> Gate_Disable_Changed;
        public bool Gate_Disable_fb
        {
            get { return Mic1.GateDisableFeedBack.BoolValue; }
            private set { if (Gate_Disable_Changed != null) Gate_Disable_Changed(Gate_Disable_fb); }
        }
        public event Action<bool> Compressor_Enable_Changed;
        public bool Compressor_Enable_fb
        {
            get { return Mic1.CompressorEnableFeedBack.BoolValue; }
            private set { if (Compressor_Enable_Changed != null) Compressor_Enable_Changed(Compressor_Enable_fb); }
        }
        public event Action<bool> Compressor_Disable_Changed;
        public bool Compressor_Disable_fb
        {
            get { return Mic1.CompressorDisableFeedBack.BoolValue; }
            private set { if (Compressor_Disable_Changed != null) Compressor_Disable_Changed(Compressor_Disable_fb); }
        }
        public event Action<bool> Compressor_Soft_Knee_On_Changed;
        public bool Compressor_Soft_Knee_On_fb
        {
            get { return Mic1.CompressorSoftKneeOnFeedBack.BoolValue; }
            private set { if (Compressor_Soft_Knee_On_Changed != null) Compressor_Soft_Knee_On_Changed(Compressor_Soft_Knee_On_fb); }
        }
        public event Action<bool> Compressor_Soft_Knee_Off_Changed;
        public bool Compressor_Soft_Knee_Off_fb
        {
            get { return Mic1.CompressorSoftKneeOffFeedBack.BoolValue; }
            private set { if (Compressor_Soft_Knee_Off_Changed != null) Compressor_Soft_Knee_Off_Changed(Compressor_Soft_Knee_Off_fb); }
        }
        public event Action<bool> Compressing_Changed;
        public bool Compressing_fb
        {
            get { return Mic1.CompressorThresholdReachedFeedBack.BoolValue; }
            private set { if (Compressing_Changed != null) Compressing_Changed(Compressing_fb); }
        }
        public event Action<bool> High_Pass_Filter_Enable_Changed;
        public bool High_Pass_Filter_Enable_fb
        {
            get { return Mic1.HighPassFilterEnableFeedBack.BoolValue; }
            private set { if (High_Pass_Filter_Enable_Changed != null) High_Pass_Filter_Enable_Changed(High_Pass_Filter_Enable_fb); }
        }
        public event Action<bool> High_Pass_Filter_Disable_Changed;
        public bool High_Pass_Filter_Disable_fb
        {
            get { return Mic1.HighPassFilterDisableFeedBack.BoolValue; }
            private set { if (High_Pass_Filter_Disable_Changed != null) High_Pass_Filter_Disable_Changed(High_Pass_Filter_Disable_fb); }
        }         


        public event Action<ushort> Gain_Changed;
        public ushort Gain_fb
        {
            get { return Mic1.GainFeedBack.UShortValue; }
            private set { if (Gain_Changed != null) Gain_Changed(Gain_fb); }
        }
        public event Action<ushort> VU_Changed;
        public ushort VU_fb
        {
            get { return Mic1.VuFeedBack.UShortValue; }
            private set { if (VU_Changed != null) VU_Changed(VU_fb); }
        }
        public event Action<short> Gate_Threshold_Changed;
        public short Gate_Threshold_fb
        {
            get { return Mic1.GateThresholdFeedBack.ShortValue; }
            private set { if (Gate_Threshold_Changed != null) Gate_Threshold_Changed(Gate_Threshold_fb); }
        }
        public event Action<short> Gate_Depth_Changed;
        public short Gate_Depth_fb
        {
            get { return Mic1.GateDepthFeedBack.ShortValue; }
            private set { if (Gate_Depth_Changed != null) Gate_Depth_Changed(Gate_Depth_fb); }
        }
        public event Action<ushort> Gate_Attack_Changed;
        public ushort Gate_Attack_fb
        {
            get { return Mic1.GateAttackFeedBack.UShortValue; }
            private set { if (Gate_Attack_Changed != null) Gate_Attack_Changed(Gate_Attack_fb); }
        }
        public event Action<ushort> Gate_Release_Changed;
        public ushort Gate_Release_fb
        {
            get { return Mic1.GateReleaseFeedBack.UShortValue; }
            private set { if (Gate_Release_Changed != null) Gate_Release_Changed(Gate_Release_fb); }
        }
        public event Action<ushort> Gate_Hold_Changed;
        public ushort Gate_Hold_fb
        {
            get { return Mic1.GateHoldFeedBack.UShortValue; }
            private set { if (Gate_Hold_Changed != null) Gate_Hold_Changed(Gate_Hold_fb); }
        }
        public event Action<short> Compressor_Threshold_Changed;
        public short Compressor_Threshold_fb
        {
            get { return Mic1.CompressorThresholdFeedBack.ShortValue; }
            private set { if (Compressor_Threshold_Changed != null) Compressor_Threshold_Changed(Compressor_Threshold_fb); }
        }
        public event Action<ushort> Compressor_Attack_Changed;
        public ushort Compressor_Attack_fb
        {
            get { return Mic1.CompressorAttackFeedBack.UShortValue; }
            private set { if (Compressor_Attack_Changed != null) Compressor_Attack_Changed(Compressor_Attack_fb); }
        }
        public event Action<ushort> Compressor_Release_Changed;
        public ushort Compressor_Release_fb
        {
            get { return Mic1.CompressorReleaseFeedBack.UShortValue; }
            private set { if (Compressor_Release_Changed != null) Compressor_Release_Changed(Compressor_Release_fb); }
        }
        public event Action<ushort> Compressor_Ratio_Changed;
        public ushort Compressor_Ratio_fb
        {
            get { return Mic1.CompressorRatioFeedBack.UShortValue; }
            private set { if (Compressor_Ratio_Changed != null) Compressor_Ratio_Changed(Compressor_Ratio_fb); }
        }
        public event Action<ushort> Compressor_Hold_Changed;
        public ushort Compressor_Hold_fb
        {
            get { return Mic1.CompressorHoldFeedBack.UShortValue; }
            private set { if (Compressor_Hold_Changed != null) Compressor_Hold_Changed(Compressor_Hold_fb); }
        }
        public event Action<ushort> EQ_High_Band_Frequency_Changed;
        public ushort EQ_High_Band_Frequency_fb
        {
            get { return Mic1.EqHighBandFrequencyFeedBack.UShortValue; }
            private set { if (EQ_High_Band_Frequency_Changed != null) EQ_High_Band_Frequency_Changed(EQ_High_Band_Frequency_fb); }
        }
        public event Action<ushort> EQ_High_Mid_Band_Frequency_Changed;
        public ushort EQ_High_Mid_Band_Frequency_fb
        {
            get { return Mic1.EqHighMidBandFrequencyFeedBack.UShortValue; }
            private set { if (EQ_High_Mid_Band_Frequency_Changed != null) EQ_High_Mid_Band_Frequency_Changed(EQ_High_Mid_Band_Frequency_fb); }
        }
        public event Action<ushort> EQ_Low_Mid_Band_Frequency_Changed;
        public ushort EQ_Low_Mid_Band_Frequency_fb
        {
            get { return Mic1.EqLowMidBandFrequencyFeedBack.UShortValue; }
            private set { if (EQ_Low_Mid_Band_Frequency_Changed != null) EQ_Low_Mid_Band_Frequency_Changed(EQ_Low_Mid_Band_Frequency_fb); }
        }
        public event Action<ushort> EQ_Low_Band_Frequency_Changed;
        public ushort EQ_Low_Band_Frequency_fb
        {
            get { return Mic1.EqLowBandFrequencyFeedBack.UShortValue; }
            private set { if (EQ_Low_Band_Frequency_Changed != null) EQ_Low_Band_Frequency_Changed(EQ_Low_Band_Frequency_fb); }
        }
        public event Action<short> EQ_High_Band_Gain_Changed;
        public short EQ_High_Band_Gain_fb
        {
            get { return Mic1.EqHighBandGainFeedBack.ShortValue; }
            private set { if (EQ_High_Band_Gain_Changed != null) EQ_High_Band_Gain_Changed(EQ_High_Band_Gain_fb); }
        }
        public event Action<short> EQ_High_Mid_Band_Gain_Changed;
        public short EQ_High_Mid_Band_Gain_fb
        {
            get { return Mic1.EqHighMidBandGainFeedBack.ShortValue; }
            private set { if (EQ_High_Mid_Band_Gain_Changed != null) EQ_High_Mid_Band_Gain_Changed(EQ_High_Mid_Band_Gain_fb); }
        }
        public event Action<short> EQ_Low_Mid_Band_Gain_Changed;
        public short EQ_Low_Mid_Band_Gain_fb
        {
            get { return Mic1.EqLowMidBandGainFeedBack.ShortValue; }
            private set { if (EQ_Low_Mid_Band_Gain_Changed != null) EQ_Low_Mid_Band_Gain_Changed(EQ_Low_Mid_Band_Gain_fb); }
        }
        public event Action<short> EQ_Low_Band_Gain_Changed;
        public short EQ_Low_Band_Gain_fb
        {
            get { return Mic1.EqLowBandGainFeedBack.ShortValue; }
            private set { if (EQ_Low_Band_Gain_Changed != null) EQ_Low_Band_Gain_Changed(EQ_Low_Band_Gain_fb); }
        }
   

        #endregion

        #region Public Methods
        public void Mute_On() { Mic1.MuteOn(); }
        public void Mute_Off() { Mic1.MuteOff(); }
        public void Phantom_Power_On() { Mic1.PhantomPowerOn(); }
        public void Phantom_Power_Off() { Mic1.PhantomPowerOff(); }
        public void Gate_Enable() { Mic1.GateEnable(); }
        public void Gate_Disable() { Mic1.GateDisable(); }
        public void Compressor_Enable() { Mic1.CompressorEnable(); }
        public void Compressor_Disable() { Mic1.CompressorDisable(); }
        public void Compressor_Soft_Knee_On() { Mic1.CompressorSoftKneeOn(); }
        public void Compressor_Soft_Knee_Off() { Mic1.CompressorSoftKneeOff(); }
        public void High_Pass_Filter_Enable() { Mic1.HighPassFilterEnable(); }
        public void High_Pass_Filter_Disable() { Mic1.HighPassFilterDisable(); }

        public void Gain(ushort Gain)
        {
            if (Gain >= 0 && Gain <= 600) { Mic1.Gain.UShortValue = Gain; }
        }
        public void Gate_Threshold(short Threshold)
        {
            if (Threshold >= -800 && Threshold <= 0) { Mic1.GateThreshold.ShortValue = Threshold; }
        }
        public void Gate_Depth(short Depth)
        {
            if (Depth >= -800 && Depth <= 0) { Mic1.GateDepth.ShortValue = Depth; }
        }
        public void Gate_Attack(ushort Time)
        {
            if (Time >= 1 && Time <= 250) { Mic1.GateAttack.UShortValue = Time; }
        }
        public void Gate_Release(ushort Time)
        {
            if (Time >= 1 && Time <= 1000) { Mic1.GateRelease.UShortValue = Time; }
        }
        public void Gate_Hold(ushort Time)
        {
            if (Time >= 1 && Time <= 200) { Mic1.GateHold.UShortValue = Time; }
        }
        public void Compressor_Threshold(short Gain)
        {
            if (Gain >= -800 && Gain <= 0) { Mic1.CompressorThreshold.ShortValue = Gain; }
        }
        public void Compressor_Attack(ushort Time)
        {
            if (Time >= 1 && Time <= 250) { Mic1.CompressorAttack.UShortValue = Time; }
        }
        public void Compressor_Release(ushort Time)
        {
            if (Time >= 1 && Time <= 1000) { Mic1.CompressorRelease.UShortValue = Time; }
        }
        public void Compressor_Ratio(ushort Ratio)
        {
            if (Ratio >= 1 && Ratio <= 10) { Mic1.CompressorRatio.UShortValue = Ratio; }
        }
        public void Compressor_Hold(ushort Time)
        {
            if (Time >= 1 && Time <= 200) { Mic1.CompressorHold.UShortValue = Time; }
        }
        public void EQ_High_Band_Frequency(ushort Frequency)
        {
            if (Frequency >= 3200 && Frequency <= 12800) { Mic1.EqHighBandFrequency.UShortValue = Frequency; }
        }
        public void EQ_High_Mid_Band_Frequency(ushort Frequency)
        {
            if (Frequency >= 800 && Frequency <= 3200) { Mic1.EqHighMidBandFrequency.UShortValue = Frequency; }
        }
        public void EQ_Low_Mid_Band_Frequency(ushort Frequency)
        {
            if (Frequency >= 200 && Frequency <= 800) { Mic1.EqLowMidBandFrequency.UShortValue = Frequency; }
        }
        public void EQ_Low_Band_Frequency(ushort Frequency)
        {
            if (Frequency >= 50 && Frequency <= 200) { Mic1.EqLowBandFrequency.UShortValue = Frequency; }
        }
        public void EQ_High_Band_Gain(short Gain)
        {
            if (Gain >= -120 && Gain <= 120) { Mic1.EqHighBandGain.ShortValue = Gain; }
        }
        public void EQ_High_Mid_Band_Gain(short Gain)
        {
            if (Gain >= -120 && Gain <= 120) { Mic1.EqHighMidBandGain.ShortValue = Gain; }
        }
        public void EQ_Low_Mid_Band_Gain(short Gain)
        {
            if (Gain >= -120 && Gain <= 120) { Mic1.EqLowMidBandGain.ShortValue = Gain; }
        }
        public void EQ_Low_Band_Gain(short Gain)
        {
            if (Gain >= -120 && Gain <= 120) { Mic1.EqLowBandGain.ShortValue = Gain; }
        }
        #endregion

        #region Private Fields
        private Dmps3Microphone Mic1;


        //singleton
        private static DMPS4K150C_Mic1 _Mic1;

        private ControlSystem _ControlSystem;
    
        #endregion

        //singleton creator
        public static DMPS4K150C_Mic1 GetDMPS4K150C_Mic(ControlSystem ControlSystem)
        {
            return _Mic1 ?? (_Mic1 = new DMPS4K150C_Mic1(ControlSystem));
        }

        private DMPS4K150C_Mic1(ControlSystem ControlSystem)
        {

            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            Mic1 = (Dmps3Microphone)ControlSystem.Microphones[1];

            _ControlSystem.MicrophoneChange += new MicrophoneChangeEventHandler(_ControlSystem_MicrophoneChange);
        }

        void _ControlSystem_MicrophoneChange(MicrophoneBase device, GenericEventArgs args)
        {
            switch (args.EventId)
            {
                case MicrophoneEventIds.MuteOnFeedBackEventId:
                    Mute_On_fb = Mic1.MuteOnFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.MuteOffFeedBackEventId:
                    Mute_Off_fb = Mic1.MuteOnFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.GatingFeedBackEventId:
                    Gating_fb = Mic1.GatingFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.NominalFeedBackEventId:
                    Nominal_fb = Mic1.NominalFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.ClipFeedBackEventId:
                    Clipping_fb = Mic1.ClipFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.PhantomPowerOnFeedBackEventId:
                    Phantom_Power_On_fb = Mic1.PhantomPowerOnFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.PhantomPowerOffFeedBackEventId:
                    Phantom_Power_Off_fb = Mic1.PhantomPowerOffFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.GateEnableFeedBackEventId:
                    Gate_Enable_fb = Mic1.GateEnableFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.GateDisableFeedBackEventId:
                    Gate_Disable_fb = Mic1.GateDisableFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.CompressorEnableFeedBackEventId:
                    Compressor_Enable_fb = Mic1.CompressorEnableFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.CompressorDisableFeedBackEventId:
                    Compressor_Disable_fb = Mic1.CompressorDisableFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.CompressorSoftKneeOnFeedBackEventId:
                    Compressor_Soft_Knee_On_fb = Mic1.CompressorSoftKneeOnFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.CompressorSoftKneeOffFeedBackEventId:
                    Compressor_Soft_Knee_Off_fb = Mic1.CompressorSoftKneeOffFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.CompressorThresholdReachedFeedBackEventId:
                    Compressing_fb = Mic1.CompressorThresholdReachedFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.HighPassFilterEnableFeedBackEventId:
                    High_Pass_Filter_Enable_fb = Mic1.HighPassFilterEnableFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.HighPassFilterDisableFeedBackEventId:
                    High_Pass_Filter_Disable_fb = Mic1.HighPassFilterDisableFeedBack.BoolValue;
                    break;
                case MicrophoneEventIds.GainFeedBackEventId:
                    Gain_fb = Mic1.GainFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.VuFeedBackEventId:
                    VU_fb = Mic1.VuFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.GateThresholdFeedBackEventId:
                    Gate_Threshold_fb = Mic1.GateThresholdFeedBack.ShortValue;
                    break;
                case MicrophoneEventIds.GateDepthFeedBackEventId:
                    Gate_Depth_fb = Mic1.GateDepthFeedBack.ShortValue;
                    break;
                case MicrophoneEventIds.GateAttackFeedBackEventId:
                    Gate_Attack_fb = Mic1.GateAttackFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.GateReleaseFeedBackEventId:
                    Gate_Release_fb = Mic1.GateReleaseFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.GateHoldFeedBackEventId:
                    Gate_Hold_fb = Mic1.GateHoldFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.CompressorThresholdFeedBackEventId:
                    Compressor_Threshold_fb = Mic1.CompressorThresholdFeedBack.ShortValue;
                    break;
                case MicrophoneEventIds.CompressorAttackFeedBackEventId:
                    Compressor_Attack_fb = Mic1.CompressorAttackFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.CompressorReleaseFeedBackEventId:
                    Compressor_Release_fb = Mic1.CompressorReleaseFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.CompressorRatioFeedBackEventId:
                    Compressor_Ratio_fb = Mic1.CompressorRatioFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.CompressorHoldFeedBackEventId:
                    Compressor_Hold_fb = Mic1.CompressorHoldFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.EqHighBandFrequencyFeedBackEventId:
                    EQ_High_Band_Frequency_fb = Mic1.EqHighBandFrequencyFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.EqHighMidBandFrequencyFeedBackEventId:
                    EQ_High_Mid_Band_Frequency_fb = Mic1.EqHighMidBandFrequencyFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.EqLowMidBandFrequencyFeedBackEventId:
                    EQ_Low_Mid_Band_Frequency_fb = Mic1.EqLowMidBandFrequencyFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.EqLowBandFrequencyFeedBackEventId:
                    EQ_Low_Band_Frequency_fb = Mic1.EqLowBandFrequencyFeedBack.UShortValue;
                    break;
                case MicrophoneEventIds.EqHighBandGainFeedBackEventId:
                    EQ_High_Band_Gain_fb = Mic1.EqHighBandGainFeedBack.ShortValue;
                    break;
                case MicrophoneEventIds.EqHighMidBandGainFeedBackEventId:
                    EQ_High_Mid_Band_Gain_fb = Mic1.EqHighMidBandGainFeedBack.ShortValue;
                    break;
                case MicrophoneEventIds.EqLowMidBandGainFeedBackEventId:
                    EQ_Low_Mid_Band_Gain_fb = Mic1.EqLowMidBandGainFeedBack.ShortValue;
                    break;
                case MicrophoneEventIds.EqLowBandGainFeedBackEventId:
                    EQ_Low_Band_Gain_fb = Mic1.EqLowBandGainFeedBack.ShortValue;
                    break;
                default:
                    break;
            }
        }
    }

    
}