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


    public class DMPS4K150C_DM_Input 
    {

        #region Public Events and Properties
        public event Action<bool> Video_Source_Detected_Changed;
        public bool Video_Source_Detected_fb
        {
            get { return DMInput.DmInputPort.VideoSourceDetected.BoolValue; }
            private set { if (Video_Source_Detected_Changed != null) Video_Source_Detected_Changed(Video_Source_Detected_fb); }
        }
        public event Action<bool> Interlaced_Detected_Changed;
        public bool Interlaced_Detected_fb
        {
            get { return DMInput.DmInputPort.VideoAttributes.InterlacedFeedback.BoolValue; }
            private set { if (Interlaced_Detected_Changed != null) Interlaced_Detected_Changed(Interlaced_Detected_fb); }
        }
        public event Action<bool> HDCP_Active_Changed;
        public bool HDCP_Active_fb
        {
            get { return DMInput.DmInputPort.VideoAttributes.HdcpActiveFeedback.BoolValue; }
            private set { if (HDCP_Active_Changed != null) HDCP_Active_Changed(HDCP_Active_fb); }
        }
        public event Action<bool> Sync_Detected_Changed;
        public bool Sync_Detected_fb
        {
            get { return DMInput.DmInputPort.SyncDetectedFeedback.BoolValue; }
            private set { if (Sync_Detected_Changed != null) Sync_Detected_Changed(Sync_Detected_fb); }
        }
        public event Action<bool> HDCP_Support_On_Changed;
        public bool HDCP_Support_On_fb
        {
            get { return DMInput.DmInputPort.HdcpSupportOnFeedback.BoolValue; }
            private set { if (HDCP_Support_On_Changed != null) HDCP_Support_On_Changed(HDCP_Support_On_fb); }
        }
        public event Action<bool> HDCP_Support_Off_Changed;
        public bool HDCP_Support_Off_fb
        {
            get { return DMInput.DmInputPort.HdcpSupportOffFeedback.BoolValue; }
            private set { if (HDCP_Support_Off_Changed != null) HDCP_Support_Off_Changed(HDCP_Support_Off_fb); }
        }
        public event Action<bool> Audio_Source_Detected_Changed;
        public bool Audio_Source_Detected_fb
        {
            get { return DMInput.DmInputPort.AudioSourceDetectedFeedback.BoolValue; }
            private set { if (Audio_Source_Detected_Changed != null) Audio_Source_Detected_Changed(Audio_Source_Detected_fb); }
        }
        public event Action<bool> ENDPOINT_ONLINE_Changed;
        public bool ENDPOINT_ONLINE_fb
        {
            get { return DMInput.EndpointOnlineFeedback; }
            private set { if (ENDPOINT_ONLINE_Changed != null) ENDPOINT_ONLINE_Changed(ENDPOINT_ONLINE_fb); }
        }


        public event Action<ushort> Horizontal_Resolution_Changed;
        public ushort Horizontal_Resolution_fb
        {
            get { return DMInput.DmInputPort.VideoAttributes.HorizontalResolutionFeedback.UShortValue; }
            private set { if (Horizontal_Resolution_Changed != null) Horizontal_Resolution_Changed(Horizontal_Resolution_fb); }
        }
        public event Action<ushort> Vertical_Resolution_Changed;
        public ushort Vertical_Resolution_fb
        {
            get { return DMInput.DmInputPort.VideoAttributes.VerticalResolutionFeedback.UShortValue; }
            private set { if (Vertical_Resolution_Changed != null) Vertical_Resolution_Changed(Vertical_Resolution_fb); }
        }
        public event Action<ushort> Refresh_Rate_Changed;
        public ushort Refresh_Rate_fb
        {
            get { return DMInput.DmInputPort.VideoAttributes.FramesPerSecondFeedback.UShortValue; }
            private set { if (Refresh_Rate_Changed != null) Refresh_Rate_Changed(Refresh_Rate_fb); }
        }
        public event Action<eAspectRatio> Aspect_Ratio_Changed;
        public eAspectRatio Aspect_Ratio_fb
        {
            get { return (eAspectRatio)DMInput.DmInputPort.VideoAttributes.AspectRatioFeedback.UShortValue; }
            private set { if (Aspect_Ratio_Changed != null) Aspect_Ratio_Changed(Aspect_Ratio_fb); }
        }
        public event Action<eDmStream3DStatus> Status_3D_Changed;
        public eDmStream3DStatus Status_3D_fb
        {
            get { return DMInput.DmInputPort.VideoAttributes.Stream3DStatusFeedback; }
            private set { if (Status_3D_Changed != null) Status_3D_Changed(Status_3D_fb); }
        }
        public event Action<eDmAudioFormat> Audio_Format_Changed;
        public eDmAudioFormat Audio_Format_fb
        {
             get { return DMInput.DmInputPort.Audio.AudioFormatFeedback; }
            private set { if (Audio_Format_Changed != null) Audio_Format_Changed(Audio_Format_fb); }
        }
        public event Action<ushort> Audio_Channels_Changed;
        public ushort Audio_Channels_fb
        {
            get { return DMInput.DmInputPort.Audio.AudioChannelsFeedback.UShortValue; }
            private set { if (Audio_Channels_Changed != null) Audio_Channels_Changed(Audio_Channels_fb); }
        }
        public event Action<short> Audio_Gain_Changed;
        public short Audio_Gain_fb
        {
            get { return DMInput.DmInputPort.Audio.AudioGainFeedback.ShortValue; }
            private set { if (Audio_Gain_Changed != null) Audio_Gain_Changed(Audio_Gain_fb); }
        }

        public string DMInputPort { get; private set; }
        #endregion

        #region Public Methods
        public void HDCP_Support_On() { DMInput.DmInputPort.HdcpSupportOn(); }

        public void HDCP_Support_Off() { DMInput.DmInputPort.HdcpSupportOff(); }

        public void Audio_Gain(short Gain)
        {
            if (Gain >= -100 && Gain <= 100){DMInput.DmInputPort.Audio.AudioGain.ShortValue = Gain;}
        }

        #endregion

        #region Private Fields
        private Card.Dmps3DmInput DMInput;

        //singletons
        private static DMPS4K150C_DM_Input DMInput1;
        private static DMPS4K150C_DM_Input DMInput2;

        private ControlSystem _ControlSystem;
        private DMPS4K150C_SwitcherInput _SwitcherInput;
        #endregion

        //factory to prevent duplicate instansiations.
        public static DMPS4K150C_DM_Input GetDMInput(ControlSystem ControlSystem, ControlSystem.eDmps34K150CInputs Input)
        {

            if (TestInputRange(Input))
            {
                switch (Input)
                {
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Dm1:
                        return DMInput1 ?? (DMInput1 = new DMPS4K150C_DM_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Dm2:
                        return DMInput2 ?? (DMInput2 = new DMPS4K150C_DM_Input(ControlSystem, Input));
                    default:
                        return null;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        private DMPS4K150C_DM_Input(ControlSystem ControlSystem, ControlSystem.eDmps34K150CInputs Input)
        {
            this.DMInputPort = Input.ToString(); ;


            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            _SwitcherInput = DMPS4K150C_SwitcherInput.GetDMPS4K150C_SwitcherInput(_ControlSystem);
            DMInput = _ControlSystem.SwitcherInputs[(uint)Input] as Card.Dmps3DmInput;

            switch (Input)
            {
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Dm1:
                    _SwitcherInput.DM1InputChanged +=new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_DM1InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Dm2:
                    _SwitcherInput.DM2InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_DM2InputChanged);
                    break;
                default:
                    break;
            }

            DMInput.DmInputPort.VideoAttributes.AttributeChange += new Crestron.SimplSharpPro.DeviceSupport.GenericEventHandler(VideoAttributes_AttributeChange);
        }

        void VideoAttributes_AttributeChange(object sender, GenericEventArgs args)
        {
            var VideoAttributesBasic = sender as VideoAttributesBasic;
            switch (args.EventId)
            {
                case VideoAttributeEventIds.InterlacedFeedbackEventId:
                    Interlaced_Detected_fb = VideoAttributesBasic.InterlacedFeedback.BoolValue;
                    break;
                case VideoAttributeEventIds.HdcpActiveFeedbackEventId:
                    HDCP_Active_fb = VideoAttributesBasic.HdcpActiveFeedback.BoolValue;
                    break;
                case VideoAttributeEventIds.HorizontalResolutionFeedbackEventId:
                    Horizontal_Resolution_fb = VideoAttributesBasic.HorizontalResolutionFeedback.UShortValue;
                    break;
                case VideoAttributeEventIds.VerticalResolutionFeedbackEventId:
                    Vertical_Resolution_fb = VideoAttributesBasic.VerticalResolutionFeedback.UShortValue;
                    break;
                case VideoAttributeEventIds.FramesPerSecondFeedbackEventId:
                    Refresh_Rate_fb = VideoAttributesBasic.FramesPerSecondFeedback.UShortValue;
                    break;
                case VideoAttributeEventIds.AspectRatioFeedbackEventId:
                    Aspect_Ratio_fb = (eAspectRatio)VideoAttributesBasic.AspectRatioFeedback.UShortValue;
                    break;
                case VideoAttributeEventIds.Stream3DStatusFeedbackEventId:
                    Status_3D_fb = DMInput.DmInputPort.VideoAttributes.Stream3DStatusFeedback;
                    break;
                default:
                    break;
            }
        }

        void _SwitcherInput_DM2InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_DM1InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        private void ProcessEvent(DMInputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMInputEventIds.VideoDetectedEventId:
                    Video_Source_Detected_fb = DMInput.DmInputPort.VideoSourceDetected.BoolValue;
                    break;
                case DMInputEventIds.SourceSyncEventId:
                    Sync_Detected_fb = DMInput.DmInputPort.SyncDetectedFeedback.BoolValue;
                    break;
                case DMInputEventIds.HdcpSupportOnEventId:
                    HDCP_Support_On_fb = DMInput.DmInputPort.HdcpSupportOnFeedback.BoolValue;
                    break;
                case DMInputEventIds.HdcpSupportOffEventId:
                    HDCP_Support_Off_fb = DMInput.DmInputPort.HdcpSupportOffFeedback.BoolValue;
                    break;
                case DMInputEventIds.AudioSourceDetectedEventId:
                    Audio_Source_Detected_fb = DMInput.DmInputPort.AudioSourceDetectedFeedback.BoolValue;
                    break;
                case DMInputEventIds.AudioFormatEventId:
                    Audio_Format_fb = DMInput.DmInputPort.Audio.AudioFormatFeedback;
                    break;
                case DMInputEventIds.AudioChannelsEventId:
                    Audio_Channels_fb = DMInput.DmInputPort.Audio.AudioChannelsFeedback.UShortValue;
                    break;
                case DMInputEventIds.AudioGainFeedbackEventId:
                    Audio_Gain_fb = DMInput.DmInputPort.Audio.AudioGainFeedback.ShortValue;
                    break;
                case DMInputEventIds.EndpointOnlineEventId:
                    ENDPOINT_ONLINE_fb = DMInput.EndpointOnlineFeedback;
                    break;
                default:
                    break;
            }

        }

        private static bool TestInputRange(ControlSystem.eDmps34K150CInputs Input)
        {
            if (Input >= ControlSystem.eDmps34K150CInputs.Dm1 && Input <= ControlSystem.eDmps34K150CInputs.Dm2) return true;
            else return false;
        }

    }
}