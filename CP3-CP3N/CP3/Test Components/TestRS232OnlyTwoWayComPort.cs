using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Serial_Drivers;

namespace CP3_CP3N.Test_Components
{
    public class TestRS232OnlyTwoWayComPort
    {
        private RS232OnlyTwoWaySerialDriver _ComPort;
        public TestRS232OnlyTwoWayComPort(RS232OnlyTwoWaySerialDriver ComPort)
        {
            _ComPort = ComPort;
            Start();
        }
        private void Start()
        {
            _ComPort.BaudRate_Changed += (Mode) => { CrestronConsole.PrintLine("{2} Baud Rate Mode: {0}, {1}", Mode.ToString(), _ComPort.BaudRate.ToString(), _ComPort.Name); };
            _ComPort.DataBits_Changed += (Mode) => { CrestronConsole.PrintLine("{2} Data Bits Mode: {0}, {1}", Mode.ToString(), _ComPort.DataBits.ToString(), _ComPort.Name); };
            _ComPort.PresetStringReceived += (Cmd, State) => { CrestronConsole.PrintLine("{2} Command : {0} State is, {1}.", Cmd.Name, State, _ComPort.Name); };
            _ComPort.Parity_Changed += (Mode) => { CrestronConsole.PrintLine("{2} Parity Mode: {0}, {1}", Mode.ToString(), _ComPort.Parity.ToString(), _ComPort.Name); };
            _ComPort.rx_Changed += (Message) => { CrestronConsole.PrintLine("{2} RX Message: {0}, {1}", MakePrintable(Message), MakePrintable(_ComPort.rx), _ComPort.Name); };
            _ComPort.StopBits_Changed += (Mode) => { CrestronConsole.PrintLine("{2} StopBits Mode: {0}, {1}", Mode.ToString(), _ComPort.StopBits.ToString(), _ComPort.Name); };


            CrestronConsole.AddNewConsoleCommand(SetBaudRate, "TSetBaudRate" + _ComPort.Name, "Set Baud Rate for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetDataBits, "TSetDataBits" + _ComPort.Name, "Set Data Bits for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetParity, "TSetParity" + _ComPort.Name, "Set Parity for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetStopBits, "TSetStopBits" + _ComPort.Name, "Set Stop Bits for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TransmitData, "TTransmitData" + _ComPort.Name, "Transmit Data for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetPresetStatus, "TGetPresetStatus" + _ComPort.Name, "Get Message Status for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TransmitPreset, "TTransmitPreset" + _ComPort.Name, "Transmit Pre Built Message for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeDelimiter, "TChangeDelimiter" + _ComPort.Name, "Changing Delimiter for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);

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
            string MessageHelp = "TSetBaudRate" + _ComPort.Name + " [0,2,4,8,16,32,64,128,256,512,1024,2048,4096,8192,65536]";
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
            string MessageHelp = "TSetDataBits" + _ComPort.Name + " [7,8]";
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
            string MessageHelp = "TSetParity" + _ComPort.Name + " [0,1,2,3]";
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
            string MessageHelp = "TSetStopBits" + _ComPort.Name + " [1,2]";
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
            string MessageHelp = "TTransmitData" + _ComPort.Name + " message";
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
            string MessageHelp = "TTransmitMessage" + _ComPort.Name + " message";
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
            string MessageHelp = "TGetPresetStatus" + _ComPort.Name + " message";
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
            string MessageHelp = "TTransmitData" + _ComPort.Name + " message";
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
    }
}