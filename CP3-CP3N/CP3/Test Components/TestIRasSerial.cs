using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;

namespace CP3_CP3N.Test_Components
{
    public static class TestIRasSerial
    {
        private static IROutputPort _IROutputPort;
        public static void Start(IROutputPort IROutputPort)
        {
            if (IROutputPort == null) return;
            _IROutputPort = IROutputPort;

            _IROutputPort.SetIRSerialSpec(eIRSerialBaudRates.ComspecBaudRate9600,
                eIRSerialDataBits.ComspecDataBits8,
                eIRSerialParityType.ComspecParityNone,
                eIRSerialStopBits.ComspecStopBits1,
                Encoding.ASCII);


            CrestronConsole.AddNewConsoleCommand(SendIRSerial, "TSendIRSerial", "Sends Serial Hello ", ConsoleAccessLevelEnum.AccessOperator);
        }
        private static void SendIRSerial(string message)
        {
            _IROutputPort.SendSerialData("Hello");
        }
    }
}