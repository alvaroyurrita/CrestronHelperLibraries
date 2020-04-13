using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Endpoints;

namespace HDCPSupport
{
    public class HDMIOutputHDCP
    {
        #region Public Events and Properties
        public event Action<bool> Disabled_By_HDCP_fb_Changed;
        public bool Disabled_By_HDCP_fb
        {
            get { return _EndpointHdmiOutput.DisabledByHdcpFeedback.BoolValue; }
            private set { if (Disabled_By_HDCP_fb_Changed != null) Disabled_By_HDCP_fb_Changed(Disabled_By_HDCP_fb); }
        }
        public event Action<eHdcpTransmitterMode> Hdcp_Tranmsitter_Mode_Changed;
        public eHdcpTransmitterMode Hdcp_Tranmsitter_Mode_fb
        {
            get { return _EndpointHdmiOutput.HdcpTransmitterModeFeedback; }
            private set { if (Hdcp_Tranmsitter_Mode_Changed != null) Hdcp_Tranmsitter_Mode_Changed(Hdcp_Tranmsitter_Mode_fb); }
        }
        #endregion


        #region Public Methods
        public void Hdcp_Transmittter_Mode(eHdcpTransmitterMode Mode) { _EndpointHdmiOutput.HdcpTransmitterMode = Mode; }
        #endregion

        #region Private Fields
        EndpointHdmiOutput _EndpointHdmiOutput;
        #endregion

        public HDMIOutputHDCP(EndpointHdmiOutput EndpointHdmiOutput)
        {
            _EndpointHdmiOutput = EndpointHdmiOutput;
            _EndpointHdmiOutput.OutputStreamChange += new EndpointOutputStreamChangeEventHandler(_EndpointHdmiOutput_OutputStreamChange);
        }

        void _EndpointHdmiOutput_OutputStreamChange(EndpointOutputStream outputStream, EndpointOutputStreamEventArgs args)
        {
            switch (args.EventId)
            {
                case EndpointOutputStreamEventIds.HdmiOutDisabledFeedbackEventId:
                    Disabled_By_HDCP_fb = _EndpointHdmiOutput.DisabledByHdcpFeedback.BoolValue; ;
                    break;
                case EndpointOutputStreamEventIds.HdcpTransmitterModeFeedbackEventId:
                    Hdcp_Tranmsitter_Mode_fb = _EndpointHdmiOutput.HdcpTransmitterModeFeedback;
                    break;
                default:
                    break;
            }
        }
    }
}

