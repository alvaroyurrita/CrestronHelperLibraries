using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharp.CrestronIO;
using DMTransmitters;
using Serial_Drivers;
using CECDevices;

namespace DMPS4K150.Test_Components
{
    public class TestDMTx4K100C1G
    {
        private DM_TX_4K_100_C_1G _DM_TX_4K_100_C_1G;
        private IROutputPort _IROutputPort;
        static uint AcerIRFileId;
        static uint AdcomIRFileId;
        static Random rand = new Random();

        private RS232OnlyTwoWaySerialDriver _ComPort;

        private CECDevice _CECDevice;

        public TestDMTx4K100C1G(DM_TX_4K_100_C_1G DM_TX_4K_100_C_1G)
        {
            _DM_TX_4K_100_C_1G = DM_TX_4K_100_C_1G;
            if (_DM_TX_4K_100_C_1G.IR != null)
            {
                _IROutputPort = _DM_TX_4K_100_C_1G.IR;
                StartIRTest();
            }

            if (_DM_TX_4K_100_C_1G.Com01 != null)
            {
                _ComPort = _DM_TX_4K_100_C_1G.Com01;
                StartComPortTest();
            }
            if (_DM_TX_4K_100_C_1G.HDMI_In != null)
            {
                _CECDevice = _DM_TX_4K_100_C_1G.HDMI_In;
                StartCECTest();
            }

        }

        #region TestIR
        void StartIRTest()
        {

            string AcerIRFileName = string.Format("{0}\\IRFiles\\ACER WIL-8458MA.ir", Directory.GetApplicationDirectory());
            AcerIRFileId = LoadIRDiver(AcerIRFileName);
            string AdcomIRFileName = string.Format("{0}\\IRFiles\\adcom_gdd_1.ir", Directory.GetApplicationDirectory());
            AdcomIRFileId = LoadIRDiver(AdcomIRFileName);

            CrestronConsole.AddNewConsoleCommand(SendAcerCommand, "TSendAcerIRDMTX", "Sends Acer Left Click Command ", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SendAdcomCommand, "TSendAdcomIRDMTX", "Sends Acer Left Click Command ", ConsoleAccessLevelEnum.AccessOperator);

        }
        uint LoadIRDiver(string Filename)
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
        void SendCommand(uint IRId, string Name)
        {
            if (IRId == 0) return;
            var DriverCommands = _IROutputPort.AvailableIRCmds(IRId);
            var NoOfCommands = DriverCommands.Count();
            var CommandToSend = DriverCommands[rand.Next(NoOfCommands)];
            CrestronConsole.ConsoleCommandResponse("CMD:Transmitting {0} IR {1}...\n", Name, CommandToSend);
            _IROutputPort.PressAndRelease(IRId, CommandToSend, 200);
        }
        void SendAcerCommand(string message)
        {
            SendCommand(AcerIRFileId, "Acer");
        }
        void SendAdcomCommand(string message)
        {
            SendCommand(AdcomIRFileId, "Adcom");
        }
        #endregion

        #region TestComPort
        private void StartComPortTest()
        {
            _ComPort.BaudRate_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMTX Baud Rate Mode: {0}, {1}", Mode.ToString(), _ComPort.BaudRate.ToString(), _ComPort.Name); };
            _ComPort.DataBits_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMTX Data Bits Mode: {0}, {1}", Mode.ToString(), _ComPort.DataBits.ToString(), _ComPort.Name); };
            _ComPort.PresetStringReceived += (Cmd, State) => { CrestronConsole.PrintLine("{2}DMTX Command : {0} State is, {1}.", Cmd.Name, State, _ComPort.Name); };
            _ComPort.Parity_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMTX Parity Mode: {0}, {1}", Mode.ToString(), _ComPort.Parity.ToString(), _ComPort.Name); };
            _ComPort.rx_Changed += (Message) => { CrestronConsole.PrintLine("{2}DMTX RX Message: {0}, {1}", MakePrintable(Message), MakePrintable(_ComPort.rx), _ComPort.Name); };
            _ComPort.StopBits_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMTX StopBits Mode: {0}, {1}", Mode.ToString(), _ComPort.StopBits.ToString(), _ComPort.Name); };


            CrestronConsole.AddNewConsoleCommand(SetBaudRate, "TSetBaudRateDMTX" , "Set Baud Rate for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetDataBits, "TSetDataBitsDMTX" , "Set Data Bits for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetParity, "TSetParityDMTX" , "Set Parity for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetStopBits, "TSetStopBitsDMTX" , "Set Stop Bits for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TransmitData, "TTransmitDataDMTX" , "Transmit Data for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetPresetStatus, "TGetPresetStatusDMTX" , "Get Message Status for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TransmitPreset, "TTransmitPresetDMTX" , "Transmit Pre Built Message for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeDelimiter, "TChangeDelimiterDMTX" , "Changing Delimiter for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);

            _ComPort.delimiter = "\r";

            _ComPort.PresetStrings.Add(new ComPortPresetStrings() { Name = "ProjOn", Command = "Projector On" });
            _ComPort.PresetStrings.Add(new ComPortPresetStrings() { Name = "ProjOff", Command = "\x01\x02Proj Off" });
            _ComPort.PresetStrings.Add(new ComPortPresetStrings() { Name = "ProjIsOn", Command = "Projector Is On" });
            _ComPort.PresetStrings.Add(new ComPortPresetStrings() { Name = "ProjIsOff", Command = "\x01\x02Proj Is Off" });
        }

