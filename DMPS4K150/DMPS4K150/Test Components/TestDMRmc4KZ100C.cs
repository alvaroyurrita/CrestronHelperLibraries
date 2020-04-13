using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharp.CrestronIO;
using Crestron.SimplSharpPro.DM;
using DMReceivers;
using Serial_Drivers;
using CECDevices;
using HDCPSupport;

namespace DMPS4K150.Test_Components
{
    public class TestDMRmc4KZ100C
    {
        private DM_RMC_4KZ_100_C _DM_RMC_4KZ_100_C;
        private IROutputPort _IROutputPort;
        static uint AcerIRFileId;
        static uint AdcomIRFileId;
        static Random rand = new Random();

        private DMPS3TwoWaySerialDriver _ComPort;

        private CECDevice _CECHDCPDevice;
        private CECDevice _CECDMDevice;

        private HDMIOutputHDCP _HDMIOutputHDCP;

        public TestDMRmc4KZ100C(DM_RMC_4KZ_100_C DM_RMC_4KZ_100_C)
        {
            _DM_RMC_4KZ_100_C = DM_RMC_4KZ_100_C;
            if (_DM_RMC_4KZ_100_C.C2I_DMRMC100_4KZ_IR2 != null)
            {
                _IROutputPort = _DM_RMC_4KZ_100_C.C2I_DMRMC100_4KZ_IR2;
                StartIRTest();
            }

            if (_DM_RMC_4KZ_100_C.Com01 != null)
            {
                _ComPort = _DM_RMC_4KZ_100_C.Com01;
                StartComPortTest();
            }
            if (_DM_RMC_4KZ_100_C.CEC_DM_In != null)
            {
                _CECDMDevice = _DM_RMC_4KZ_100_C.CEC_DM_In;
                StartCECDMTest();
            }
            if (_DM_RMC_4KZ_100_C.CEC_HDMI_Out != null)
            {
                _CECHDCPDevice = _DM_RMC_4KZ_100_C.CEC_HDMI_Out;
                StartCECHDMITest();
            }
            if (_DM_RMC_4KZ_100_C.HDCP_HDMI_Out != null)
            {
                _HDMIOutputHDCP = _DM_RMC_4KZ_100_C.HDCP_HDMI_Out;
                StartHDCPTest();
            }

        }

