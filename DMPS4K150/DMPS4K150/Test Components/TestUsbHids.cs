using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Text.RegularExpressions;
using USBPorts;


namespace DMPS4K150.Test_Components
{

    public class TestUsbHids
    {
        private USBPort _UsbHid;
        public TestUsbHids(USBPort UsbHid)
        {
            _UsbHid = UsbHid;
            Start();
        }
        private void Start()
        {
            _UsbHid.Country_Code_Changed += (Code) => { CrestronConsole.PrintLine("{2} Aspcet Ratio State: {0}, {1}", Code.ToString(), _UsbHid.Country_Code.ToString(), _UsbHid.Name); };
            _UsbHid.Feature_Report_F_Changed += (message) => { CrestronConsole.PrintLine("{2} Audio Channels Value: {0}, {1}", message, _UsbHid.Feature_Report_F, _UsbHid.Name); };
            _UsbHid.Input_Report_Changed += (message) => { CrestronConsole.PrintLine("{2} Audio Format: {0}, {1}", message, _UsbHid.Input_Report, _UsbHid.Name); };
            _UsbHid.Manufacturer_Changed += (message) => { CrestronConsole.PrintLine("{2} Audio Gain Value: {0}, {1}", message, _UsbHid.Manufacturer, _UsbHid.Name); };
            _UsbHid.Product_Changed += (message) => { CrestronConsole.PrintLine("{2} Audo Source Detected State: {0}, {1}", message, _UsbHid.Product, _UsbHid.Name); };
            _UsbHid.Report_Descriptor_Changed += (message) => { CrestronConsole.PrintLine("{2} Endpoint Online State: {0}, {1}", message, _UsbHid.Report_Descriptor, _UsbHid.Name); };
            _UsbHid.Serial_Number_Changed += (message) => { CrestronConsole.PrintLine("{2} HDCP Active State: {0}, {1}", message, _UsbHid.Serial_Number, _UsbHid.Name); };

            CrestronConsole.AddNewConsoleCommand(OutputReport, "TOutputReport" + _UsbHid.Name, "Output Report Data for " + _UsbHid.Name, ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(FeatureReport, "TFeatureReport" + _UsbHid.Name, "Feature Report Data for" + _UsbHid.Name, ConsoleAccessLevelEnum.AccessOperator);
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