        private string MakePrintable(string Message)
        {
            return Regex.Replace(Message, @"\p{Cc}", a => string.Format("[{0:X2}]", (byte)a.Value[0]));
        }
        int GetFirstParameterInteger(string value, string MessageHelp)
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
        void SetBaudRate(string value)
        {
            string MessageHelp = "TSetBaudRateDMTX" + _ComPort.Name + " [0,2,4,8,16,32,64,128,256,512,1024,2048,4096,8192,65536]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(ComPort.eComBaudRates), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Baud Rate to {0}", ((ComPort.eComBaudRates)mode).ToString());
                _ComPort.BaudRate = ((ComPort.eComBaudRates)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SetDataBits(string value)
        {
            string MessageHelp = "TSetDataBitsDMTX" + _ComPort.Name + " [7,8]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (mode == 7 || mode == 8)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Data Bits to {0}", ((ComPort.eComDataBits)mode).ToString());
                _ComPort.DataBits = ((ComPort.eComDataBits)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);

        }
        void SetParity(string value)
        {
            string MessageHelp = "TSetParityDMTX" + _ComPort.Name + " [0,1,2,3]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(ComPort.eComParityType), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Parity Bits to {0}", ((ComPort.eComParityType)mode).ToString());
                _ComPort.Parity = ((ComPort.eComParityType)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SetStopBits(string value)
        {
            string MessageHelp = "TSetStopBitsDMTX" + _ComPort.Name + " [1,2]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(ComPort.eComStopBits), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Stop Bits to {0}", ((ComPort.eComStopBits)mode).ToString());
                _ComPort.StopBits = ((ComPort.eComStopBits)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        private void TransmitData(string param)
        {
            string MessageHelp = "TTransmitDataDMTX" + _ComPort.Name + " message";
            var commands = Regex.Matches(param, "\\\".*?\\\"|\\S*");
            string Message = "";
            try
            {
                Message = commands[0].Value.Replace("\"", string.Empty);
                Message = Regex.Unescape(Message);
            }
            catch
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
            }
            if (Message != "")
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Transmitting Data: {0} through Com Port", Message);
                _ComPort.tx(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);

        }
        private void TransmitPreset(string param)
        {
            string MessageHelp = "TTransmitMessageDMTX" + _ComPort.Name + " message";
            var commands = Regex.Matches(param, "\\\".*?\\\"|\\S*");
            string Message = "";
            try
            {
                Message = commands[0].Value.Replace("\"", string.Empty);
            }
            catch
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
            }
            if (Message != "")
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Transmitting Message: {0} through Com Port", Message);
                _ComPort.SendPresetString(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);

        }
        private void GetPresetStatus(string param)
        {
            string MessageHelp = "TGetPresetStatusDMTX" + _ComPort.Name + " message";
            var commands = Regex.Matches(param, "\\\".*?\\\"|\\S*");
            string Message = "";
            try
            {
                Message = commands[0].Value.Replace("\"", string.Empty);
            }
            catch
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
            }
            if (Message != "")
            {
                var status = _ComPort.GetPresetStringStatus(Message);
                CrestronConsole.ConsoleCommandResponse("CMD:Preset String {0} Status is {1}", Message, status);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);

        }
        private void ChangeDelimiter(string param)
        {
            string MessageHelp = "TTransmitDataDMTX" + _ComPort.Name + " message";
            var commands = Regex.Matches(param, "\\\".*?\\\"|\\S*");
            string Message = "";
            try
            {
                Message = commands[0].Value.Replace("\"", string.Empty);
                Message = Regex.Unescape(Message);
            }
            catch
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
            }
            if (Message != "")
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Delimiter to: {0}", Message);
                _ComPort.delimiter = Message;
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);

        }
 

        #endregion

        #region TestCEC
        void StartCECTest()
        {
            _CECDevice.CEC_Err_Changed += (state) => { CrestronConsole.PrintLine("{2} CEC Err Changed State: {0}, {1}", state, _CECDevice.CEC_Err_fb, _DM_TX_4K_100_C_1G.Name); };
            _CECDevice.Receive_CEC_Message_Changed += (message) => { CrestronConsole.PrintLine("{2} Receive CEC Message: {0}, {1}", message, _CECDevice.Receive_CEC_Message_fb, _DM_TX_4K_100_C_1G.Name); };
            CrestronConsole.AddNewConsoleCommand(SendCECMessage, "TCECMessagHDMITxDMTX", "Sends CEC Message through HDMI DM Transmitter", ConsoleAccessLevelEnum.AccessOperator);


        }
        void SendCECMessage(string message)
        {
            string MessageHelp = "TCECMessagHDMITxDMTX" + " message";
            var commands = Regex.Matches(message, "\\\".*?\\\"|\\S*");
            string Message = "";
            try
            {
                Message = commands[0].Value.Replace("\"", string.Empty);
                Message = Regex.Unescape(Message);
            }
            catch
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
            }
            if (Message != "")
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Sending Message {0} through CEC", Message);
                _CECDevice.Transmit_CEC_Message(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }

        #endregion

    }
}