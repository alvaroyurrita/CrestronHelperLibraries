using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.DM;

namespace CECDevices
{
    public class CECDevice
    {
        #region Public Events and Properties
        public event Action<bool> CEC_Err_Changed;
        public bool CEC_Err_fb
        {
            get { return _Cec.ErrorFeedback.BoolValue; }
            private set { if (CEC_Err_Changed != null) CEC_Err_Changed(CEC_Err_fb); }
        }
        public event Action<string> Receive_CEC_Message_Changed;
        public string Receive_CEC_Message_fb
        {
            get { return _Cec.Received.StringValue; }
            private set { if (Receive_CEC_Message_Changed != null) Receive_CEC_Message_Changed(Receive_CEC_Message_fb); }
        }
        #endregion


        #region Public Methods
        public void Transmit_CEC_Message(string Message) { _Cec.Send.StringValue = Message; }
        #endregion

        #region Private Fields
        Cec _Cec;
        #endregion

        public CECDevice(Cec Cec)
        {
            _Cec = Cec;
            _Cec.CecChange += new CecChangeEventHandler(_Cec_CecChange);
        }

        void _Cec_CecChange(Cec cecDevice, CecEventArgs args)
        {
            switch (args.EventId)
            {
                case CecEventIds.ErrorFeedbackEventId:
                    CEC_Err_fb = _Cec.ErrorFeedback.BoolValue;
                    break;
                case CecEventIds.CecMessageReceivedEventId:
                    Receive_CEC_Message_fb = _Cec.Received.StringValue;
                    break;

                default:
                    break;
            }
        }
    }
}