        #region TestIR
        void StartIRTest()
        {

            string AcerIRFileName = string.Format("{0}\\IRFiles\\ACER WIL-8458MA.ir", Directory.GetApplicationDirectory());
            AcerIRFileId = LoadIRDiver(AcerIRFileName);
            string AdcomIRFileName = string.Format("{0}\\IRFiles\\adcom_gdd_1.ir", Directory.GetApplicationDirectory());
            AdcomIRFileId = LoadIRDiver(AdcomIRFileName);

            CrestronConsole.AddNewConsoleCommand(SendAcerCommand, "TSendAcerIRDMRX", "Sends Acer Left Click Command ", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SendAdcomCommand, "TSendAdcomIRDMRX", "Sends Acer Left Click Command ", ConsoleAccessLevelEnum.AccessOperator);

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
            _ComPort.BaudRate_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMRX Baud Rate Mode: {0}, {1}", Mode.ToString(), _ComPort.BaudRate.ToString(), _ComPort.Name); };
            _ComPort.cts_Changed += (State) => { CrestronConsole.PrintLine("{2}DMRX CTS State: {0}, {1}", State, _ComPort.cts, _ComPort.Name); };
            _ComPort.DataBits_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMRX Data Bits Mode: {0}, {1}", Mode.ToString(), _ComPort.DataBits.ToString(), _ComPort.Name); };
            _ComPort.HW_Handshake_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMRX Hardware Handshake Mode: {0}, {1}", Mode.ToString(), _ComPort.HW_HandShake.ToString(), _ComPort.Name); };
            _ComPort.PresetStringReceived += (Cmd, State) => { CrestronConsole.PrintLine("{2}DMRX Command : {0} State is, {1}.", Cmd.Name, State, _ComPort.Name); };
            _ComPort.Parity_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMRX Parity Mode: {0}, {1}", Mode.ToString(), _ComPort.Parity.ToString(), _ComPort.Name); };
            _ComPort.rx_Changed += (Message) => { CrestronConsole.PrintLine("{2}DMRX RX Message: {0}, {1}", MakePrintable(Message), MakePrintable(_ComPort.rx), _ComPort.Name); };
            _ComPort.StopBits_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMRX StopBits Mode: {0}, {1}", Mode.ToString(), _ComPort.StopBits.ToString(), _ComPort.Name); };
            _ComPort.SW_Handshake_Changed += (Mode) => { CrestronConsole.PrintLine("{2}DMRX Software Handshake Mode: {0}, {1}", Mode.ToString(), _ComPort.SW_HandShake.ToString(), _ComPort.Name); };


            CrestronConsole.AddNewConsoleCommand(SetBaudRate, "TSetBaudRateDMRX", "Set Baud Rate for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetDataBits, "TSetDataBitsDMRX" , "Set Data Bits for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetParity, "TSetParityDMRX" , "Set Parity for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetStopBits, "TSetStopBitsDMRX" , "Set Stop Bits for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetHWHandshake, "TSetHWHandshakeDMRX" , "Set HW Handshake for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetSWHandshake, "TSetSWHandshakeDMRX" , "Set SW Handshake for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TransmitData, "TTransmitDataDMRX" , "Transmit Data for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetRTS, "TSetRTSDMRX" , "Set SW Handshake for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetPresetStatus, "TGetPresetStatusDMRX" , "Get Message Status for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(TransmitPreset, "TTransmitPresetDMRX" , "Transmit Pre Built Message for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(ChangeDelimiter, "TChangeDelimiterDMRX", "Changing Delimiter for " + _ComPort.Name, ConsoleAccessLevelEnum.AccessOperator);

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
            string MessageHelp = "TSetBaudRateDMRX" + _ComPort.Name + " [0,2,4,8,16,32,64,128,256,512,1024,2048,4096,8192,65536]";
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
            string MessageHelp = "TSetDataBitsDMRX" + _ComPort.Name + " [7,8]";
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
            string MessageHelp = "TSetParityDMRX" + _ComPort.Name + " [0,1,2,3]";
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
            string MessageHelp = "TSetStopBitsDMRX" + _ComPort.Name + " [1,2]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(ComPort.eComStopBits), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Stop Bits to {0}", ((ComPort.eComStopBits)mode).ToString());
                _ComPort.StopBits = ((ComPort.eComStopBits)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SetHWHandshake(string value)
        {
            string MessageHelp = "TSetHWHandshakeDMRX" + _ComPort.Name + " [0,1,2,3]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(ComPort.eComHardwareHandshakeType), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Hardware Handshake to {0}", ((ComPort.eComHardwareHandshakeType)mode).ToString());
                _ComPort.HW_HandShake = ((ComPort.eComHardwareHandshakeType)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SetSWHandshake(string value)
        {
            string MessageHelp = "TSetSWHandshakeDMRX" + _ComPort.Name + " [0,1,2,3]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (Enum.IsDefined(typeof(ComPort.eComSoftwareHandshakeType), mode))
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Software Handshake to {0}", ((ComPort.eComSoftwareHandshakeType)mode).ToString());
                _ComPort.SW_HandShake = ((ComPort.eComSoftwareHandshakeType)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        private void TransmitData(string param)
        {
            string MessageHelp = "TTransmitDataDMRX" + _ComPort.Name + " message";
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
            string MessageHelp = "TTransmitMessageDMRX" + _ComPort.Name + " message";
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
            string MessageHelp = "TGetPresetStatusDMRX" + _ComPort.Name + " message";
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
        void SetRTS(string State)
        {
            if (State.ToUpper() == "ON") _ComPort.RTS = true;
            else if (State.ToUpper() == "OFF") _ComPort.RTS = false;
            else { CrestronConsole.ConsoleCommandResponse("TSetRTS" + _ComPort.Name + " [On|Off]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing RTS to {0}...\n", State.ToUpper());
        }
        private void ChangeDelimiter(string param)
        {
            string MessageHelp = "TTransmitDataDMRX" + _ComPort.Name + " message";
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

        #region TestCECDM
        void StartCECDMTest()
        {
            _CECDMDevice.CEC_Err_Changed += (state) => { CrestronConsole.PrintLine("{2} CEC Err Changed State: {0}, {1}", state, _CECDMDevice.CEC_Err_fb, _DM_RMC_4KZ_100_C.Name); };
            _CECDMDevice.Receive_CEC_Message_Changed += (message) => { CrestronConsole.PrintLine("{2} Receive CEC Message: {0}, {1}", message, _CECDMDevice.Receive_CEC_Message_fb, _DM_RMC_4KZ_100_C.Name); };
            CrestronConsole.AddNewConsoleCommand(SendCECDMMessage, "TCECDMMessageRxDMRX", "Sends CEC Message Through DM Receiver", ConsoleAccessLevelEnum.AccessOperator);
        }
        void SendCECDMMessage(string message)
        {
            string MessageHelp = "TCECDMMessageRxDMRX" + " message";
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
                _CECDMDevice.Transmit_CEC_Message(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        #endregion

        #region TestCECHDMI
        void StartCECHDMITest()
        {
            _CECHDCPDevice.CEC_Err_Changed += (state) => { CrestronConsole.PrintLine("{2} CEC Err Changed State: {0}, {1}", state, _CECHDCPDevice.CEC_Err_fb, _DM_RMC_4KZ_100_C.Name); };
            _CECHDCPDevice.Receive_CEC_Message_Changed += (message) => { CrestronConsole.PrintLine("{2} Receive CEC Message: {0}, {1}", message, _CECHDCPDevice.Receive_CEC_Message_fb, _DM_RMC_4KZ_100_C.Name); };
            CrestronConsole.AddNewConsoleCommand(SendCECHDMIMessage, "TCECHDMIMessageRxDMRX", "Sends CEC Message Through DM-HDMI Receiver", ConsoleAccessLevelEnum.AccessOperator);
        }
        void SendCECHDMIMessage(string message)
        {
            string MessageHelp = "TCECHDMIMessageRxDMRX" + " message";
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
                _CECHDCPDevice.Transmit_CEC_Message(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        #endregion

        #region TestHDCP
        void StartHDCPTest()
        {
            _HDMIOutputHDCP.Disabled_By_HDCP_fb_Changed += (state) => { CrestronConsole.PrintLine("{2} Disabled_By_HDCP_fb_Changed State: {0}, {1}", state, _HDMIOutputHDCP.Disabled_By_HDCP_fb, _DM_RMC_4KZ_100_C.Name); };
            _HDMIOutputHDCP.Hdcp_Tranmsitter_Mode_Changed += (message) => { CrestronConsole.PrintLine("{2} Hdcp_Tranmsitter_Mode_Changed: {0}, {1}", message, _HDMIOutputHDCP.Hdcp_Tranmsitter_Mode_fb, _DM_RMC_4KZ_100_C.Name); };
            CrestronConsole.AddNewConsoleCommand(ChangeHDCPMode, "TChangeHDCPModeDMRX", "Changes HDCP Mode", ConsoleAccessLevelEnum.AccessOperator);


        }
        void ChangeHDCPMode(string Input)
        {
            string MessageHelp = "TChangeHDCPModeDMRX InputNo(1|2|3)";
            var commands = Input.Split(' ');
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
            if (InputNumber == 1 || InputNumber == 2 || InputNumber == 3)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing Input DM1 USB Routed to Input {0}", InputNumber);
                _HDMIOutputHDCP.Hdcp_Transmittter_Mode((eHdcpTransmitterMode)InputNumber);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }

        #endregion
    }
}