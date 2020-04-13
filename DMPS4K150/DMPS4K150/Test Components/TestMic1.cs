using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using Crestron.SimplSharpPro.DM;


namespace DMPS4K150.Test_Components
{

    public static class TestMic1
    {
        private static DMPS4K150C_Mic1 _Mic1;
        public static void Start(DMPS4K150C_Mic1 Mic1)
        {
            _Mic1 = Mic1;

            _Mic1.Clipping_Changed += (state) => { CrestronConsole.PrintLine("{2} Clipping State: {0}, {1}", state, _Mic1.Clipping_fb, "Mic1"); };
            _Mic1.Compressing_Changed += (state) => { CrestronConsole.PrintLine("{2} Compressing State: {0}, {1}", state, _Mic1.Compressing_fb, "Mic1"); };
            _Mic1.Compressor_Attack_Changed += (value) => { CrestronConsole.PrintLine("{2} Compressor Attack Value: {0}, {1}", value, _Mic1.Compressor_Attack_fb, "Mic1"); };
            _Mic1.Compressor_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2} Compressor Disable State: {0}, {1}", state, _Mic1.Compressor_Disable_fb, "Mic1"); };
            _Mic1.Compressor_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} Compressor Enalbe State: {0}, {1}", state, _Mic1.Compressor_Enable_fb, "Mic1"); };
            _Mic1.Compressor_Hold_Changed += (value) => { CrestronConsole.PrintLine("{2} Compressor Hold Value: {0}, {1}", value, _Mic1.Compressor_Hold_fb, "Mic1"); };
            _Mic1.Compressor_Ratio_Changed += (value) => { CrestronConsole.PrintLine("{2} Compressor Ratio Value: {0}, {1}", value, _Mic1.Compressor_Ratio_fb, "Mic1"); };
            _Mic1.Compressor_Release_Changed += (value) => { CrestronConsole.PrintLine("{2} Compressor Release Value: {0}, {1}", value, _Mic1.Compressor_Release_fb, "Mic1"); };
            _Mic1.Compressor_Soft_Knee_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Compressor Soft Knee Off State: {0}, {1}", state, _Mic1.Compressor_Soft_Knee_Off_fb, "Mic1"); };
            _Mic1.Compressor_Soft_Knee_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Compressor Soft Knee On State: {0}, {1}", state, _Mic1.Compressor_Soft_Knee_On_fb, "Mic1"); };
            _Mic1.Compressor_Threshold_Changed += (value) => { CrestronConsole.PrintLine("{2} Compressor Threshold Vale: {0}, {1}", (double)value / 10, (double)_Mic1.Compressor_Threshold_fb / 10, "Mic1"); };
            _Mic1.EQ_High_Band_Frequency_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ High Band Frequency Value: {0}, {1}", value, _Mic1.EQ_High_Band_Frequency_fb, "Mic1"); };
            _Mic1.EQ_High_Band_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ High Band Gain Value: {0}, {1}", (double)value / 10, (double)_Mic1.EQ_High_Band_Gain_fb / 10, "Mic1"); };
            _Mic1.EQ_High_Mid_Band_Frequency_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ High-Mid Band Frequency Value: {0}, {1}", value, _Mic1.EQ_High_Mid_Band_Frequency_fb, "Mic1"); };
            _Mic1.EQ_High_Mid_Band_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ High-Mid Band Gain Value: {0}, {1}", (double)value / 10, (double)_Mic1.EQ_High_Mid_Band_Gain_fb / 10, "Mic1"); };
            _Mic1.EQ_Low_Band_Frequency_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ Low Band Frequency Value: {0}, {1}", value, _Mic1.EQ_Low_Band_Frequency_fb, "Mic1"); };
            _Mic1.EQ_Low_Band_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ Low Band Gain Value: {0}, {1}", (double)value / 10, (double)_Mic1.EQ_Low_Band_Gain_fb / 10, "Mic1"); };
            _Mic1.EQ_Low_Mid_Band_Frequency_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ Low-Mid Band Frequency Value: {0}, {1}", value, _Mic1.EQ_Low_Mid_Band_Frequency_fb, "Mic1"); };
            _Mic1.EQ_Low_Mid_Band_Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} EQ Low-Mid Band Gain Value: {0}, {1}", (double)value / 10, (double)_Mic1.EQ_Low_Mid_Band_Gain_fb / 10, "Mic1"); };
            _Mic1.Gain_Changed += (value) => { CrestronConsole.PrintLine("{2} Gain Value: {0}, {1}", (double)value / 10, (double)_Mic1.Gain_fb/10, "Mic1"); };
            _Mic1.Gate_Attack_Changed += (value) => { CrestronConsole.PrintLine("{2} Gate Attack Value: {0}, {1}", value, _Mic1.Gate_Attack_fb, "Mic1"); };
            _Mic1.Gate_Depth_Changed += (value) => { CrestronConsole.PrintLine("{2} Gate Depth Value: {0}, {1}", (double)value / 10, (double)_Mic1.Gate_Depth_fb / 10, "Mic1"); };
            _Mic1.Gate_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2} Gate Disable State: {0}, {1}", state, _Mic1.Gate_Disable_fb, "Mic1"); };
            _Mic1.Gate_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} Gate Enable State: {0}, {1}", state, _Mic1.Gate_Enable_fb, "Mic1"); };
            _Mic1.Gate_Hold_Changed += (value) => { CrestronConsole.PrintLine("{2} Gate Hold Value: {0}, {1}", value, _Mic1.Gate_Hold_fb, "Mic1"); };
            _Mic1.Gate_Release_Changed += (value) => { CrestronConsole.PrintLine("{2} Gate Release Value: {0}, {1}", value, _Mic1.Gate_Release_fb, "Mic1"); };
            _Mic1.Gate_Threshold_Changed += (value) => { CrestronConsole.PrintLine("{2} Gate Threshold Value: {0}, {1}", (double)value / 10, (double)_Mic1.Gate_Threshold_fb / 10, "Mic1"); };
            _Mic1.Gating_Changed += (state) => { CrestronConsole.PrintLine("{2} Gating State: {0}, {1}", state, _Mic1.Gating_fb, "Mic1"); };
            _Mic1.High_Pass_Filter_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2} High Pass Filter Disable State: {0}, {1}", state, _Mic1.High_Pass_Filter_Disable_fb, "Mic1"); };
            _Mic1.High_Pass_Filter_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} High Pass Filter Enable State: {0}, {1}", state, _Mic1.High_Pass_Filter_Enable_fb, "Mic1"); };
            _Mic1.Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Mute Off State: {0}, {1}", state, _Mic1.Mute_Off_fb, "Mic1"); };
            _Mic1.Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Mute On State: {0}, {1}", state, _Mic1.Mute_On_fb, "Mic1"); };
            _Mic1.Nominal_Changed += (state) => { CrestronConsole.PrintLine("{2} Nominal State: {0}, {1}", state, _Mic1.Nominal_fb, "Mic1"); };
            _Mic1.Phantom_Power_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Phantom Power Off State: {0}, {1}", state, _Mic1.Phantom_Power_Off_fb, "Mic1"); };
            _Mic1.Phantom_Power_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Phantom Power On State: {0}, {1}", state, _Mic1.Phantom_Power_On_fb, "Mic1"); };
            _Mic1.VU_Changed += (value) => { CrestronConsole.PrintLine("{2} VU Value: {0}, {1}", value, _Mic1.VU_fb, "Mic1"); };


            CrestronConsole.AddNewConsoleCommand(Mute, "TMute" + "Mic1", "Sets/Resets Mute  for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(PhantomPower, "TPhantomPower" + "Mic1", "Sets/Resets Phantom Power for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GateEnable, "TGateEnable" + "Mic1", "Enables/Disables Gate for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Compressor, "TCompEnable" + "Mic1", "Enables/Disables Compressor for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CompressorSoftKnee, "TCompSoftKnee" + "Mic1", "Enables/Disables Compressor Soft Knew On for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(HighPassFilter, "THighPassFilter" + "Mic1", "Enables/Disables High Pass Filter for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Gain, "TGain" + "Mic1", "Changes Audio Gain for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GateThreshold, "TGateThreshold" + "Mic1", "Changes Gate Threshold for" + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GateDepth, "TGateDepth" + "Mic1", "Changes Gate Depth for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GateAttack, "TGateAttack" + "Mic1", "Changes Gate Attack for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GateRelease, "TGateRelease" + "Mic1", "Changes Gate Release for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GateHold, "TGateHold" + "Mic1", "Changes Gate Hold for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CompressorThreshold, "TCompThreshold" + "Mic1", "Changes Compressor Threshold for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CompressorAttack, "TCompAttack" + "Mic1", "Changes Compressor Attack for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CompressorRelease, "TCompRelease" + "Mic1", "Changes Compressor Release for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CompressorRatio, "CompRatio" + "Mic1", "Changes Compressor Ratio for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(CompressorHold, "TCompHold" + "Mic1", "Changes Compressor Hold for"  + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQHighBandFrequency, "TEQHighBandFreq" + "Mic1", "Changes EQ High Band Frequency for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQHighBandGain, "TEQHighBandGain" + "Mic1", "Changes EQ High Band Gain for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQHighMidBandFrequency, "TEQHighMidBandFreq" + "Mic1", "Changes EQ High-Mid Band Frequency for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQHighMidBandGain, "TEQHighMidBandGain" + "Mic1", "Changes EQ High-Mid Band Gain for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQLowMidBandFrequency, "TEQLowMidBandFreq" + "Mic1", "Changes EQ Low-Mid Band Frequency for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQLowMidBandGain, "TEQLowMidBandGain" + "Mic1", "Changes EQ Low-Mid Band Gain for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQLowBandFrequency, "TEQLowBandFreq" + "Mic1", "Changes EQ Low Band Frequency for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(EQLowBandGain, "TEQLowBandGain" + "Mic1", "Changes EQ Low Band Gain for " + "Mic1", ConsoleAccessLevelEnum.AccessOperator);

        }
        static double GetFirstParameterDouble(string value, string MessageHelp)
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
        static double GetFirstParameterInteger(string value, string MessageHelp)
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
        static void Mute(string State)
        {
            if (State.ToUpper() == "ON") _Mic1.Mute_On();
            else if (State.ToUpper() == "OFF") _Mic1.Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("TMute" + "Mic1" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Mute to {0}...\n", State.ToUpper());
        }
        static void PhantomPower(string State)
        {
            if (State.ToUpper() == "ON") _Mic1.Phantom_Power_On();
            else if (State.ToUpper() == "OFF") _Mic1.Phantom_Power_Off();
            else { CrestronConsole.ConsoleCommandResponse("TPhantomPower" + "Mic1" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Phantom Power to {0}...\n", State.ToUpper());
        }
        static void GateEnable(string State)
        {
            if (State.ToUpper() == "ON") _Mic1.Gate_Enable();
            else if (State.ToUpper() == "OFF") _Mic1.Gate_Disable();
            else { CrestronConsole.ConsoleCommandResponse("TGateEnable" + "Mic1" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Gate to {0}...\n", State.ToUpper());
        }
        static void Compressor(string State)
        {
            if (State.ToUpper() == "ON") _Mic1.Compressor_Enable();
            else if (State.ToUpper() == "OFF") _Mic1.Compressor_Disable();
            else { CrestronConsole.ConsoleCommandResponse("TCompressorEnable" + "Mic1" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor to {0}...\n", State.ToUpper());
        }
        static void CompressorSoftKnee(string State)
        {
            if (State.ToUpper() == "ON") _Mic1.Compressor_Soft_Knee_On();
            else if (State.ToUpper() == "OFF") _Mic1.Compressor_Soft_Knee_Off();
            else { CrestronConsole.ConsoleCommandResponse("TCompressorSoftKnee" + "Mic1" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor Soft Knee to {0}...\n", State.ToUpper());
        }
        static void HighPassFilter(string State)
        {
            if (State.ToUpper() == "ON") _Mic1.High_Pass_Filter_Enable();
            else if (State.ToUpper() == "OFF") _Mic1.High_Pass_Filter_Disable();
            else { CrestronConsole.ConsoleCommandResponse("THighPassFilter" + "Mic1" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing High Pass Filter to {0}...\n", State.ToUpper());
        }
        static void Gain(string value)
        {
            string MessageHelp = "TGain" + "Mic1" + " value (0.0 to 60.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= 0 && Gain <= 60)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gain to {0}", Gain);
                _Mic1.Gain((ushort)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GateThreshold(string value)
        {
            string MessageHelp = "TGateThreshold" + "Mic1" + " value (-80.0 to 0.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 0)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gate Threshold to {0}", Gain);
                _Mic1.Gate_Threshold((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GateDepth(string value)
        {
            string MessageHelp = "TGain" + "Mic1" + " value (-80.0 to 0.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 0)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gate Depth to {0}", Gain);
                _Mic1.Gate_Depth((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GateAttack(string value)
        {
            string MessageHelp = "TGateAttack" + "Mic1" + " value (1 to 250)ms";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 250)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gate Attack to {0}", Gain);
                _Mic1.Gate_Attack((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GateRelease(string value)
        {
            string MessageHelp = "TGateRelease" + "Mic1" + " value (1 to 1000)ms";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 1000)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gate Release to {0}", Gain);
                _Mic1.Gate_Release((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GateHold(string value)
        {
            string MessageHelp = "TGateHold" + "Mic1" + " value (1 to 200)ms";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 200)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Gate Hold to {0}", Gain);
                _Mic1.Gate_Hold((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CompressorThreshold(string value)
        {
            string MessageHelp = "TCompressorThreshold" + "Mic1" + " value (-80.0 to 0.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 0)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor Threshold to {0}", Gain);
                _Mic1.Compressor_Threshold((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CompressorAttack(string value)
        {
            string MessageHelp = "TCompressorAttack" + "Mic1" + " value (1 to 250)ms";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 250)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor Attack to {0}", Gain);
                _Mic1.Compressor_Attack((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CompressorRelease(string value)
        {
            string MessageHelp = "TCompressorRelease" + "Mic1" + " value (1 to 1000)ms";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 1000)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor Release to {0}", Gain);
                _Mic1.Compressor_Release((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CompressorRatio(string value)
        {
            string MessageHelp = "CompressorRatio" + "Mic1" + " value (1 to 10):1";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor Ratio to {0}", Gain);
                _Mic1.Compressor_Ratio((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void CompressorHold(string value)
        {
            string MessageHelp = "TCompressorHold" + "Mic1" + " value (1 to 200)ms";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 200)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Compressor Hold to {0}", Gain);
                _Mic1.Compressor_Hold((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQHighBandFrequency(string value)
        {
            string MessageHelp = "TEQHighBandFrequency" + "Mic1" + " value (3200 to 12800)Hz";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 3200 && Gain <= 12800)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ High Band Frequency to {0}", Gain);
                _Mic1.EQ_High_Band_Frequency((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQHighBandGain(string value)
        {
            string MessageHelp = "TGain" + "TEQHighBandGain" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ High Band Gain to {0}", Gain);
                _Mic1.EQ_High_Band_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQHighMidBandFrequency(string value)
        {
            string MessageHelp = "TEQHighMidBandFrequency" + "Mic1" + " value (800 to 3200)Hz";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 800 && Gain <= 3200)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ High-Mid Band Frequency to {0}", Gain);
                _Mic1.EQ_High_Mid_Band_Frequency((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQHighMidBandGain(string value)
        {
            string MessageHelp = "TEQHighMidBandGain" + "Mic1" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ High-Mid Band Gain to {0}", Gain);
                _Mic1.EQ_High_Mid_Band_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQLowMidBandFrequency(string value)
        {
            string MessageHelp = "TEQLowMidBandFrequency" + "Mic1" + " value (200 to 800)Hz";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 200 && Gain <= 800)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ Low-Mid Band Frequency to {0}", Gain);
                _Mic1.EQ_Low_Mid_Band_Frequency((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQLowMidBandGain(string value)
        {
            string MessageHelp = "TEQLowMidBandGain" + "Mic1" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ Low-Mid Band Gain to {0}", Gain);
                _Mic1.EQ_Low_Mid_Band_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQLowBandFrequency(string value)
        {
            string MessageHelp = "TEQLowBandFrequency" + "Mic1" + " value (50 to 200)Hz";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 50 && Gain <= 200)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ Low Band Frequency to {0}", Gain);
                _Mic1.EQ_Low_Band_Frequency((ushort)(Gain));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void EQLowBandGain(string value)
        {
            string MessageHelp = "TEQLowBandGain" + "Mic1" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing EQ Low Band Gain to {0}", Gain);
                _Mic1.EQ_Low_Band_Gain((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }

}