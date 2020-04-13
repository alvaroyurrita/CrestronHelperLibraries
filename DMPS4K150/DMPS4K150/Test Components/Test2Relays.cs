using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Relays;

namespace DMPS4K150.Test_Components
{
    public static class Test2Relays
    {
        static Relays2Card _Relays2Card;
        static public void Start(Relays2Card Relays2Card)
        {
            _Relays2Card = Relays2Card;
            _Relays2Card.A1_F_Changed += value => CrestronConsole.PrintLine("Relay 1 Changed  :{0}, {1}", value, _Relays2Card.A1_F);
            _Relays2Card.A2_F_Changed += value => CrestronConsole.PrintLine("Relay 2 Changed  :{0}, {1}", value, _Relays2Card.A2_F);

            CrestronConsole.AddNewConsoleCommand(SetRelay, "TSetRelay", "Changes Relay # ON|OFF", ConsoleAccessLevelEnum.AccessOperator);

        }

        static void SetRelay(string Input)
        {
            string MessageHelp = "TSetRelay Relay(0-10) [ON|OFF]";
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
    }
}