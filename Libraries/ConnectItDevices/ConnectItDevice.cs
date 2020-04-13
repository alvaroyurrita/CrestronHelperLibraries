using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.Keypads;
using Crestron.SimplSharpPro.DeviceSupport;                       				

namespace ConnectItDevices
{
    public class ConnectItDevice
    {
        #region public properties

        #region button 1
        public Action<eButtonState> Button1_Press_Changed;
        public eButtonState Button1_Press
        {
            get { return _Tt1xx.Button[1].State; }
            private set { if (Button1_Press_Changed != null) Button1_Press_Changed(Button1_Press); }
        }
        public Action<eLedStates> LED_State_1_Changed;
        public eLedStates LED_State_1_fb
        {
            get { return _Tt1xx.LedStateFeedback[1]; }
            private set {if (LED_State_1_Changed != null) LED_State_1_Changed(LED_State_1_fb);}
        }
        #endregion

        #region button 2
        public Action<eButtonState> Button2_Press_Changed;
        public eButtonState Button2_Press
        {
            get { return _Tt1xx.Button[2].State; }
            private set { if (Button2_Press_Changed != null) Button2_Press_Changed(Button2_Press); }
        }
        public Action<eLedStates> LED_State_2_Changed;
        public eLedStates LED_State_2_fb
        {
            get { return _Tt1xx.LedStateFeedback[2]; }
            private set{if (LED_State_2_Changed != null) LED_State_2_Changed(LED_State_2_fb);}
        }
        #endregion

        public string Name { get; private set; }
        public uint Number { get; private set; }

        #endregion

        #region public methods
        public void LED_State_1(eLedStates state) { _Tt1xx.SetLedState(1, state); }
        public void LED_State_2(eLedStates state) { _Tt1xx.SetLedState(2, state); }
        #endregion

        Tt1xx _Tt1xx;

        public ConnectItDevice(Tt1xx Tt1xx)
        {
            if (_Tt1xx == null)
            {
                ErrorLog.Error("Error Creating ConnectItDevice. Device is null");
                return;
            }
            _Tt1xx = Tt1xx;
            Name = "CI" + _Tt1xx.ID;
            Number = _Tt1xx.ID;
            if (_Tt1xx.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
            {
                ErrorLog.Error("Error Registering Connect It Device ID {0}: {1}", _Tt1xx.ID, _Tt1xx.RegistrationFailureReason);
                return;
            }
            _Tt1xx.BaseEvent += new BaseEventHandler(_Tt1xx_BaseEvent);
            _Tt1xx.ButtonStateChange += new ButtonEventHandler(_Tt1xx_ButtonStateChange);
        }

        void _Tt1xx_ButtonStateChange(GenericBase device, ButtonEventArgs args)
        {
            switch (args.Button.Number)
            {
                case 1:
                    Button1_Press = args.NewButtonState;
                    break;
                case 2:
                    Button2_Press = args.NewButtonState;
                    break;
                default:
                    break;
            }
        }

        void _Tt1xx_BaseEvent(GenericBase device, BaseEventArgs args)
        {
            switch (args.EventId)
            {
                case Tt1xxEventIds.LedState1FeedbackEventId:
                    LED_State_1_fb = _Tt1xx.LedStateFeedback[1];
                    break;
                case Tt1xxEventIds.LedState2FeedbackEventId:
                    LED_State_2_fb = _Tt1xx.LedStateFeedback[2];
                    break;
                default:
                    break;
            }
        }
    }
}

