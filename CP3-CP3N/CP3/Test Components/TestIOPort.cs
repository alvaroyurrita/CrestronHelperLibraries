using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using IOPorts;

namespace CP3_CP3N.Test_Components
{
    public class TestIOPort
    {
        private IOPort _IOPort;
        public TestIOPort(IOPort IOPort)
        {
            _IOPort = IOPort;
            Start();

        }
        private void Start()
        {
            _IOPort.AnalogInput_Changed += (port, value) => { CrestronConsole.PrintLine("Port {2}: Analog Input Changed: {0}, {1}", value, _IOPort.AnalogInput, port.Number); };
            _IOPort.DigitalOutput_Changed += (port, value) => { CrestronConsole.PrintLine("Port {2}: Analog Output Changed: {0}, {1}", value, _IOPort.DigitalOutput, port.Number); };
            _IOPort.PullUpResistorDisabled_Changed += (port, value) => { CrestronConsole.PrintLine("Port {2}: PU-Disabled Changed: {0}, {1}", value, _IOPort.PullUpResistorDisabled, port.Number); };
            _IOPort.MinimumVoltageChange_Changed += (port, value) => { CrestronConsole.PrintLine("Port {2}: MinChange: {0}, {1}", value, _IOPort.MinimumVoltageChange, port.Number); };
            _IOPort.DigitalInput_Changed += (port, value) => { CrestronConsole.PrintLine("Port {2}: Digital Input Changed: {0}, {1}", value, _IOPort.DigitalInput, port.Number); };
            _IOPort.Configuration_Changed += (port, value) => { CrestronConsole.PrintLine("Port {2}: Configuration Changed: {0}, {1}", value.ToString(), _IOPort.Configuration.ToString(), port.Number); };

            CrestronConsole.AddNewConsoleCommand(SetDigitalOutput, "TSetDigOut" + _IOPort.Name, "Set/Reset A Versiport Output", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(PUDisable, "TPUDisable" + _IOPort.Name, "Set/Reset A Pull Up Resistor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MinChange, "TMinChange" + _IOPort.Name, "Set/Reset A MinChange", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetConfiguration, "TSetConf" + _IOPort.Name, "Changes Configuration", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetResistor, "TSetRes" + _IOPort.Name, "Sets External Resistor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetAnalogScale, "TAnalogScale" + _IOPort.Name, "Sets the Analog Scale of A Versiport", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetIOPortProps, "TGetProps" + _IOPort.Name, "Get All Properties", ConsoleAccessLevelEnum.AccessOperator);
        }
        public void GetIOPortProps(string message)
        {
            CrestronConsole.ConsoleCommandResponse("IOPORT: AnalogInput    {0}\r\n", (_IOPort.AnalogInput != null)?_IOPort.AnalogInput.ToString():"Not Configured");
            CrestronConsole.ConsoleCommandResponse("IOPORT: Configuration    {0}\r\n", _IOPort.Configuration.ToString());
            CrestronConsole.ConsoleCommandResponse("IOPORT: DigitalInput    {0}\r\n", (_IOPort.DigitalInput != null) ? _IOPort.DigitalInput.ToString() : "Not Configured");
            CrestronConsole.ConsoleCommandResponse("IOPORT: DigitalOutput    {0}\r\n", (_IOPort.DigitalOutput != null) ? _IOPort.DigitalOutput.ToString() : "Not Configured");
            CrestronConsole.ConsoleCommandResponse("IOPORT: DisablePullUpResistor    {0}\r\n", (_IOPort.PullUpResistorDisabled != null) ? _IOPort.PullUpResistorDisabled.ToString() : "Not Configured");
            CrestronConsole.ConsoleCommandResponse("IOPORT: Name    {0}\r\n", _IOPort.Name);
            CrestronConsole.ConsoleCommandResponse("IOPORT: MinimumVoltageChange    {0}\r\n", (_IOPort.MinimumVoltageChange != null) ? _IOPort.MinimumVoltageChange.ToString() : "Not Configured");
            CrestronConsole.ConsoleCommandResponse("IOPORT: Resistor    {0}\r\n", _IOPort.Resistor);
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
        void SetDigitalOutput(string State) 
        {
            if (State.ToUpper() == "ON") _IOPort.DigitalOutput = true;
            else if (State.ToUpper() == "OFF") _IOPort.DigitalOutput = false ;
            else { CrestronConsole.ConsoleCommandResponse("TSetDigOut" + _IOPort.Name + " [ON|OFF]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Output to {0}...\n", State); 
        }
        void PUDisable(string State)
        {
            if (State.ToUpper() == "ON") _IOPort.PullUpResistorDisabled = true;
            else if (State.ToUpper() == "OFF") _IOPort.PullUpResistorDisabled = false;
            else { CrestronConsole.ConsoleCommandResponse("TPUDisable" + _IOPort.Name + " [ON|OFF]"); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Output to {0}...\n", State);
        }
        void SetResistor(string Value)
        {
            string MessageHelp = "TSetResistor" + _IOPort.Name + " value (0 to 65535)";
            double value = GetFirstParameterInteger(Value, MessageHelp);
            if (value >= 0 && value <= 65535)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Setting Resistor to {0}", value);
                _IOPort.Resistor = ((ushort)value);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void MinChange(string Value)
        {
            string MessageHelp = "TMinChange" + _IOPort.Name + " value (10 to 65535)";
            double value = GetFirstParameterInteger(Value, MessageHelp);
            if (value >= 0 && value <= 65535)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Setting Min Change to {0}", value);
                _IOPort.MinimumVoltageChange = ((ushort)value);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
        void SetAnalogScale(string State)
        {
            string MessageHelp = "TAnalogScale" + _IOPort.Name + " [0|1|2]";
            eAnalogOutputScale value = (eAnalogOutputScale)GetFirstParameterInteger(State, MessageHelp);
            if ((int)value < 0 || (int)value > 2) { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            _IOPort.AnalogOutputScale = value;
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Minimum Change for Port {0} to {1}...\r\n", _IOPort.Number, value);
        }
        void SetConfiguration(string value)
        {
            string MessageHelp = "TSetConf" + _IOPort.Name + " [0|1|2|3]";
            int mode = GetFirstParameterInteger(value, MessageHelp);
            if (mode>=0 && mode <=3)
            {
                CrestronConsole.ConsoleCommandResponse("CMD:Changing IOPort Configuration to {0}", ((eVersiportConfiguration)mode).ToString());
                _IOPort.Configuration = ((eVersiportConfiguration)mode);
            }
            else CrestronConsole.ConsoleCommandResponse(MessageHelp);
        }
    }
}