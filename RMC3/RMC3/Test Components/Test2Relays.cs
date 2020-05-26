using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Relays;

namespace RMC3.Test_Components
{
    public static class Test2Relays
    {
        static Relays2Card _Relays2Card;
        static public void Start(Relays2Card Relays2Card)
        {
            _Relays2Card = Relays2Card;
            _Relays2Card.A1_F_Changed += value => {
                CrestronConsole.PrintLine("Relay 1 Changed  :{0}", value);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 1, _Relays2Card.A1_F);
            };
            _Relays2Card.A2_F_Changed += value =>
            {
                CrestronConsole.PrintLine("Relay 2 Changed  :{0}", value);
                CrestronConsole.PrintLine("CMD:Relay {0} State {1}", 2, _Relays2Card.A2_F);
            };
            CrestronConsole.AddNewConsoleCommand(SetRelay, "TSetRelay", "Changes Relay # ON|OFF", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetRelay, "TGetRelay", "Get Relay # State", ConsoleAccessLevelEnum.AccessOperator);

        }

        static void SetRelay(string Input)
        {
            string MessageHelp = "TSetRelay Relay(1-2) [ON|OFF]";
            var commands = Input.Split(' ');
            bool state = commands[1] == "ON" ? true : false;
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(commands[0]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber >= 1 && InputNumber <= 2)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Relay {0} to {1}", InputNumber, state);
                if (InputNumber == 1) _Relays2Card.A1 = state;
                if (InputNumber == 2) _Relays2Card.A2 = state;
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }

        static void GetRelay(string Input)
        {
            bool state = false;
            string MessageHelp = "TGetRelay Relay(1-2)";
            uint InputNumber;
            try
            {
                InputNumber = uint.Parse(Input);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return;
            }
            if (InputNumber >= 1 && InputNumber <= 2)
            {
                if (InputNumber == 1) state=_Relays2Card.A1_F;
                if (InputNumber == 2) state=_Relays2Card.A2_F;
                CrestronConsole.ConsoleCommandResponse("CMD:Relay {0} State {1}", InputNumber, state);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}