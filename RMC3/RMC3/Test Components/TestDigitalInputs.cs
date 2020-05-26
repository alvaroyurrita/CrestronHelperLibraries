using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using IOPorts;

namespace RMC3.Test_Components
{
    public static class TestDigitalInputs
    {
        static DigitalInputs2Card _DigitalInputs2Card;
        static public void Start(DigitalInputs2Card DigitalInputs2Card)
        {
            _DigitalInputs2Card = DigitalInputs2Card;

            _DigitalInputs2Card.I1_F_Changed += value => CrestronConsole.PrintLine("Digital Input 1 Changed  :{0}, {1}", value, _DigitalInputs2Card.I1_F);
            _DigitalInputs2Card.I2_F_Changed += value => CrestronConsole.PrintLine("Digital Input 2 Changed  :{0}, {1}", value, _DigitalInputs2Card.I2_F);
        }
    }
}