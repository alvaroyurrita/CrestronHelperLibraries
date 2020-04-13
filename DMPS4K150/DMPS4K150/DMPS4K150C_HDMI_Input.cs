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


    public class DMPS4K150C_HDMI_Input 
    {

        #region Public Events and Properties
        public event Action<bool> Video_Source_Detected_Changed;
        public bool Video_Source_Detected_fb
        {
            get { return HDMIInput.HdmiInputPort.HdmiVideoSourceDetectedFeedBack.BoolValue; }
            private set { if (Video_Source_Detected_Changed != null) Video_Source_Detected_Changed(Video_Source_Detected_fb); }
        }
        public event Action<bool> Interlaced_Detected_Changed;
        public bool Interlaced_Detected_fb
        {
            get { return HDMIInput.HdmiInputPort.VideoAttributes.InterlacedFeedback.BoolValue; }
            private set { if (Interlaced_Detected_Changed != null) Interlaced_Detected_Changed(Interlaced_Detected_fb); }
        }
        public event Action<bool> HDCP_Active_Changed;
        public bool HDCP_Active_fb
        {
            get { return HDMIInput.HdmiInputPort.VideoAttributes.HdcpActiveFeedback.BoolValue; }
            private set { if (HDCP_Active_Changed != null) HDCP_Active_Changed(HDCP_Active_fb); }
        }
        public event Action<bool> Sync_Detected_Changed;
        public bool Sync_Detected_fb
        {
            get { return HDMIInput.HdmiInputPort.SyncDetectedFeedback.BoolValue; }
            private set { if (Sync_Detected_Changed != null) Sync_Detected_Changed(Sync_Detected_fb); }
        }
        public event Action<bool> HDCP_Support_On_Changed;
        public bool HDCP_Support_On_fb
        {
            get { return HDMIInput.HdmiInputPort.HdcpSupportOnFeedback.BoolValue; }
            private set { if (HDCP_Support_On_Changed != null) HDCP_Support_On_Changed(HDCP_Support_On_fb); }
        }
        public event Action<bool> HDCP_Support_Off_Changed;
        public bool HDCP_Support_Off_fb
        {
            get { return HDMIInput.HdmiInputPort.HdcpSupportOffFeedback.BoolValue; }
            private set { if (HDCP_Support_Off_Changed != null) HDCP_Support_Off_Changed(HDCP_Support_Off_fb); }
        }
        public event Action<bool> Audio_Source_Detected_Changed;
        public bool Audio_Source_Detected_fb
        {
            get { return HDMIInput.HdmiInputPort.AudioSourceDetectedFeedBack.BoolValue; }
            private set { if (Audio_Source_Detected_Changed != null) Audio_Source_Detected_Changed(Audio_Source_Detected_fb); }
        }
        public event Action<bool> CEC_Err_Changed;
        public bool CEC_Err_fb
        {
            get { return HDMIInput.HdmiInputPort.StreamCec.ErrorFeedback.BoolValue; }
            private set { if (CEC_Err_Changed != null) CEC_Err_Changed(CEC_Err_fb); }
        }

        public event Action<ushort> Horizontal_Resolution_Changed;
        public ushort Horizontal_Resolution_fb
        {
            get { return HDMIInput.HdmiInputPort.VideoAttributes.HorizontalResolutionFeedback.UShortValue; }
            private set { if (Horizontal_Resolution_Changed != null) Horizontal_Resolution_Changed(Horizontal_Resolution_fb); }
        }
        public event Action<ushort> Vertical_Resolution_Changed;
        public ushort Vertical_Resolution_fb
        {
            get { return HDMIInput.HdmiInputPort.VideoAttributes.VerticalResolutionFeedback.UShortValue; }
            private set { if (Vertical_Resolution_Changed != null) Vertical_Resolution_Changed(Vertical_Resolution_fb); }
        }
        public event Action<ushort> Refresh_Rate_Changed;
        public ushort Refresh_Rate_fb
        {
            get { return HDMIInput.HdmiInputPort.VideoAttributes.FramesPerSecondFeedback.UShortValue; }
            private set { if (Refresh_Rate_Changed != null) Refresh_Rate_Changed(Refresh_Rate_fb); }
        }
        public event Action<eAspectRatio> Aspect_Ratio_Changed;
        public eAspectRatio Aspect_Ratio_fb
        {
            get { return (eAspectRatio)HDMIInput.HdmiInputPort.VideoAttributes.AspectRatioFeedback.UShortValue; }
            private set { if (Aspect_Ratio_Changed != null) Aspect_Ratio_Changed(Aspect_Ratio_fb); }
        }
        public event Action<eDmStream3DStatus> Status_3D_Changed;
        public eDmStream3DStatus Status_3D_fb
        {
            get { return HDMIInput.HdmiInputPort.VideoAttributes.Stream3DStatusFeedback; }
            private set { if (Status_3D_Changed != null) Status_3D_Changed(Status_3D_fb); }
        }
        public event Action<eDmAudioFormat> Audio_Format_Changed;
        public eDmAudioFormat Audio_Format_fb
        {
             get { return HDMIInput.HdmiInputPort.AudioFormatFeedback; }
            private set { if (Audio_Format_Changed != null) Audio_Format_Changed(Audio_Format_fb); }
        }
        public event Action<ushort> Audio_Channels_Changed;
        public ushort Audio_Channels_fb
        {
            get { return HDMIInput.HdmiInputPort.Audio.AudioChannelsFeedback.UShortValue; }
            private set { if (Audio_Channels_Changed != null) Audio_Channels_Changed(Audio_Channels_fb); }
        }
        public event Action<short> Audio_Gain_Changed;
        public short Audio_Gain_fb
        {
            get { return HDMIInput.HdmiInputPort.HdmiAudioGainFeedBack.ShortValue; }
            private set { if (Audio_Gain_Changed != null) Audio_Gain_Changed(Audio_Gain_fb); }
        }

        public event Action<string> Receive_CEC_Message_Changed;
        public string Receive_CEC_Message_fb
        {
            get { return HDMIInput.HdmiInputPort.StreamCec.Received.StringValue; }
            private set { if (Receive_CEC_Message_Changed != null) Receive_CEC_Message_Changed(Receive_CEC_Message_fb); }
        }

        public string HDMIInputPort { get; private set; }
        #endregion

        #region Public Methods
        public void HDCP_Support_On() { HDMIInput.HdmiInputPort.HdcpSupportOn(); }

        public void HDCP_Support_Off() { HDMIInput.HdmiInputPort.HdcpSupportOff(); }

        public void Audio_Gain(short Gain)
        {
            if (Gain >= -100 && Gain <= 100)
            {
                HDMIInput.HdmiInputPort.HdmiAudioGain.ShortValue = Gain; ;
            }
        }

        public void Transmit_CEC_Message(string Message) { HDMIInput.HdmiInputPort.StreamCec.Send.StringValue = Message; }
        #endregion

        #region Private Fields
        private Card.Dmps3HdmiInputWithoutAnalogAudio HDMIInput;

        //singletons
        private static DMPS4K150C_HDMI_Input HDMIInput1;
        private static DMPS4K150C_HDMI_Input HDMIInput2;
        private static DMPS4K150C_HDMI_Input HDMIInput3;
        private static DMPS4K150C_HDMI_Input HDMIInput4;

        private ControlSystem _ControlSystem;
        private DMPS4K150C_SwitcherInput _SwitcherInput;
        #endregion

        //factory to prevent duplicate instansiations.
        public static DMPS4K150C_HDMI_Input GetHDMIInput(ControlSystem ControlSystem, ControlSystem.eDmps34K150CInputs Input)
        {

            if (TestInputRange(Input))
            {
                switch (Input)
                {
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi1:
                        return HDMIInput1 ?? (HDMIInput1 = new DMPS4K150C_HDMI_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi2:
                        return HDMIInput2 ?? (HDMIInput2 = new DMPS4K150C_HDMI_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi3:
                        return HDMIInput3 ?? (HDMIInput3 = new DMPS4K150C_HDMI_Input(ControlSystem, Input));
                    case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi4:
                        return HDMIInput4 ?? (HDMIInput4 = new DMPS4K150C_HDMI_Input(ControlSystem, Input));
                    default:
                        return null;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        private DMPS4K150C_HDMI_Input(ControlSystem ControlSystem, ControlSystem.eDmps34K150CInputs Input)
        {
            this.HDMIInputPort = Input.ToString(); ;


            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");

            _ControlSystem = ControlSystem;
            _SwitcherInput = DMPS4K150C_SwitcherInput.GetDMPS4K150C_SwitcherInput(_ControlSystem);
            HDMIInput = _ControlSystem.SwitcherInputs[(uint)Input] as Card.Dmps3HdmiInputWithoutAnalogAudio;

            switch (Input)
            {
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi1:
                    _SwitcherInput.HDMI1InputChanged +=new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_HDMI1InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi2:
                    _SwitcherInput.HDMI2InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_HDMI2InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi3:
                    _SwitcherInput.HDMI3InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_HDMI3InputChanged);
                    break;
                case Crestron.SimplSharpPro.CrestronControlSystem.eDmps34K150CInputs.Hdmi4:
                    _SwitcherInput.HDMI4InputChanged += new DMPS4K150C_SwitcherInput.SwitcherInputEventHandler(_SwitcherInput_HDMI4InputChanged);
                    break;

                default:
                    break;
            }

            HDMIInput.HdmiInputPort.VideoAttributes.AttributeChange += new Crestron.SimplSharpPro.DeviceSupport.GenericEventHandler(VideoAttributes_AttributeChange);
            HDMIInput.HdmiInputPort.StreamCec.CecChange += new CecChangeEventHandler(StreamCec_CecChange);
        }

        void StreamCec_CecChange(Cec cecDevice, CecEventArgs args)
        {
            switch (args.EventId)
            {
                case CecEventIds.ErrorFeedbackEventId:
                    CEC_Err_fb = HDMIInput.HdmiInputPort.StreamCec.ErrorFeedback.BoolValue;
                    break;
                case CecEventIds.CecMessageReceivedEventId:
                     Receive_CEC_Message_fb = HDMIInput.HdmiInputPort.StreamCec.Received.StringValue;
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
                    Status_3D_fb = HDMIInput.HdmiInputPort.VideoAttributes.Stream3DStatusFeedback;
                    break;
                default:
                    break;
            }
        }

        void _SwitcherInput_HDMI4InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_HDMI3InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_HDMI2InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        void _SwitcherInput_HDMI1InputChanged(IDmCardStreamBase stream, DMInputEventArgs args)
        {
            ProcessEvent(args);
        }

        private void ProcessEvent(DMInputEventArgs args)
        {
            switch (args.EventId)
            {
                case DMInputEventIds.VideoDetectedEventId:
                    Video_Source_Detected_fb = HDMIInput.HdmiInputPort.HdmiVideoSourceDetectedFeedBack.BoolValue;
                    break;
                case DMInputEventIds.SourceSyncEventId:
                    Sync_Detected_fb = HDMIInput.HdmiInputPort.SyncDetectedFeedback.BoolValue;
                    break;
                case DMInputEventIds.HdcpSupportOnEventId:
                    HDCP_Support_On_fb = HDMIInput.HdmiInputPort.HdcpSupportOnFeedback.BoolValue;
                    break;
                case DMInputEventIds.HdcpSupportOffEventId:
                    HDCP_Support_Off_fb = HDMIInput.HdmiInputPort.HdcpSupportOffFeedback.BoolValue;
                    break;
                case DMInputEventIds.AudioSourceDetectedEventId:
                    Audio_Source_Detected_fb = HDMIInput.HdmiInputPort.AudioSourceDetectedFeedBack.BoolValue;
                    break;
                case DMInputEventIds.AudioFormatEventId:
                    Audio_Format_fb = HDMIInput.HdmiInputPort.AudioFormatFeedback;
                    break;
                case DMInputEventIds.AudioChannelsEventId:
                    Audio_Channels_fb = HDMIInput.HdmiInputPort.Audio.AudioChannelsFeedback.UShortValue;
                    break;
                case DMInputEventIds.AudioGainFeedbackEventId:
                    Audio_Gain_fb = HDMIInput.HdmiInputPort.HdmiAudioGainFeedBack.ShortValue;
                    break;
                default:
                    break;
            }

        }

        private static bool TestInputRange(ControlSystem.eDmps34K150CInputs Input)
        {
            if (Input >= ControlSystem.eDmps34K150CInputs.Hdmi1 && Input <= ControlSystem.eDmps34K150CInputs.Hdmi4) return true;
            else return false;
        }

    }
}