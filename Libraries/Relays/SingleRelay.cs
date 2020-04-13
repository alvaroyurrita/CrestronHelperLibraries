using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace Relays
{
    public class SingleRelay
    {
        public event Action<SingleRelay, bool> RelayStateChanged;
        private bool _RelayState;
        public bool RelayState
        {
            get { return _Relay.State; }
            set 
            {
                if (_RelayState == value) return;
                _RelayState = value;
                if (_Relay.State != value) { _Relay.State = value; }
                if (RelayStateChanged != null) RelayStateChanged(this, _RelayState);
            
            }
        }

        public string Name { get; private set; }
        public uint Number { get; private set; }
        private Relay _Relay;

        public SingleRelay(Relay Relay)
        {
            if (Relay == null)
            {
                ErrorLog.Error("Error Creating SingleRelay. Relay is null");
                return;
            }
            _Relay = Relay;
            Name = "Relay" + _Relay.ID;
            Number = _Relay.ID;
            if (_Relay.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
            {
                ErrorLog.Error("Error Registering Relay ID {0}: {1}", _Relay.ID, _Relay.DeviceRegistrationFailureReason);
                return;
            }
            _Relay.StateChange += new RelayEventHandler(_Relay_StateChange);

        }

        void _Relay_StateChange(Relay relay, RelayEventArgs args)
        {
            RelayState = args.State;
        }
    }
}

