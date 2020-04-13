using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;

namespace IOPorts
{
    public class DigitalInputPort
    {
        private DigitalInput _DigitalInput;
        public string Name { get; private set; }
        public uint Number { get; private set; }

        public event Action<DigitalInputPort, bool> State_Changed;
        private bool _State;
        public bool State
        {
            get{return _DigitalInput.State;}
            set {if (State_Changed != null) State_Changed(this, State);}
        }


        public DigitalInputPort(DigitalInput DigitalInput)
        {
            if (DigitalInput == null)
            {
                ErrorLog.Error("Error Creating Digital Input Port. Digital Input Port is null");
                return;
            }
            _DigitalInput = DigitalInput;
            if (_DigitalInput.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
            {
                ErrorLog.Error("Error Registering Digital Input Port ID {0}: {1}", _DigitalInput.ID, _DigitalInput.DeviceRegistrationFailureReason);
                return;
            }
            Name = "DigitalPort" + _DigitalInput.ID;
            Number = _DigitalInput.ID;
            _DigitalInput.StateChange += new DigitalInputEventHandler(_DigitalInput_StateChange);
        }

        void _DigitalInput_StateChange(DigitalInput digitalInput, DigitalInputEventArgs args)
        {
            State = _DigitalInput.State;
        }
    }
}