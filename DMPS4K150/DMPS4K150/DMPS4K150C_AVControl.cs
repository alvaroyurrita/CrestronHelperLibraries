using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Cards;
using eDmps34K150CInputs = Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs;
using eDmps34K150COutputs = Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150COutputs;

namespace DMPS4K150
{
    public class DMPS4K150C_AVControl
    {
        #region Public Events and Properties

        public event Action<bool> AutoMode_On_Changed;
        public bool AutoMode_On_fb
        {
            get { return DMOutput1.AutoModeOnFeedback.BoolValue; }
            private set { if (AutoMode_On_Changed != null) AutoMode_On_Changed(AutoMode_On_fb); }
        }

        public event Action<bool> AutoMode_Off_Changed;
        public bool AutoMode_Off_fb
        {
            get { return DMOutput1.AutoModeOffFeedback.BoolValue; }
            private set { if (AutoMode_Off_Changed != null) AutoMode_Off_Changed(AutoMode_Off_fb); }
        }

        public event Action<uint> Video_Source_Changed;
        public uint Video_Source_fb
        {
            get { return (DMOutput1.VideoOutFeedback != null) ? DMOutput1.VideoOutFeedback.Number : 0; }
            private set { if (Video_Source_Changed != null) Video_Source_Changed(Video_Source_fb); }
        }

        public event Action<uint> Audio_Source_Changed;
        public uint Audio_Source_fb
        {
            get { return (DMOutput1.AudioOutFeedback != null) ? DMOutput1.AudioOutFeedback.Number : 0; }
            private set { if (Audio_Source_Changed != null) Audio_Source_Changed(Audio_Source_fb); }
        }

        public event Action<uint> Input_DM1_UsbRoutedTo_Changed;
        public uint Input_DM1_UsbRoutedTo_fb
        {
            get { return (DMInput1.USBRoutedToFeedback != null) ? DMInput1.USBRoutedToFeedback.Number : 0; }
            private set { if (Input_DM1_UsbRoutedTo_Changed != null) Input_DM1_UsbRoutedTo_Changed(Input_DM1_UsbRoutedTo_fb); }
        }

        public event Action<uint> Input_DM2_UsbRoutedTo_Changed;
        public uint Input_DM2_UsbRoutedTo_fb
        {
            get { return (DMInput2.USBRoutedToFeedback != null) ? DMInput2.USBRoutedToFeedback.Number : 0; }
            private set { if (Input_DM2_UsbRoutedTo_Changed != null) Input_DM2_UsbRoutedTo_Changed(Input_DM2_UsbRoutedTo_fb); }
        }

        public event Action<uint> Output_DM_UsbRoutedTo_Changed;
        public uint Output_DM_UsbRoutedTo_fb
        {
            get { return (DMOutput1.USBRoutedToFeedback != null) ? DMOutput1.USBRoutedToFeedback.Number : 0; }
            private set { if (Output_DM_UsbRoutedTo_Changed != null) Output_DM_UsbRoutedTo_Changed(Output_DM_UsbRoutedTo_fb); }
        }
        #endregion

