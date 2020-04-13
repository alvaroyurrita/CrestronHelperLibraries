using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using USBPorts;

namespace CP3_CP3N.Test_Components
{
    public class TestUSBPort
    {
        private USBPort _UsbHid;
        public TestUSBPort(USBPort UsbHid)
        {
            _UsbHid = UsbHid;
            Start();
        }
        private void Start()
        {
            _UsbHid.Country_Code_Changed += (Code) => { CrestronConsole.PrintLine("{2} Country Code: {0}, {1}", Code.ToString(), _UsbHid.Country_Code.ToString(), _UsbHid.Name); };
            _UsbHid.Feature_Report_F_Changed += (message) => { CrestronConsole.PrintLine("{2} Feature Report: {0}, {1}", MakePrintable(message), MakePrintable(_UsbHid.Feature_Report_F), _UsbHid.Name); };
            _UsbHid.Input_Report_Changed += (message) => { CrestronConsole.PrintLine("{2} Input Report: {0}, {1}", MakePrintable(message),MakePrintable( _UsbHid.Input_Report), _UsbHid.Name); };
            _UsbHid.Manufacturer_Changed += (message) => { CrestronConsole.PrintLine("{2} Manufacturer: {0}, {1}", message, _UsbHid.Manufacturer, _UsbHid.Name); };
            _UsbHid.Product_Changed += (message) => { CrestronConsole.PrintLine("{2} Product: {0}, {1}", message, _UsbHid.Product, _UsbHid.Name); };
            _UsbHid.Report_Descriptor_Changed += (message) => { CrestronConsole.PrintLine("{2} Report Descriptor: {0}, {1}", MakePrintable(message), MakePrintable(_UsbHid.Report_Descriptor), _UsbHid.Name); };
            _UsbHid.Serial_Number_Changed += (message) => { CrestronConsole.PrintLine("{2} Serial Number: {0}, {1}", message, _UsbHid.Serial_Number, _UsbHid.Name); };
            _UsbHid.offline_Changed += (State) => { CrestronConsole.PrintLine("{2} Offline State: {0}, {1}", State, _UsbHid.offline, _UsbHid.Name); };

            CrestronConsole.AddNewConsoleCommand(OutputReport, "TOutputReport" + _UsbHid.Name, "Output Report Data for " + _UsbHid.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(FeatureReport, "TFeatureReport" + _UsbHid.Name, "Feature Report Data for" + _UsbHid.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetAllProps, "TGetAllProps" + _UsbHid.Name, "Get All Properties for" + _UsbHid.Name, ConsoleAccessLevelEnum.AccessOperator);
        }
        private string MakePrintable(string Message)
        {
            return Regex.Replace(Message, @"\p{Cc}", a => string.Format("[{0:X2}]", (byte)a.Value[0]));
        }
        void GetAllProps(string message)
        {
            CrestronConsole.ConsoleCommandResponse("CMD:Country Code: {0}\r\n", _UsbHid.Country_Code.ToString());
            CrestronConsole.ConsoleCommandResponse("CMD:Feature Report: {0}\r\n", MakePrintable(_UsbHid.Feature_Report_F));
            CrestronConsole.ConsoleCommandResponse("CMD:Input Report: {0}\r\n", MakePrintable(_UsbHid.Input_Report));
            CrestronConsole.ConsoleCommandResponse("CMD:Manufacturer: {0}\r\n", _UsbHid.Manufacturer);
            CrestronConsole.ConsoleCommandResponse("CMD:Product: {0}\r\n", _UsbHid.Product);
            CrestronConsole.ConsoleCommandResponse("CMD:Report Descriptor: {0}\r\n", MakePrintable(_UsbHid.Report_Descriptor));
            CrestronConsole.ConsoleCommandResponse("CMD:Serial Number: {0}\r\n", _UsbHid.Serial_Number);
            CrestronConsole.ConsoleCommandResponse("CMD:Offline State: {0}\r\n", _UsbHid.offline);
        }
        void OutputReport(string message)
        {
            string MessageHelp = "TOutputReport" + _UsbHid.Name + " message";
            var commands = Regex.Matches(message, "[0-9A-F\\:]+");
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
                CrestronConsole.ConsoleCommandResponse("CMD:Sending Output Report Data: {0} through USB", Message);
                _UsbHid.Output_Report(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void FeatureReport(string message)
        {
            string MessageHelp = "TFeatureReport" + _UsbHid.Name + " message";
            var commands = Regex.Matches(message, "[0-9A-F\\:]+");
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
                CrestronConsole.ConsoleCommandResponse("CMD:Sending Feature Report Data: {0} through USB", Message);
                _UsbHid.Feature_Report(Message);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}