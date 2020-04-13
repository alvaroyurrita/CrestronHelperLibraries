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
    public class DMPS4K150C_DeviceControl
    {
        #region Public Events and Properties
        public event Action<bool> Front_Panel_Lock_Changed;
        public bool Front_Panel_Lock_fb
        {
            get { return _ControlSystem.SystemControl.FrontPanelLockOnFeedback.BoolValue; }
            private set { if (Front_Panel_Lock_Changed != null) Front_Panel_Lock_Changed(Front_Panel_Lock_fb); }
        }

        public event Action<bool> Front_Panel_Unlock_Changed;
        public bool Front_Panel_Unlock_fb
        {
            get { return _ControlSystem.SystemControl.FrontPanelLockOffFeedback.BoolValue; }
            private set { if (Front_Panel_Unlock_Changed != null) Front_Panel_Unlock_Changed(Front_Panel_Unlock_fb); }
        }

        public event Action<string> Input_1_Name_Changed;
        public string Input_1_Name_fb
        {
            get { return VGAInput1.NameFeedback.StringValue; }
            private set { if (Input_1_Name_Changed != null) Input_1_Name_Changed(Input_1_Name_fb); }
        }

        public event Action<string> Input_2_Name_Changed;
        public string Input_2_Name_fb
        {
            get { return VGAInput2.NameFeedback.StringValue; }
            private set { if (Input_2_Name_Changed != null) Input_2_Name_Changed(Input_2_Name_fb); }
        }

        public event Action<string> Input_3_Name_Changed;
        public string Input_3_Name_fb
        {
            get { return VGAInput3.NameFeedback.StringValue; }
            private set { if (Input_3_Name_Changed != null) Input_3_Name_Changed(Input_3_Name_fb); }
        }

        public event Action<string> Input_4_Name_Changed;
        public string Input_4_Name_fb
        {
            get { return VGAInput4.NameFeedback.StringValue; }
            private set { if (Input_4_Name_Changed != null) Input_4_Name_Changed(Input_4_Name_fb); }
        }

        public event Action<string> Input_5_Name_Changed;
        public string Input_5_Name_fb
        {
            get { return HDMIInput1.NameFeedback.StringValue; }
            private set { if (Input_5_Name_Changed != null) Input_5_Name_Changed(Input_5_Name_fb); }
        }

        public event Action<string> Input_6_Name_Changed;
        public string Input_6_Name_fb
        {
            get { return HDMIInput2.NameFeedback.StringValue; }
            private set { if (Input_6_Name_Changed != null) Input_6_Name_Changed(Input_6_Name_fb); }
        }

        public event Action<string> Input_7_Name_Changed;
        public string Input_7_Name_fb
        {
            get { return HDMIInput3.NameFeedback.StringValue; }
            private set { if (Input_7_Name_Changed != null) Input_7_Name_Changed(Input_7_Name_fb); }
        }

        public event Action<string> Input_8_Name_Changed;
        public string Input_8_Name_fb
        {
            get { return HDMIInput4.NameFeedback.StringValue; }
            private set { if (Input_8_Name_Changed != null) Input_8_Name_Changed(Input_8_Name_fb); }
        }

        public event Action<string> Input_9_Name_Changed;
        public string Input_9_Name_fb
        {
            get { return DMInput1.NameFeedback.StringValue; }
            private set { if (Input_9_Name_Changed != null) Input_9_Name_Changed(Input_9_Name_fb); }
        }

        public event Action<string> Input_10_Name_Changed;
        public string Input_10_Name_fb
        {
            get { return DMInput2.NameFeedback.StringValue; }
            private set { if (Input_10_Name_Changed != null) Input_10_Name_Changed(Input_10_Name_fb); }
        }

        public event Action<string> Output_Name_Changed;
        public string Output_Name_fb
        {
            get { return DMOutput1.NameFeedback.StringValue; }
            private set { if (Output_Name_Changed != null) Output_Name_Changed(Output_Name_fb); }
        }
        #endregion

        #region Public Methods
        public void Front_Panel_Lock() { _ControlSystem.SystemControl.FrontPanelLockOn(); }
        public void Front_Panel_Unlock() { _ControlSystem.SystemControl.FrontPanelLockOff(); }
        public void Input_1_Name(string Name) { VGAInput1.Name.StringValue = SanitizeNameString(Name); }
        public void Input_2_Name(string Name) { VGAInput2.Name.StringValue = SanitizeNameString(Name); }
        public void Input_3_Name(string Name) { VGAInput3.Name.StringValue = SanitizeNameString(Name); }
        public void Input_4_Name(string Name) { VGAInput4.Name.StringValue = SanitizeNameString(Name); }
        public void Input_5_Name(string Name) { HDMIInput1.Name.StringValue = SanitizeNameString(Name); }
        public void Input_6_Name(string Name) { HDMIInput2.Name.StringValue = SanitizeNameString(Name); }
        public void Input_7_Name(string Name) { HDMIInput3.Name.StringValue = SanitizeNameString(Name); }
        public void Input_8_Name(string Name) { HDMIInput4.Name.StringValue = SanitizeNameString(Name); }
        public void Input_9_Name(string Name) { DMInput1.Name.StringValue = SanitizeNameString(Name); }
        public void Input_10_Name(string Name) { DMInput2.Name.StringValue = SanitizeNameString(Name); }
        public void Output_Name(string Name) { DMOutput1.Name.StringValue = SanitizeNameString(Name); }
        #endregion

        #region Private Fields
        private Card.Dmps3VgaInput VGAInput1;
        private Card.Dmps3VgaInput VGAInput2;
        private Card.Dmps3VgaInput VGAInput3;
        private Card.Dmps3VgaInput VGAInput4;
        private Card.Dmps3HdmiInputWithoutAnalogAudio HDMIInput1;
        private Card.Dmps3HdmiInputWithoutAnalogAudio HDMIInput2;
        private Card.Dmps3HdmiInputWithoutAnalogAudio HDMIInput3;
        private Card.Dmps3HdmiInputWithoutAnalogAudio HDMIInput4;
        private Card.Dmps3DmInput DMInput1;
        private Card.Dmps3DmInput DMInput2;
        private Card.Dmps3HdmiAudioOutput DMOutput1;

        //singleton
        private static DMPS4K150C_DeviceControl _DeviceControl;

        private ControlSystem _ControlSystem;
        private DMPS4K150C_SwitcherInput _SwitcherInput;

        #endregion

        //singleton creator
        public static DMPS4K150C_DeviceControl GetDMPS4K150C_DeviceControl(ControlSystem ControlSystem)
        {
            return _DeviceControl ?? (_DeviceControl = new DMPS4K150C_DeviceControl(ControlSystem));
        }

        private DMPS4K150C_DeviceControl(ControlSystem ControlSystem)
        {

            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            _SwitcherInput = DMPS4K150C_SwitcherInput.GetDMPS4K150C_SwitcherInput(ControlSystem);

            _ControlSystem.DMSystemChange += new Crestron.SimplSharpPro.DM.DMSystemEventHandler(ControlSystem_DMSystemChange);
            _ControlSystem.DMInputChange += new DMInputEventHandler(ControlSystem_DMInputChange);
            _ControlSystem.DMOutputChange += new DMOutputEventHandler(ControlSystem_DMOutputChange);

            VGAInput1 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Vga1] as Card.Dmps3VgaInput;
            VGAInput2 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Vga2] as Card.Dmps3VgaInput;
            VGAInput3 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Vga3] as Card.Dmps3VgaInput;
            VGAInput4 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Vga4] as Card.Dmps3VgaInput;
            HDMIInput1 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Hdmi1] as Card.Dmps3HdmiInputWithoutAnalogAudio;
            HDMIInput2 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Hdmi2] as Card.Dmps3HdmiInputWithoutAnalogAudio; ;
            HDMIInput3 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Hdmi3] as Card.Dmps3HdmiInputWithoutAnalogAudio; ;
            HDMIInput4 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Hdmi4] as Card.Dmps3HdmiInputWithoutAnalogAudio; ;
            DMInput1 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Dm1] as Card.Dmps3DmInput;
            DMInput2 = _ControlSystem.SwitcherInputs[(uint)eDmps34K150CInputs.Dm2] as Card.Dmps3DmInput;
            DMOutput1 = _ControlSystem.SwitcherOutputs[(uint)eDmps34K150COutputs.DmHdmiAnalogOutput] as Card.Dmps3HdmiAudioOutput;



        }

        void ControlSystem_DMOutputChange(Switch device, DMOutputEventArgs args)
        {
            if (args.EventId == DMOutputEventIds.OutputNameEventId)
            {
                var OutputSlot = args.Number;
                switch (OutputSlot)
                {
                    case (int)ControlSystem.eDmps34K150COutputs.DmHdmiAnalogOutput:
                        Output_Name_fb = DMOutput1.NameFeedback.StringValue;
                        break;
                    default:
                        break;
                }
            }
        }

        void ControlSystem_DMInputChange(Switch device, DMInputEventArgs args)
        {
            if (args.EventId == DMInputEventIds.InputNameEventId)
            {
                var InputSlot = args.Number;
                switch (InputSlot)
                {
                case (int)ControlSystem.eDmps34K150CInputs.Vga1:
                    Input_1_Name_fb = VGAInput1.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Vga2:
                    Input_2_Name_fb = VGAInput2.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Vga3:
                    Input_3_Name_fb = VGAInput3.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Vga4:
                    Input_4_Name_fb = VGAInput4.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi1:
                    Input_5_Name_fb = HDMIInput1.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi2:
                    Input_6_Name_fb = HDMIInput2.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi3:
                    Input_7_Name_fb = HDMIInput3.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi4:
                    Input_8_Name_fb = HDMIInput4.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Dm1:
                    Input_9_Name_fb = DMInput1.NameFeedback.StringValue;
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Dm2:
                    Input_10_Name_fb = DMInput2.NameFeedback.StringValue;
                    break;

                default:
                    break;
                }
            }
        }

        void ControlSystem_DMSystemChange(Crestron.SimplSharpPro.DM.Switch device, Crestron.SimplSharpPro.DM.DMSystemEventArgs args)
        {
            switch (args.EventId)
            {   
                case DMSystemEventIds.FrontPanelLockOnEventId:
                    Front_Panel_Lock_fb = _ControlSystem.SystemControl.FrontPanelLockOnFeedback.BoolValue;
                    break;
                case DMSystemEventIds.FrontPanelLockOffEventId:
                    Front_Panel_Unlock_fb = _ControlSystem.SystemControl.FrontPanelLockOffFeedback.BoolValue;
                    break;
                default:
                    break;
            }
        }

        private string SanitizeNameString(string Name)
        {
            try
            {
                string result;
                result = Regex.Replace(Name, @"[^\w\-\+\[\]\ \#]", "", RegexOptions.None);
                if (result.Length > 32) result = result.Remove(32, result.Length - 32);
                return result;
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }
    }

    
}