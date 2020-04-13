using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharp.CrestronIO;

namespace CP3_CP3N.Test_Components
{
    public static class TestIR
    {
        private static IROutputPort _IROutputPort;
        static uint AcerIRFileId;
        static uint AdcomIRFileId;
        static Random rand = new Random();
        public static void Start(IROutputPort IROutputPort)
        {
            if (IROutputPort == null) return;
            _IROutputPort = IROutputPort;

            string AcerIRFileName = string.Format("{0}\\IRFiles\\ACER WIL-8458MA.ir", Directory.GetApplicationDirectory());
            AcerIRFileId = LoadIRDiver(AcerIRFileName);
            string AdcomIRFileName = string.Format("{0}\\IRFiles\\adcom_gdd_1.ir", Directory.GetApplicationDirectory());
            AdcomIRFileId = LoadIRDiver(AdcomIRFileName);


            CrestronConsole.AddNewConsoleCommand(SendAcerCommand, "TSendAcerIR", "Sends Acer Left Click Command ", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SendAdcomCommand, "TSendAdcomIR", "Sends Acer Left Click Command ", ConsoleAccessLevelEnum.AccessOperator);
        }
        private static void SendAcerCommand(string message)
        {
            SendCommand(AcerIRFileId, "Acer");
        }
        private static void SendAdcomCommand(string message)
        {
            SendCommand(AdcomIRFileId, "Adcom");
        }
        private static void SendCommand(uint IRId, string Name)
        {
            if (IRId == 0) return;
            var DriverCommands = _IROutputPort.AvailableIRCmds(IRId);
            var NoOfCommands = DriverCommands.Count();
            var CommandToSend = DriverCommands[rand.Next(NoOfCommands)];
            CrestronConsole.ConsoleCommandResponse("CMD:Transmitting {0} IR {1}...\n",Name, CommandToSend);
            _IROutputPort.PressAndRelease(IRId, CommandToSend, 200);
        }
        private static uint LoadIRDiver(string Filename)
        {
            uint DriverID = 0;
            try
            {
                DriverID = _IROutputPort.LoadIRDriver(Filename);
            }
            catch (ArgumentException)
            {
                ErrorLog.Error("Invalid IR File being loaded: {0}", Filename);
            }
            catch (FileNotFoundException)
            {
                ErrorLog.Error("IR file being loaded was not found: {0}", Filename);
            }
            return DriverID;
        }
    }
}