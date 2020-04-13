using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Relays;

namespace CP3_CP3N.Test_Components
{
    public class TestC2ICP3RY8
    {
        private static Relays8Card _Relay8Card;
        public static void Start(Relays8Card Relay8Card)
        {
            _Relay8Card = Relay8Card;

            _Relay8Card.A1_F_Changed += state => { CrestronConsole.PrintLine("Relay 1: State Changed: {0}, {1}", state, _Relay8Card.A1_F); };
            _Relay8Card.A2_F_Changed += state => { CrestronConsole.PrintLine("Relay 2: State Changed: {0}, {1}", state, _Relay8Card.A2_F); };
            _Relay8Card.A3_F_Changed += state => { CrestronConsole.PrintLine("Relay 3: State Changed: {0}, {1}", state, _Relay8Card.A3_F); };
            _Relay8Card.A4_F_Changed += state => { CrestronConsole.PrintLine("Relay 4: State Changed: {0}, {1}", state, _Relay8Card.A4_F); };
            _Relay8Card.A5_F_Changed += state => { CrestronConsole.PrintLine("Relay 5: State Changed: {0}, {1}", state, _Relay8Card.A5_F); };
            _Relay8Card.A6_F_Changed += state => { CrestronConsole.PrintLine("Relay 6: State Changed: {0}, {1}", state, _Relay8Card.A6_F); };
            _Relay8Card.A7_F_Changed += state => { CrestronConsole.PrintLine("Relay 7: State Changed: {0}, {1}", state, _Relay8Card.A7_F); };
            _Relay8Card.A8_F_Changed += state => { CrestronConsole.PrintLine("Relay 8: State Changed: {0}, {1}", state, _Relay8Card.A8_F); };

            CrestronConsole.AddNewConsoleCommand(SetRelay, "TSetRelay", "Set/Reset A Relay", ConsoleAccessLevelEnum.AccessOperator);
        }
        static int GetFirstParameterInteger(string value, string MessageHelp)
        {
            var commands = value.Split(' ');
            int Result;
            try
            {
                Result = int.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return 0xfff;
            }
            return Result;
        }
        static string GetSecondParameter(string value)
        {
            var commands = value.Split(' ');
            return commands[1].ToUpper();
        }
        public static void SetRelay(string State)
        {
            string MessageHelp = "TSetRelay {Port[1..8]} [On|Off]";
            int port = GetFirstParameterInteger(State, MessageHelp);
            bool state = GetSecondParameter(State) == "ON" ? true : false;
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        _Relay8Card.A1 = state;
                        break;
                    case 2:
                        _Relay8Card.A2 = state;
                        break;
                    case 3:
                        _Relay8Card.A3 = state;
                        break;
                    case 4:
                        _Relay8Card.A4 = state;
                        break;
                    case 5:
                        _Relay8Card.A5 = state;
                        break;
                    case 6:
                        _Relay8Card.A6 = state;
                        break;
                    case 7:
                        _Relay8Card.A7 = state;
                        break;
                    case 8:
                        _Relay8Card.A8 = state;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Relay {0} to {1}...\r\n", port, state);
        }
    }
}