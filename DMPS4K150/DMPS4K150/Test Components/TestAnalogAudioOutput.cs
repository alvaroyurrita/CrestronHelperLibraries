using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using Crestron.SimplSharpPro.DM;


namespace DMPS4K150.Test_Components
{

    public static class TestAnalogAudioOutput
    {
        private static DMPS4K150C_AnalogAudioOutput _AnalogAudioOutput;
        public static void Start(DMPS4K150C_AnalogAudioOutput Mic1)
        {
            _AnalogAudioOutput = Mic1;

            _AnalogAudioOutput.Bass_Changed += (value) => { CrestronConsole.PrintLine("{2} Bass Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Bass_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Delay_Changed += (value) => { CrestronConsole.PrintLine("{2} Delay Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Delay_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_125Hz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 125Hz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_125Hz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_16KHz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 16KHz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_16KHz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_1KHz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 1KHz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_1KHz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_250Hz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 250Hz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_250Hz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_2KHz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 2KHz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_2KHz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_31_5Hz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 31.5Hz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_31_5Hz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_4KHz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 4KHz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_4KHz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_500Hz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 500Hz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_500Hz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_63Hz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 3Hz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_63Hz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.GEQ_Gain_8KHz_Changed += (value) => { CrestronConsole.PrintLine("{2} GEQ Gain 8KHz Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.GEQ_Gain_8KHz_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Attack_Changed += (value) => { CrestronConsole.PrintLine("{2} Limiter Attack Value: {0}, {1}", value, _AnalogAudioOutput.Limiter_Attack_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2} Limiter Disable state: {0}, {1}", state, _AnalogAudioOutput.Limiter_Disable_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} Limiter Enable State: {0}, {1}", state, _AnalogAudioOutput.Limiter_Enable_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Ratio_Changed += (value) => { CrestronConsole.PrintLine("{2} Limiter Ratio Value: {0}, {1}", value, _AnalogAudioOutput.Limiter_Ratio_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Release_Changed += (value) => { CrestronConsole.PrintLine("{2} Limiter Release Value: {0}, {1}", value, _AnalogAudioOutput.Limiter_Release_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Soft_Knee_Disable_Changed += (state) => { CrestronConsole.PrintLine("{2}Limiter Soft Knee Disable State: {0}, {1}", state, _AnalogAudioOutput.Limiter_Soft_Knee_Disable_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Soft_Knee_Enable_Changed += (state) => { CrestronConsole.PrintLine("{2} Limiter Soft Knee Enable State: {0}, {1}", state, _AnalogAudioOutput.Limiter_Soft_Knee_Enable_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Limiter_Threshold_Changed += (value) => { CrestronConsole.PrintLine("{2} Limiter Threshold Value: {0}, {1}", value, _AnalogAudioOutput.Limiter_Threshold_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Master_Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Master Mute Off State: {0}, {1}", state, _AnalogAudioOutput.Master_Mute_Off_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Master_Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Master Mute On State: {0}, {1}", state, _AnalogAudioOutput.Master_Mute_On_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Master_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Master Volume Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Master_Volume_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Max_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Max Volume Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Max_Volume_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Mic_Level_Changed += (value) => { CrestronConsole.PrintLine("{2} Mic Level Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Mic_Level_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Mic_Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Mic Mute Off State: {0}, {1}", state, _AnalogAudioOutput.Mic_Mute_Off_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Mic_Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Mic Mute On State: {0}, {1}", state, _AnalogAudioOutput.Mic_Mute_On_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Mic_Pan_Changed += (value) => { CrestronConsole.PrintLine("{2} Mic Pan: {0}, {1}", value, _AnalogAudioOutput.Mic_Pan_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Min_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Min Volume Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Min_Volume_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Mixer_Bypassed_Changed += (state) => { CrestronConsole.PrintLine("{2} Mixer Bypassed State: {0}, {1}", state, _AnalogAudioOutput.Mixer_Bypassed_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Mono_Output_Changed += (state) => { CrestronConsole.PrintLine("{2} Mono Output State: {0}, {1}", state, _AnalogAudioOutput.Mono_Output_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Preset_Ready_Pulse_Changed += (state) => { CrestronConsole.PrintLine("{2} Preset Ready Pulse State: {0}, {1}", state, _AnalogAudioOutput.Preset_Ready_Pulse_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Recalling_Preset_Changed += (state) => { CrestronConsole.PrintLine("{2} Recalling Preset State: {0}, {1}", state, _AnalogAudioOutput.Recalling_Preset_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Source_Balance_Changed += (value) => { CrestronConsole.PrintLine("{2} Source Balance Value: {0}, {1}", value, _AnalogAudioOutput.Source_Balance_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Source_Level_Changed += (value) => { CrestronConsole.PrintLine("{2} Source Level Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Source_Level_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Source_Mute_Off_Changed += (state) => { CrestronConsole.PrintLine("{2} Source Mute Off State: {0}, {1}", state, _AnalogAudioOutput.Source_Mute_Off_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Source_Mute_On_Changed += (state) => { CrestronConsole.PrintLine("{2} Source Mute On State: {0}, {1}", state, _AnalogAudioOutput.Source_Mute_On_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Startup_Volume_Changed += (value) => { CrestronConsole.PrintLine("{2} Startup Volume Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Startup_Volume_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.Stereo_Output_Changed += (state) => { CrestronConsole.PrintLine("{2} Stereo Output State: {0}, {1}", state, _AnalogAudioOutput.Stereo_Output_fb, "Analog Audio Out"); };
            _AnalogAudioOutput.Treble_Changed += (value) => { CrestronConsole.PrintLine("{2} Treble Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.Treble_fb / 10, "Analog Audio Out"); };
            _AnalogAudioOutput.VU_Changed += (value) => { CrestronConsole.PrintLine("{2} VU Value: {0}, {1}", (double)value / 10, (double)_AnalogAudioOutput.VU_fb / 10, "Analog Audio Out"); };


            CrestronConsole.AddNewConsoleCommand(MasterVolUp, "TMasterVolUp" + "AAO", "Raises Master Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterVolDown, "TMasterVolDown" + "AAO", "Lowers Master Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterMute, "TMasterMute" + "AAO", "Mutes/Unmutes Master Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterMuteToggle, "TMasterMuteToggle" + "AAO", "Toggles Mute Master Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicLevelUp, "TMicLevelUp" + "AAO", "Lowers Mic Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicLevelDown, "TMicLevelDown" + "AAO", "Lowers Mic Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicMute, "TMicMute" + "AAO", "Mutes/Unmutes Mic Level for" + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicMuteToggle, "TMicMuteToggle" + "AAO", "Toggles Mute Mic Level for" + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceLevelUp, "TSourceLevelUp" + "AAO", "Lowers Source Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceLevelDown, "TSourceLevelDown" + "AAO", "Lowers Source Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceMute, "TSourceMute" + "AAO", "Mutes/Unmutes Source Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceMuteToggle, "TSourceMuteToggle" + "AAO", "Toggles Mute Source Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MonoOutput, "TMonoOutput" + "AAO", "Changes Output to Mono Threshold for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(StereoOutput, "TStereoOutput" + "AAO", "Changes Output to Stereo Attack for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(BassInc, "TBass" + "AAO", "Raises/Lowers Bass Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(BassFlat, "TBassFlat" + "AAO", "Flattens Bass Level for" + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TrebleInc, "TTreble" + "AAO", "Raises/Lowers Bass Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TrebleFlat, "TTrebleFlat" + "AAO", "Flattens Bass LevelFrequency for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Limiter, "TLimiter" + "AAO", "Enables/Disables Limiter for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(LimiterSK, "TLimiterSK" + "AAO", "Enables/Disables Limiter Soft Knee Limiter for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SavePreset, "TSavePreset" + "AAO", "Saves Preset for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(RecallPreset, "TRecallPreset" + "AAO", "Recalls Preset for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(PresetNumber, "TPresetNumber" + "AAO", "Sets Preset Number to be Recalled/Saved for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MasterVolume, "TMasterVolume" + "AAO", "Changes Master Volume Gain for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicLevel, "TMicLevel" + "AAO", "Changes Mice Level Gain for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MicPan, "TMicPan" + "AAO", "Changes Mic Pan for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceLevel, "TSourceLevel" + "AAO", "Changes Source Level Gain for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SourceBalance, "TSourceBalance" + "AAO", "Changes Source Balance Gain for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Delay, "TDelay" + "AAO", "Changes Delay time for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MinVolume, "TMinVolume" + "AAO", "Changes Minimum Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MaxVolume, "TMaxVolume" + "AAO", "Changes Maximum Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(StartupVolume, "TStartupVolume" + "AAO", "Changes Startup Volume for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Bass, "TBass" + "AAO", "Changes Bass Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Treble, "TTreble" + "AAO", "Changes Treble Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(LimiterThresh, "TLimiterThresh" + "AAO", "Changes Limiter Treshold Level for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(LimiterAttack, "TLimiterAttack" + "AAO", "Changes Limiter Attack Time for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(LimiterRelease, "TLimiterRelease" + "AAO", "Changes Limiter Release Time for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(LimiterRatio, "TLimiterRatio" + "AAO", "Changes Limiter Ratio for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ315, "TGEQ315" + "AAO", "Changes Graphic EQ Gain at 31.5Hz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ63, "TGEQ63" + "AAO", "Changes Graphic EQ Gain at 63Hz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ125, "TGEQ125" + "AAO", "Changes Graphic EQ Gain at 125Hz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ250, "TGEQ250" + "AAO", "Changes Graphic EQ Gain at 250Hz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ500, "TGEQ500" + "AAO", "Changes Graphic EQ Gain at 500Hz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ1K, "TGEQ1K" + "AAO", "Changes Graphic EQ Gain at 1KHz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ2K, "TGEQ2K" + "AAO", "Changes Graphic EQ Gain at 2KHz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ4K, "TGEQ4K" + "AAO", "Changes Graphic EQ Gain at 4KHz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ8K, "TGEQ8K" + "AAO", "Changes Graphic EQ Gain at 8KHz " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GEQ16K, "TGEQ16K" + "AAO", "Changes Graphic EQ Gain at 16KHz for " + "Analog Audio Out", ConsoleAccessLevelEnum.AccessOperator);

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
        static int GetFirstParameterInteger(string value, string MessageHelp)
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
        static void MasterVolUp(string State)
        {
            if (State.ToUpper() == "START") _AnalogAudioOutput.Master_Volume_Up(true);
            else if (State.ToUpper() == "STOP") _AnalogAudioOutput.Master_Volume_Up(false);
            else { CrestronConsole.ConsoleCommandResponse("MasterVol" + "AAO" + " [Start|Stop]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Raising Master Volume {0}...\n", State.ToUpper());
        }
        static void MasterVolDown(string State)
        {
            if (State.ToUpper() == "START") _AnalogAudioOutput.Master_Volume_Down(true);
            else if (State.ToUpper() == "STOP") _AnalogAudioOutput.Master_Volume_Down(false);
            else { CrestronConsole.ConsoleCommandResponse("MasterVol" + "AAO" + " [Start|Stop]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Lowering Master Volume {0}...\n", State.ToUpper());
        }
        static void MasterMute(string State)
        {
            if (State.ToUpper() == "ON") _AnalogAudioOutput.Master_Mute_On();
            else if (State.ToUpper() == "OFF") _AnalogAudioOutput.Master_Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("MasterMute" + "AAO" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Master Mute to {0}...\n", State.ToUpper());
        }
        static void MasterMuteToggle(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Master_Mute_Toggle();
                CrestronConsole.ConsoleCommandResponse("CMD:Toggling Master Mute...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("MasterMuteToggle" + "AAO"); return; }
        }
        static void MicLevelUp(string State)
        {
            if (State.ToUpper() == "START") _AnalogAudioOutput.Mic_Level_Up(true);
            else if (State.ToUpper() == "STOP") _AnalogAudioOutput.Mic_Level_Up(false);
            else { CrestronConsole.ConsoleCommandResponse("MicLevel" + "AAO" + " [Start|Stop]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Raising Mic Level {0}...\n", State.ToUpper());
        }
        static void MicLevelDown(string State)
        {
            if (State.ToUpper() == "START") _AnalogAudioOutput.Mic_Level_Down(true);
            else if (State.ToUpper() == "STOP") _AnalogAudioOutput.Mic_Level_Down(false);
            else { CrestronConsole.ConsoleCommandResponse("MicLevel" + "AAO" + " [Start|Stop]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Lowering Mic Level {0}...\n", State.ToUpper());
        }
        static void MicMute(string State)
        {
            if (State.ToUpper() == "ON") _AnalogAudioOutput.Mic_Mute_On();
            else if (State.ToUpper() == "OFF") _AnalogAudioOutput.Mic_Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("MicMute" + "AAO" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Mic Mute to {0}...\n", State.ToUpper());
        }
        static void MicMuteToggle(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Mic_Mute_Toggle();
                CrestronConsole.ConsoleCommandResponse("CMD:Toggling Mic Mute}...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("MicMuteToggle" + "AAO"); return; }
        }
        static void SourceLevelUp(string State)
        {
            if (State.ToUpper() == "START") _AnalogAudioOutput.Source_Level_Up(true);
            else if (State.ToUpper() == "STOP") _AnalogAudioOutput.Source_Level_Up(false);
            else { CrestronConsole.ConsoleCommandResponse("SourceLevel" + "AAO" + " [Start|Stop]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Raising Source Level {0}...\n", State.ToUpper());
        }
        static void SourceLevelDown(string State)
        {
            if (State.ToUpper() == "START") _AnalogAudioOutput.Source_Level_Down(true);
            else if (State.ToUpper() == "STOP") _AnalogAudioOutput.Source_Level_Down(false);
            else { CrestronConsole.ConsoleCommandResponse("SourceLevel" + "AAO" + " [Start|Stop]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Lowering Source Level {0}...\n", State.ToUpper());
        }
        static void SourceMute(string State)
        {
            if (State.ToUpper() == "ON") _AnalogAudioOutput.Source_Mute_On();
            else if (State.ToUpper() == "OFF") _AnalogAudioOutput.Source_Mute_Off();
            else { CrestronConsole.ConsoleCommandResponse("SourceMute" + "AAO" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Source Mute to {0}...\n", State.ToUpper());
        }
        static void SourceMuteToggle(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Source_Mute_Toggle();
                CrestronConsole.ConsoleCommandResponse("CMD:Toggling Source Mute...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("SourceMuteToggle" + "AAO"); return; }
        }
        static void MonoOutput(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Mono_Output();
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Output to Mono...\n", State.ToUpper());
            }
            else
            { CrestronConsole.ConsoleCommandResponse("MonoOutput" + "AAO"); return; }
        }
        static void StereoOutput(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Stereo_Output();
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Output to Stereo...\n", State.ToUpper());
            }
            else
            { CrestronConsole.ConsoleCommandResponse("StereoOutput" + "AAO"); return; }
        }
        static void BassInc(string State)
        {
            if (State.ToUpper() == "UP") _AnalogAudioOutput.Bass_Up();
            else if (State.ToUpper() == "DOWN") _AnalogAudioOutput.Bass_Down();
            else { CrestronConsole.ConsoleCommandResponse("Bass" + "AAO" + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Bass Level {0}...\n", State.ToUpper());
        }
        static void BassFlat(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Bass_Flat();
                CrestronConsole.ConsoleCommandResponse("CMD:Flatteinig Bass Level...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("BassFlat" + "AAO"); return; }
        }
        static void TrebleInc(string State)
        {
            if (State.ToUpper() == "UP") _AnalogAudioOutput.Treble_Up();
            else if (State.ToUpper() == "DOWN") _AnalogAudioOutput.Treble_Down();
            else { CrestronConsole.ConsoleCommandResponse("Treble" + "AAO" + " [Up|Down]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Treble Level {0}...\n", State.ToUpper());
        }
        static void TrebleFlat(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Treble_Flat();
                CrestronConsole.ConsoleCommandResponse("CMD:Flatteinig Treble Level...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("TrebleFlat" + "AAO"); return; }
        }
        static void Limiter(string State)
        {
            if (State.ToUpper() == "ON") _AnalogAudioOutput.Limiter_Enable();
            else if (State.ToUpper() == "OFF") _AnalogAudioOutput.Limiter_Disable();
            else { CrestronConsole.ConsoleCommandResponse("Limiter" + "AAO" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Limiter to {0}...\n", State.ToUpper());
        }
        static void LimiterSK(string State)
        {
            if (State.ToUpper() == "ON") _AnalogAudioOutput.Limiter_Soft_Knee_Enable();
            else if (State.ToUpper() == "OFF") _AnalogAudioOutput.Limiter_Soft_Knee_Disable();
            else { CrestronConsole.ConsoleCommandResponse("LimiterSK" + "AAO" + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Limiter Soft Knee to {0}...\n", State.ToUpper());
        }
        static void SavePreset(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Save_Preset();
                CrestronConsole.ConsoleCommandResponse("CMD:Saving Preset...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("SavePreset" + "AAO"); return; }
        }
        static void RecallPreset(string State)
        {
            if (State == "")
            {
                _AnalogAudioOutput.Recall_Preset();
                CrestronConsole.ConsoleCommandResponse("CMD:Recalling Preset...\n");
            }
            else
            { CrestronConsole.ConsoleCommandResponse("RecallPreset" + "AAO"); return; }
        }
        static void PresetNumber(string Preset)
        {
            string MessageHelp = "PresetNumber" + "AAO" + " value (1 to 5)";
            double preset = GetFirstParameterInteger(Preset, MessageHelp);
            if (preset >= 1 && preset <= 5)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Setting Preset to {0}", preset);
                _AnalogAudioOutput.Preset_Number((ushort)preset);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void MasterVolume(string value)
        {
            string MessageHelp = "MasterVolume" + "AAO" + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Master Volume to {0}", Gain);
                _AnalogAudioOutput.Master_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void MicLevel(string value)
        {
            string MessageHelp = "MicLevel" + "AAO" + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Mic Level to {0}", Gain);
                _AnalogAudioOutput.Mic_Level((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void MicPan(string value)
        {
            string MessageHelp = "MicPan" + "AAO" + " value (-32768 to 32767)";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -32768 && Gain <= 32767)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Mic Pan to {0}", Gain);
                _AnalogAudioOutput.Mic_Pan((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void SourceLevel(string value)
        {
            string MessageHelp = "TestGateHold" + "AAO" + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Source Level to {0}", Gain);
                _AnalogAudioOutput.Source_Level((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void SourceBalance(string value)
        {
            string MessageHelp = "TestCompressorThreshold" + "AAO" + " value (-32768 to 32767)";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= -32768 && Gain <= 32767)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Source Balance to {0}", Gain);
                _AnalogAudioOutput.Source_Balance((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void Delay(string value)
        {
            string MessageHelp = "Delay" + "AAO" + " value (0.0 to 85.0)ms";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= 0 && Gain <= 85)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Delay to {0}", Gain);
                _AnalogAudioOutput.Delay((ushort)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void MinVolume(string value)
        {
            string MessageHelp = "MinVolume" + "AAO" + " value (-80.0 to 40.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 40)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Minimum Volume to {0}", Gain);
                _AnalogAudioOutput.Min_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void MaxVolume(string value)
        {
            string MessageHelp = "MaxVolume" + "AAO" + " value (-30.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -30 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Maximum Volume to {0}", Gain);
                _AnalogAudioOutput.Max_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void StartupVolume(string value)
        {
            string MessageHelp = "StartupVolume" + "AAO" + " value (-80.0 to 10.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Startup Volume to {0}", Gain);
                _AnalogAudioOutput.Startup_Volume((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void Bass(string value)
        {
            string MessageHelp = "Bass" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Bass Level to {0}", Gain);
                _AnalogAudioOutput.Bass((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void Treble(string value)
        {
            string MessageHelp = "Treble" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Bass Level to {0}", Gain);
                _AnalogAudioOutput.Treble((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void LimiterThresh(string value)
        {
            string MessageHelp = "LimiterTresh" + "AAO" + " value (-80.0 to 0.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -80 && Gain <= 0)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Limiter Threshold Volume to {0}", Gain);
                _AnalogAudioOutput.Limiter_Threshold((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void LimiterAttack(string value)
        {
            string MessageHelp = "LimiterAttack" + "AAO" + " value (1 to 250)ms";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 250)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Limiter Attack Time to {0}", Gain);
                _AnalogAudioOutput.Limiter_Attack((ushort)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void LimiterRelease(string value)
        {
            string MessageHelp = "LimiterRelease" + "AAO" + " value (1 to 1000)ms";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 1000)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Limiter Release Time to {0}", Gain);
                _AnalogAudioOutput.Limiter_Release((ushort)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void LimiterRatio(string value)
        {
            string MessageHelp = "LimiterRatio" + "AAO" + " value (1 to 10):1";
            int Gain = GetFirstParameterInteger(value, MessageHelp);
            if (Gain >= 1 && Gain <= 10)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Limiter Ration to {0}", Gain);
                _AnalogAudioOutput.Limiter_Ratio((ushort)Gain);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ315(string value)
        {
            string MessageHelp = "GEQ315" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 31.5Hz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_31_5Hz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ63(string value)
        {
            string MessageHelp = "GEQ63" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 63Hz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_63Hz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ125(string value)
        {
            string MessageHelp = "GEQ125" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 125Hz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_125Hz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ250(string value)
        {
            string MessageHelp = "GEQ250" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 250Hz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_250Hz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ500(string value)
        {
            string MessageHelp = "GEQ500" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 500Hz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_500Hz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ1K(string value)
        {
            string MessageHelp = "GEQ1K" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 1KHz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_1KHz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ2K(string value)
        {
            string MessageHelp = "GEQ2K" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 2KHz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_2KHz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ4K(string value)
        {
            string MessageHelp = "GEQ4K" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 4KHz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_4KHz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ8K(string value)
        {
            string MessageHelp = "GEQ8K" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 8KHz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_8KHz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        static void GEQ16K(string value)
        {
            string MessageHelp = "GEQ16K" + "AAO" + " value (-12.0 to 12.0)db";
            double Gain = GetFirstParameterDouble(value, MessageHelp);
            if (Gain >= -12 && Gain <= 12)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Graphic EQ Gain at 16KHz to {0}", Gain);
                _AnalogAudioOutput.GEQ_Gain_16KHz((short)(Gain * 10));
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }

}