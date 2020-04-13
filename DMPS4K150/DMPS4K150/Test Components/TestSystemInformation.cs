using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Eternet_Extenders;
using System_Monitors;

namespace DMPS4K150.Test_Components
{
    public static class TestSystemInformation
    {
        static System_Information _SystemInformation;
        static public void Start(System_Information SystemInformation)
        {
            _SystemInformation = SystemInformation;


            _SystemInformation.BACnetAppVersion_Changed += value => CrestronConsole.PrintLine("BACnetAppVersion_Changed  :{0}", value);
            _SystemInformation.ControllerVersion_Changed += value => CrestronConsole.PrintLine("ControllerVersion_Changed  :{0}", value);
            _SystemInformation.IOControllerVersion_Changed += value => CrestronConsole.PrintLine("IOControllerVersion_Changed  :{0}", value);
            _SystemInformation.SNMPAppVersion_Changed += value => CrestronConsole.PrintLine("SNMPAppVersion_Changed  :{0}", value);


            CrestronConsole.AddNewConsoleCommand(Retrigger, "TSysInfoReport", "Report Firmware Version", ConsoleAccessLevelEnum.AccessOperator);
        }
        static void Retrigger(string message)
        {
            _SystemInformation.ReportFirmwareVersion(); ;
        }
    }
}