        #region Public Methods
        public void AutoMode_On() { DMOutput1.AutoModeOn(); }
        public void AutoMode_Off() { DMOutput1.AutoModeOff(); }
        public void Video_Source(uint input)
        {
            if (input == 0)
            {
                DMOutput1.VideoOut = null;
            }
            else
            {
                switch (input)
                {
                    case 1:
                        DMOutput1.VideoOut = VGAInput1;
                        break;
                    case 2:
                        DMOutput1.VideoOut = VGAInput2;
                        break;
                    case 3:
                        DMOutput1.VideoOut = VGAInput3;
                        break;
                    case 4:
                        DMOutput1.VideoOut = VGAInput4;
                        break;
                    case 5:
                        DMOutput1.VideoOut = HDMIInput1;
                        break;
                    case 6:
                        DMOutput1.VideoOut = HDMIInput2;
                        break;
                    case 7:
                        DMOutput1.VideoOut = HDMIInput3;
                        break;
                    case 8:
                        DMOutput1.VideoOut = HDMIInput4;
                        break;
                    case 9:
                        DMOutput1.VideoOut = DMInput1;
                        break;
                    case 10:
                        DMOutput1.VideoOut = DMInput2;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
        public void Audio_Source(uint input)
        {
            if (input == 0)
            {
                DMOutput1.AudioOut = null;
            }
            else
            {
                switch (input)
                {
                    case 1:
                        DMOutput1.AudioOut = VGAInput1;
                        break;
                    case 2:
                        DMOutput1.AudioOut = VGAInput2;
                        break;
                    case 3:
                        DMOutput1.AudioOut = VGAInput3;
                        break;
                    case 4:
                        DMOutput1.AudioOut = VGAInput4;
                        break;
                    case 5:
                        DMOutput1.AudioOut = HDMIInput1;
                        break;
                    case 6:
                        DMOutput1.AudioOut = HDMIInput2;
                        break;
                    case 7:
                        DMOutput1.AudioOut = HDMIInput3;
                        break;
                    case 8:
                        DMOutput1.AudioOut = HDMIInput4;
                        break;
                    case 9:
                        DMOutput1.AudioOut = DMInput1;
                        break;
                    case 10:
                        DMOutput1.AudioOut = DMInput2;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
        public void Input_DM1_UsbRoutedTo(uint input)
        {
            if (input == 0)
            {
                DMInput1.USBRoutedTo = null;
            }
            else
            {
                switch (input)
                {
                    case 9:
                        DMInput1.USBRoutedTo = DMInput1;
                        break;
                    case 10:
                        DMInput1.USBRoutedTo = DMInput2;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
        public void Input_DM2_UsbRoutedTo(uint input)
        {
            if (input == 0)
            {
                DMInput2.USBRoutedTo = null;
            }
            else
            {
                switch (input)
                {
                    case 9:
                        DMInput2.USBRoutedTo = DMInput1;
                        break;
                    case 10:
                        DMInput2.USBRoutedTo = DMInput2;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
        public void Output_DM_UsbRoutedTo(uint input)
        {
            if (input == 0)
            {
                DMOutput1.USBRoutedTo = null;
            }
            else
            {
                switch (input)
                {
                    case 9:
                        DMOutput1.USBRoutedTo = DMInput1;
                        break;
                    case 10:
                        DMOutput1.USBRoutedTo = DMInput2;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }


        #endregion

        #region private fields
        private ControlSystem _ControlSystem;
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
        private static DMPS4K150C_AVControl _AVControl;


        #endregion

        //singleton creator
        public static DMPS4K150C_AVControl GetDMPS4K150C_AVControl(ControlSystem ControlSystem)
        {
            return _AVControl ?? (_AVControl = new DMPS4K150C_AVControl(ControlSystem));
        }

        private DMPS4K150C_AVControl(ControlSystem ControlSystem)
        {

            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;

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

        void ControlSystem_DMInputChange(Switch device, DMInputEventArgs args)
        {
            if (args.EventId == DMInputEventIds.UsbRoutedToEventId)
            {
                var InputSlot = args.Number;
                switch (InputSlot)
                {
                    case (int)ControlSystem.eDmps34K150CInputs.Dm1:
                        Input_DM1_UsbRoutedTo_fb = (DMInput1.USBRoutedToFeedback != null) ? DMInput1.USBRoutedToFeedback.Number : 0; 
                        break;
                    case (int)ControlSystem.eDmps34K150CInputs.Dm2:
                        Input_DM2_UsbRoutedTo_fb = (DMInput2.USBRoutedToFeedback != null) ? DMInput2.USBRoutedToFeedback.Number : 0;
                        break;
                    default:
                        break;
                }
            }
        }

        void ControlSystem_DMOutputChange(Switch device, DMOutputEventArgs args)
        {

            switch (args.EventId)
            {
                case DMOutputEventIds.AutoModeOnEventId:
                    AutoMode_On_fb = DMOutput1.AutoModeOnFeedback.BoolValue;
                    break;
                case DMOutputEventIds.AutoModeOffEventId:
                    AutoMode_Off_fb = DMOutput1.AutoModeOffFeedback.BoolValue;
                    break;
                case DMOutputEventIds.VideoOutEventId:
                    Video_Source_fb = (DMOutput1.VideoOutFeedback != null) ? DMOutput1.VideoOutFeedback.Number : 0;
                    break;
                case DMOutputEventIds.AudioOutEventId:
                    Audio_Source_fb = (DMOutput1.AudioOutFeedback != null) ? DMOutput1.AudioOutFeedback.Number : 0;
                    break;
                case DMOutputEventIds.UsbRoutedToEventId:
                    Output_DM_UsbRoutedTo_fb = (DMOutput1.USBRoutedToFeedback != null) ? DMOutput1.USBRoutedToFeedback.Number : 0; 
                    break;
                default:
                    break;
            }
        }





    }
}