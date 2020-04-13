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


    public class DMPS4K150C_VGA_Input 
    {

        #region Public Events and Properties
        public event Action<bool> Video_Source_Detected_Changed;
        public bool Video_Source_Detected_fb
        {
            get { return VGAInput.VgaInputPort.VideoDetectedFeedback.BoolValue; }
            private set { if (Video_Source_Detected_Changed != null) Video_Source_Detected_Changed(Video_Source_Detected_fb); }
        }
        public event Action<bool> Auto_Calibrate_Changed;
        public bool Auto_Calibrate_fb
        {
            get { return VGAInput.VgaAutoCalibrateFeedback.BoolValue; }
            private set { if (Auto_Calibrate_Changed != null) Auto_Calibrate_Changed(Auto_Calibrate_fb); }
        }
        public event Action<bool> Sync_Detected_Changed;
        public bool Sync_Detected_fb
        {
            get { return VGAInput.VgaInputPort.SyncDetectedFeedback.BoolValue; }
            private set { if (Sync_Detected_Changed != null) Sync_Detected_Changed(Sync_Detected_fb); }
        }
 

        public event Action<ushort> Horizontal_Resolution_Changed;
        public ushort Horizontal_Resolution_fb
        {
            get { return VGAInput.VgaInputPort.VideoAttributes.HorizontalResolutionFeedback.UShortValue; }
            private set { if (Horizontal_Resolution_Changed != null) Horizontal_Resolution_Changed(Horizontal_Resolution_fb); }
        }
        public event Action<ushort> Vertical_Resolution_Changed;
        public ushort Vertical_Resolution_fb
        {
            get { return VGAInput.VgaInputPort.VideoAttributes.VerticalResolutionFeedback.UShortValue; }
            private set { if (Vertical_Resolution_Changed != null) Vertical_Resolution_Changed(Vertical_Resolution_fb); }
        }
        public event Action<ushort> Refresh_Rate_Changed;
        public ushort Refresh_Rate_fb
        {
            get { return VGAInput.VgaInputPort.VideoAttributes.FramesPerSecondFeedback.UShortValue; }
            private set { if (Refresh_Rate_Changed != null) Refresh_Rate_Changed(Refresh_Rate_fb); }
        }
        public event Action<eAspectRatio> Aspect_Ratio_Changed;
        public eAspectRatio Aspect_Ratio_fb
        {
            get { return (eAspectRatio)VGAInput.VgaInputPort.VideoAttributes.AspectRatioFeedback.UShortValue; }
            private set { if (Aspect_Ratio_Changed != null) Aspect_Ratio_Changed(Aspect_Ratio_fb); }
        }
        public event Action<short> Brightness_Changed;
        public short Brightness_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.BrightnessFeedback.ShortValue; }
            private set { if (Brightness_Changed != null) Brightness_Changed(Brightness_fb); }
        }
        public event Action<short> Contrast_Changed;
        public short Contrast_fb
        {
             get { return VGAInput.VgaInputPort.VideoControls.ContrastFeedback.ShortValue; }
            private set { if (Contrast_Changed != null) Contrast_Changed(Contrast_fb); }
        }
        public event Action<short> Saturation_Changed;
        public short Saturation_fb
        {
             get { return VGAInput.VgaInputPort.VideoControls.Saturation.ShortValue; }
            private set { if (Saturation_Changed != null) Saturation_Changed(Saturation_fb); }
        }
        public event Action<short> Hue_Changed;
        public short Hue_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.HueFeedback.ShortValue; }
            private set { if (Hue_Changed != null) Hue_Changed(Hue_fb); }
        }
        public event Action<short> Red_Changed;
        public short Red_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.RedFeedback.ShortValue; }
            private set { if (Red_Changed != null) Red_Changed(Red_fb); }
        }
        public event Action<short> Green_Changed;
        public short Green_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.GreenFeedback.ShortValue; }
            private set { if (Green_Changed != null) Green_Changed(Green_fb); }
        }
        public event Action<short> Blue_Changed;
        public short Blue_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.BlueFeedback.ShortValue; }
            private set { if (Blue_Changed != null) Blue_Changed(Blue_fb); }
        }
        public event Action<short> X_Position_Changed;
        public short X_Position_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.XPositionFeedback.ShortValue; }
            private set { if (X_Position_Changed != null) X_Position_Changed(X_Position_fb); }
        }
        public event Action<short> Y_Position_Changed;
        public short Y_Position_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.YPositionFeedback.ShortValue; }
            private set { if (Y_Position_Changed != null) Y_Position_Changed(Y_Position_fb); }
        }

        public event Action<eDmVgaSourceControlType> Type_Control_Changed;
        public eDmVgaSourceControlType Type_Control_fb
        {
            get { return VGAInput.VgaInputPort.VideoControls.TypeControlFeedback; }
            private set { if (Type_Control_Changed != null) Type_Control_Changed(Type_Control_fb); }
        }
        public event Action<short> Analog_Audio_Gain_Changed;
        public short Analog_Audio_Gain_fb
        {
            get { return VGAInput.AudioPort.AudioGainFeedback.ShortValue; }
            private set { if (Analog_Audio_Gain_Changed != null) Analog_Audio_Gain_Changed(Analog_Audio_Gain_fb); }
        }



        public string VgaInputPort { get; private set; }
        #endregion

        #region Public Methods
        public void Auto_Calibrate() { VGAInput.VgaAutoCalibrate(); }


        public void Brightness(short Gain)
        {
            if (Gain >= 0 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Brightness.ShortValue = Gain; ;
            }
        }

        public void Contrast(short Gain)
        {
            if (Gain >= -50 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Contrast.ShortValue = Gain; ;
            }
        }

        public void Saturation(short Gain)
        {
            if (Gain >= -50 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Saturation.ShortValue = Gain; ;
            }
        }


        public void Hue(short Gain)
        {
            if (Gain >= -50 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Hue.ShortValue = Gain; ;
            }
        }

        public void Red(short Gain)
        {
            if (Gain >= -50 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Red.ShortValue = Gain; ;
            }
        }

        public void Green(short Gain)
        {
            if (Gain >= -50 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Green.ShortValue = Gain; ;
            }
        }

        public void Blue(short Gain)
        {
            if (Gain >= -50 && Gain <= 50)
            {
                VGAInput.VgaInputPort.VideoControls.Blue.ShortValue = Gain; ;
            }
        }

        public void Type_Control(eDmVgaSourceControlType Type){VGAInput.VgaInputPort.VideoControls.TypeControl = Type; }

        public void Analog_Audio_Gain(short Gain)
        {
            if (Gain >= -100 && Gain <= 100)
            {
                VGAInput.AudioPort.AudioGain.ShortValue = Gain; ;
            }
        }

        public void XPosition(short Gain)
        {
            if (Gain >= -100 && Gain <= 100)
            {
                VGAInput.VgaInputPort.VideoControls.XPosition.ShortValue = Gain; 
            }
        }

        public void YPosition(short Gain)
        {
            if (Gain >= -10 && Gain <= 10)
            {
                VGAInput.VgaInputPort.VideoControls.YPosition.ShortValue = Gain; ;
            }
        }
        #endregion

        #region Private Fields
        private Card.Dmps3VgaInput VGAInput;

        //singletons
        private static DMPS4K150C_VGA_Input VGAInput1;
        private static DMPS4K150C_VGA_Input VGAInput2;
        private static DMPS4K150C_VGA_Input VGAInput3;
        private static DMPS4K150C_VGA_Input VGAInput4;

        private ControlSystem _ControlSystem;
        private DMPS4K150C_SwitcherInput _SwitcherInput;
        #endregion

        //factory to prevent duplicate instansiations.
        public static DMPS4K150C_VGA_Input GetVGAInput(ControlSystem ControlSystem, ControlSystem.eDmps34K150CInputs Input)
        {

            if (TestInputRange(Input))
            {
                switch (Input)
                {
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga1:
                        return VGAInput1 ?? (VGAInput1 = new DMPS4K150C_VGA_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga2:
                        return VGAInput2 ?? (VGAInput2 = new DMPS4K150C_VGA_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga3:
                        return VGAInput3 ?? (VGAInput3 = new DMPS4K150C_VGA_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga4:
                        return VGAInput4 ?? (VGAInput4 = new DMPS4K150C_VGA_Input(ControlSystem, Input));
                    default:
                        return null;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        private DMPS4K150C_VGA_Input(ControlSystem ControlSystem, ControlSystem.eDmps34K150CInputs Input)
        {
            this.VgaInputPort = Input.ToString(); ;


            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            _SwitcherInput = DMPS4K150C_SwitcherInput.GetDMPS4K150C_SwitcherInput(_ControlSystem);
            VGAInput = _ControlSystem.SwitcherInputs[(uint)Input] as Card.Dmps3VgaInput;

            switch (Input)
            {
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga1:
                    _SwitcherInput.VGA1InputChanged +=new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_VGA1InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga2:
                    _SwitcherInput.VGA2InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_VGA2InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga3:
                    _SwitcherInput.VGA3InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_VGA3InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Vga4:
                    _SwitcherInput.VGA4InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_VGA4InputChanged);
                    break;

                default:
                    break;
            }

            VGAInput.VgaInputPort.VideoAttributes.AttributeChange += new GenericEventHandler(VideoAttributes_AttributeChange);
            VGAInput.VgaInputPort.VideoControls.ControlChange += new GenericEventHandler(VideoControls_ControlChange);
        }

        void VideoControls_ControlChange(object sender, GenericEventArgs args)
        {
            switch (args.EventId)
            {
                case VideoControlsEventIds.BrightnessFeedbackEventId:
                    Brightness_fb = VGAInput.VgaInputPort.VideoControls.BrightnessFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.ContrastFeedbackEventId:
                    Contrast_fb = VGAInput.VgaInputPort.VideoControls.ContrastFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.SaturationFeedbackEventId:
                    Saturation_fb = VGAInput.VgaInputPort.VideoControls.Saturation.ShortValue;
                    break;
                case VideoControlsEventIds.HueFeedbackEventId:
                    Hue_fb = VGAInput.VgaInputPort.VideoControls.HueFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.RedFeedbackEventId:
                    Red_fb = VGAInput.VgaInputPort.VideoControls.RedFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.GreenFeedbackEventId:
                    Green_fb = VGAInput.VgaInputPort.VideoControls.GreenFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.BlueFeedbackEventId:
                    Blue_fb = VGAInput.VgaInputPort.VideoControls.BlueFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.XPositionFeedbackEventId:
                    X_Position_fb = VGAInput.VgaInputPort.VideoControls.XPositionFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.YPositionFeedbackEventId:
                    Y_Position_fb = VGAInput.VgaInputPort.VideoControls.YPositionFeedback.ShortValue;
                    break;
                case VideoControlsEventIds.VideoTypeControlEventId:
                    Type_Control_fb = VGAInput.VgaInputPort.VideoControls.TypeControlFeedback;
                    break;
                default:
                    break;
            }

        }

        void VideoAttributes_AttributeChange(object sender, GenericEventArgs args)
        {
            var VideoAttributesBasic = sender as VideoAttributesBasic;
            switch (args.EventId)
            {
                case VideoAttributeEventIds.HorizontalResolutionFeedbackEventId:
                    Horizontal_Resolution_fb = VideoAttributesBasic.HorizontalResolutionFeedback.UShortValue;
                    break;
                case VideoAttributeEventIds.VerticalResolutionFeedbackEventId:
                    Vertical_Resolution_fb = VideoAttributesBasic.VerticalResolutionFeedback.UShortValue;
                    break;
                case VideoAttributeEventIds.FramesPerSecondFeedbackEventId:
                    Refresh_Rate_fb = VideoAttributesBasic.FramesPerSecondFeedback.UShortValue;
                    break;
               default:
                    break;
            }
        }

        void _SwitcherInput_VGA4InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_VGA3InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_VGA2InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_VGA1InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        private void ProcessEvent(DMInputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMInputEventIds.VideoDetectedEventId:
                    Video_Source_Detected_fb = VGAInput.VgaInputPort.VideoDetectedFeedback.BoolValue;
                    break;
                case DMInputEventIds.SourceSyncEventId:
                    Sync_Detected_fb = VGAInput.VgaInputPort.SyncDetectedFeedback.BoolValue;
                    break;
                case DMInputEventIds.AudioGainFeedbackEventId:
                    Analog_Audio_Gain_fb = VGAInput.AudioPort.AudioGainFeedback.ShortValue;
                    break;
                case DMInputEventIds.VgaAutoCalibrateDetectedEventId:
                    Analog_Audio_Gain_fb = VGAInput.AudioPort.AudioGainFeedback.ShortValue;
                    break;
                case DMInputEventIds.AspectRatioFeedbackEventId:
                    Auto_Calibrate_fb = VGAInput.VgaAutoCalibrateFeedback.BoolValue;
                    break;
                default:
                    break;
            }

        }

        private static bool TestInputRange(ControlSystem.eDmps34K150CInputs Input)
        {
            if (Input >= ControlSystem.eDmps34K150CInputs.Vga1 && Input <= ControlSystem.eDmps34K150CInputs.Vga4) return true;
            else return false;
        }
    }
}