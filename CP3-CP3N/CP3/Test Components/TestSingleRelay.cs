using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Relays;

namespace CP3_CP3N.Test_Components
{
    public class TestSingleRelay
    {
        private SingleRelay _Relay;
        public TestSingleRelay(SingleRelay Relay)
        {
            _Relay = Relay;
            _Relay.RelayStateChanged += (rly, value) => { CrestronConsole.PrintLine("Port {2}: Relay Changed: {0}, {1}", value, _Relay.RelayState, _Relay.Number); };

            CrestronConsole.AddNewConsoleCommand(SetRelay, "TSetRelay"+_Relay.Name, "Set/Reset A Relay", ConsoleAccessLevelEnum.AccessOperator);
        }
        void SetRelay(string State)
        {
            if (State.ToUpper() == "ON") _Relay.RelayState = true;
            else if (State.ToUpper() == "OFF") _Relay.RelayState = false;
            else { CrestronConsole.ConsoleCommandResponse("TSetRelay"+_Relay.Name+" [ON|OFF]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Relay to {0}...\n", State);
        }
    }


}