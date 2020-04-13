using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using IOPorts;

namespace CP3_CP3N.Test_Components
{
    public static class TestC2ICP3IO8
    {
        private static IOs8AnalogInputCard _IO8AnalogInputCard;
        public static void Start(IOs8AnalogInputCard IO8AnalogInputCard)
        {

            _IO8AnalogInputCard = IO8AnalogInputCard;

            _IO8AnalogInputCard.ai1_Changed += value => { CrestronConsole.PrintLine("Versioport 1: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai1); };
            _IO8AnalogInputCard.di1_Changed += value => { CrestronConsole.PrintLine("Versioport 1: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di1); };
            _IO8AnalogInputCard.o1_F_Changed += value => { CrestronConsole.PrintLine("Versioport 1: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o1_F); };
            _IO8AnalogInputCard.pu_disable1_F_Changed += value => { CrestronConsole.PrintLine("Versioport 1: PU-Disable1 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable1_F); };
            _IO8AnalogInputCard.MinChange1_F_Changed += value => { CrestronConsole.PrintLine("Versioport 1: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange1_F); };

            _IO8AnalogInputCard.ai2_Changed += value => { CrestronConsole.PrintLine("Versioport 2: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai2); };
            _IO8AnalogInputCard.di2_Changed += value => { CrestronConsole.PrintLine("Versioport 2: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di2); };
            _IO8AnalogInputCard.o2_F_Changed += value => { CrestronConsole.PrintLine("Versioport 2: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o2_F); };
            _IO8AnalogInputCard.pu_disable2_F_Changed += value => { CrestronConsole.PrintLine("Versioport 2: PU-Disable2 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable2_F); };
            _IO8AnalogInputCard.MinChange2_F_Changed += value => { CrestronConsole.PrintLine("Versioport 2: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange2_F); };

            _IO8AnalogInputCard.ai3_Changed += value => { CrestronConsole.PrintLine("Versioport 3: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai3); };
            _IO8AnalogInputCard.di3_Changed += value => { CrestronConsole.PrintLine("Versioport 3: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di3); };
            _IO8AnalogInputCard.o3_F_Changed += value => { CrestronConsole.PrintLine("Versioport 3: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o3_F); };
            _IO8AnalogInputCard.pu_disable3_F_Changed += value => { CrestronConsole.PrintLine("Versioport 3: PU-Disable3 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable3_F); };
            _IO8AnalogInputCard.MinChange3_F_Changed += value => { CrestronConsole.PrintLine("Versioport 3: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange3_F); };

            _IO8AnalogInputCard.ai4_Changed += value => { CrestronConsole.PrintLine("Versioport 4: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai4); };
            _IO8AnalogInputCard.di4_Changed += value => { CrestronConsole.PrintLine("Versioport 4: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di4); };
            _IO8AnalogInputCard.o4_F_Changed += value => { CrestronConsole.PrintLine("Versioport 4: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o4_F); };
            _IO8AnalogInputCard.pu_disable4_F_Changed += value => { CrestronConsole.PrintLine("Versioport 4: PU-Disable4 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable4_F); };
            _IO8AnalogInputCard.MinChange4_F_Changed += value => { CrestronConsole.PrintLine("Versioport 4: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange4_F); };

            _IO8AnalogInputCard.ai5_Changed += value => { CrestronConsole.PrintLine("Versioport 5: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai5); };
            _IO8AnalogInputCard.di5_Changed += value => { CrestronConsole.PrintLine("Versioport 5: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di5); };
            _IO8AnalogInputCard.o5_F_Changed += value => { CrestronConsole.PrintLine("Versioport 5: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o5_F); };
            _IO8AnalogInputCard.pu_disable5_F_Changed += value => { CrestronConsole.PrintLine("Versioport 5: PU-Disable5 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable5_F); };
            _IO8AnalogInputCard.MinChange5_F_Changed += value => { CrestronConsole.PrintLine("Versioport 5: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange5_F); };

            _IO8AnalogInputCard.ai6_Changed += value => { CrestronConsole.PrintLine("Versioport 6: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai6); };
            _IO8AnalogInputCard.di6_Changed += value => { CrestronConsole.PrintLine("Versioport 6: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di6); };
            _IO8AnalogInputCard.o6_F_Changed += value => { CrestronConsole.PrintLine("Versioport 6: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o6_F); };
            _IO8AnalogInputCard.pu_disable6_F_Changed += value => { CrestronConsole.PrintLine("Versioport 6: PU-Disable6 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable6_F); };
            _IO8AnalogInputCard.MinChange6_F_Changed += value => { CrestronConsole.PrintLine("Versioport 6: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange6_F); };

            _IO8AnalogInputCard.ai7_Changed += value => { CrestronConsole.PrintLine("Versioport 7: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai7); };
            _IO8AnalogInputCard.di7_Changed += value => { CrestronConsole.PrintLine("Versioport 7: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di7); };
            _IO8AnalogInputCard.o7_F_Changed += value => { CrestronConsole.PrintLine("Versioport 7: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o7_F); };
            _IO8AnalogInputCard.pu_disable7_F_Changed += value => { CrestronConsole.PrintLine("Versioport 7: PU-Disable7 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable7_F); };
            _IO8AnalogInputCard.MinChange7_F_Changed += value => { CrestronConsole.PrintLine("Versioport 7: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange7_F); };

            _IO8AnalogInputCard.ai8_Changed += value => { CrestronConsole.PrintLine("Versioport 8: Analog Input Changed: {0}, {1}", value, _IO8AnalogInputCard.ai8); };
            _IO8AnalogInputCard.di8_Changed += value => { CrestronConsole.PrintLine("Versioport 8: Digital Input Changed: {0}, {1}", value, _IO8AnalogInputCard.di8); };
            _IO8AnalogInputCard.o8_F_Changed += value => { CrestronConsole.PrintLine("Versioport 8: Digital Output Changed: {0}, {1}", value, _IO8AnalogInputCard.o8_F); };
            _IO8AnalogInputCard.pu_disable8_F_Changed += value => { CrestronConsole.PrintLine("Versioport 8: PU-Disable8 Changed: {0}, {1}", value, _IO8AnalogInputCard.pu_disable8_F); };
            _IO8AnalogInputCard.MinChange8_F_Changed += value => { CrestronConsole.PrintLine("Versioport 8: MinChange: {0}, {1}", value, _IO8AnalogInputCard.MinChange8_F); };


            CrestronConsole.AddNewConsoleCommand(SetOutput, "TSetOutput", "Set/Reset A Versiport Output", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(PUDisable, "TPUDisable", "Set/Reset A Pull Up Resistor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(MinChange, "TMinChange", "Set/Reset A MinChange", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetConfiguration, "TSetConf", "Sets the versiport configuration", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetResistor, "TSetResistor", "Sets the value of the External Resistor", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(GetProps, "TGetProps", "Gets the Properties of A Versiport", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(SetAnalogScale, "TAnalogScale", "Sets the Analog Scale of A Versiport", ConsoleAccessLevelEnum.AccessOperator);

        }
        static int GetFirstParameterInteger(string value, string MessageHelp)
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
        static int GetSecondParameterInteger(string value, string MessageHelp)
        {
            var commands = value.Split(' ');
            int Result;
            try
            {
                Result = int.Parse(commands[1]);
            }
            catch (Exception)
            {
                CrestronConsole.ConsoleCommandResponse(MessageHelp);
                return 0xfff;
            }
            return Result;
        }
        static string GetSecondParameter(string value)
        {
            var commands = value.Split(' ');
            return commands[1].ToUpper();
        }
        public static void SetOutput(string State) 
        {
            string MessageHelp = "TSetOutput {Port[1..8]} [On|Off]";
            int port = GetFirstParameterInteger(State, MessageHelp);
            bool state = GetSecondParameter(State)=="ON"?true:false;
            if (port>=1 && port<=8)
            {
                switch (port)
                {
                    case 1:
                        _IO8AnalogInputCard.o1 = state;
                        break;
                    case 2:
                        _IO8AnalogInputCard.o2 = state;
                        break;
                    case 3:
                        _IO8AnalogInputCard.o3 = state;
                        break;
                    case 4:
                        _IO8AnalogInputCard.o4 = state;
                        break;
                    case 5:
                        _IO8AnalogInputCard.o5 = state;
                        break;
                    case 6:
                        _IO8AnalogInputCard.o6 = state;
                        break;
                    case 7:
                        _IO8AnalogInputCard.o7 = state;
                        break;
                    case 8:
                        _IO8AnalogInputCard.o8 = state;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Versiport {0} to {1}...\r\n", port, state); 
        }
        public static void PUDisable(string State)
        {
            string MessageHelp = "TPUDisable {Port[1..8]} [On|Off]";
            int port = GetFirstParameterInteger(State, MessageHelp);
            bool state = GetSecondParameter(State) == "ON" ? true : false;
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        _IO8AnalogInputCard.pu_disable1 = state;
                        break;
                    case 2:
                        _IO8AnalogInputCard.pu_disable2 = state;
                        break;
                    case 3:
                        _IO8AnalogInputCard.pu_disable3 = state;
                        break;
                    case 4:
                        _IO8AnalogInputCard.pu_disable4 = state;
                        break;
                    case 5:
                        _IO8AnalogInputCard.pu_disable5 = state;
                        break;
                    case 6:
                        _IO8AnalogInputCard.pu_disable6 = state;
                        break;
                    case 7:
                        _IO8AnalogInputCard.pu_disable7 = state;
                        break;
                    case 8:
                        _IO8AnalogInputCard.pu_disable8 = state;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing PullUp Resistor {0} to {1}...\r\n", port, state); 
        }
        static void MinChange(string State)
        {
            string MessageHelp = "TMinChange {Port[1..8]} value";
            int port = GetFirstParameterInteger(State, MessageHelp);
            ushort value = (ushort)GetSecondParameterInteger(State, MessageHelp) ;
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        _IO8AnalogInputCard.MinChange1 = value;
                        break;
                    case 2:
                        _IO8AnalogInputCard.MinChange2 = value;
                        break;
                    case 3:
                        _IO8AnalogInputCard.MinChange3 = value;
                        break;
                    case 4:
                        _IO8AnalogInputCard.MinChange4 = value;
                        break;
                    case 5:
                        _IO8AnalogInputCard.MinChange5 = value;
                        break;
                    case 6:
                        _IO8AnalogInputCard.MinChange6 = value;
                        break;
                    case 7:
                        _IO8AnalogInputCard.MinChange7 = value;
                        break;
                    case 8:
                        _IO8AnalogInputCard.MinChange8 = value;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Minimum Change for Port {0} to {1}...\r\n", port, value); 
        }
        static void SetResistor(string State)
        {
            string MessageHelp = "TSetResistor {Port[1..8]} value";
            int port = GetFirstParameterInteger(State, MessageHelp);
            ushort value = (ushort)GetSecondParameterInteger(State, MessageHelp);
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        _IO8AnalogInputCard.Resistor1 = value;
                        break;
                    case 2:
                        _IO8AnalogInputCard.Resistor2 = value;
                        break;
                    case 3:
                        _IO8AnalogInputCard.Resistor3 = value;
                        break;
                    case 4:
                        _IO8AnalogInputCard.Resistor4 = value;
                        break;
                    case 5:
                        _IO8AnalogInputCard.Resistor5 = value;
                        break;
                    case 6:
                        _IO8AnalogInputCard.Resistor6 = value;
                        break;
                    case 7:
                        _IO8AnalogInputCard.Resistor7 = value;
                        break;
                    case 8:
                        _IO8AnalogInputCard.Resistor8 = value;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Minimum Change for Port {0} to {1}...\r\n", port, value);
        }
        static void SetConfiguration(string State)
        {
            string MessageHelp = "TSetConf {Port[1..8]} [0|1|2|3]";
            int port = GetFirstParameterInteger(State, MessageHelp);
            eVersiportConfiguration value = (eVersiportConfiguration)GetSecondParameterInteger(State, MessageHelp);
            if ((int)value < 0 || (int)value > 3) { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        _IO8AnalogInputCard.Configuration1 = value;
                        break;
                    case 2:
                        _IO8AnalogInputCard.Configuration2 = value;
                        break;
                    case 3:
                        _IO8AnalogInputCard.Configuration3 = value;
                        break;
                    case 4:
                        _IO8AnalogInputCard.Configuration4 = value;
                        break;
                    case 5:
                        _IO8AnalogInputCard.Configuration5 = value;
                        break;
                    case 6:
                        _IO8AnalogInputCard.Configuration6 = value;
                        break;
                    case 7:
                        _IO8AnalogInputCard.Configuration7 = value;
                        break;
                    case 8:
                        _IO8AnalogInputCard.Configuration8 = value;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Configuration for Port {0} to {1}...\r\n", port, value);
        }
        public static void GetProps(string State)
        {
            string MessageHelp = "TSetOutput {Port[1..8]} [On|Off]";
            int port = GetFirstParameterInteger(State, MessageHelp);
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        CrestronConsole.PrintLine("Port 1. Analog Input {0}", _IO8AnalogInputCard.ai1);
                        CrestronConsole.PrintLine("Port 1. Configuration {0}", _IO8AnalogInputCard.Configuration1.ToString());
                        CrestronConsole.PrintLine("Port 1. Digital In {0}", _IO8AnalogInputCard.di1);
                        CrestronConsole.PrintLine("Port 1. Minimum Change {0}", _IO8AnalogInputCard.MinChange1_F);
                        CrestronConsole.PrintLine("Port 1. Digital Out {0}", _IO8AnalogInputCard.o1_F);
                        CrestronConsole.PrintLine("Port 1. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable1_F);
                        CrestronConsole.PrintLine("Port 1. External Resistor {0}", _IO8AnalogInputCard.Resistor1);
                        CrestronConsole.PrintLine("Port 1. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale1);
                        break;
                    case 2:
                        CrestronConsole.PrintLine("Port 2. Analog Input {0}", _IO8AnalogInputCard.ai2);
                        CrestronConsole.PrintLine("Port 2. Configuration {0}", _IO8AnalogInputCard.Configuration2.ToString());
                        CrestronConsole.PrintLine("Port 2. Digital In {0}", _IO8AnalogInputCard.di2);
                        CrestronConsole.PrintLine("Port 2. Minimum Change {0}", _IO8AnalogInputCard.MinChange2_F);
                        CrestronConsole.PrintLine("Port 2. Digital Out {0}", _IO8AnalogInputCard.o2_F);
                        CrestronConsole.PrintLine("Port 2. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable2_F);
                        CrestronConsole.PrintLine("Port 2. External Resistor {0}", _IO8AnalogInputCard.Resistor2);
                        CrestronConsole.PrintLine("Port 2. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale2);
                        break;
                    case 3:
                        CrestronConsole.PrintLine("Port 3. Analog Input {0}", _IO8AnalogInputCard.ai3);
                        CrestronConsole.PrintLine("Port 3. Configuration {0}", _IO8AnalogInputCard.Configuration3.ToString());
                        CrestronConsole.PrintLine("Port 3. Digital In {0}", _IO8AnalogInputCard.di3);
                        CrestronConsole.PrintLine("Port 3. Minimum Change {0}", _IO8AnalogInputCard.MinChange3_F);
                        CrestronConsole.PrintLine("Port 3. Digital Out {0}", _IO8AnalogInputCard.o3_F);
                        CrestronConsole.PrintLine("Port 3. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable3_F);
                        CrestronConsole.PrintLine("Port 3. External Resistor {0}", _IO8AnalogInputCard.Resistor3);
                        CrestronConsole.PrintLine("Port 3. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale3);
                        break;
                    case 4:
                        CrestronConsole.PrintLine("Port 4. Analog Input {0}", _IO8AnalogInputCard.ai4);
                        CrestronConsole.PrintLine("Port 4. Configuration {0}", _IO8AnalogInputCard.Configuration4.ToString());
                        CrestronConsole.PrintLine("Port 4. Digital In {0}", _IO8AnalogInputCard.di4);
                        CrestronConsole.PrintLine("Port 4. Minimum Change {0}", _IO8AnalogInputCard.MinChange4_F);
                        CrestronConsole.PrintLine("Port 4. Digital Out {0}", _IO8AnalogInputCard.o4_F);
                        CrestronConsole.PrintLine("Port 4. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable4_F);
                        CrestronConsole.PrintLine("Port 4. External Resistor {0}", _IO8AnalogInputCard.Resistor4);
                        CrestronConsole.PrintLine("Port 4. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale4);
                        break;
                    case 5:
                        CrestronConsole.PrintLine("Port 5. Analog Input {0}", _IO8AnalogInputCard.ai5);
                        CrestronConsole.PrintLine("Port 5. Configuration {0}", _IO8AnalogInputCard.Configuration5.ToString());
                        CrestronConsole.PrintLine("Port 5. Digital In {0}", _IO8AnalogInputCard.di5);
                        CrestronConsole.PrintLine("Port 5. Minimum Change {0}", _IO8AnalogInputCard.MinChange5_F);
                        CrestronConsole.PrintLine("Port 5. Digital Out {0}", _IO8AnalogInputCard.o5_F);
                        CrestronConsole.PrintLine("Port 5. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable5_F);
                        CrestronConsole.PrintLine("Port 5. External Resistor {0}", _IO8AnalogInputCard.Resistor5);
                        CrestronConsole.PrintLine("Port 5. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale5);
                        break;
                    case 6:
                        CrestronConsole.PrintLine("Port 6. Analog Input {0}", _IO8AnalogInputCard.ai6);
                        CrestronConsole.PrintLine("Port 6. Configuration {0}", _IO8AnalogInputCard.Configuration6.ToString());
                        CrestronConsole.PrintLine("Port 6. Digital In {0}", _IO8AnalogInputCard.di6);
                        CrestronConsole.PrintLine("Port 6. Minimum Change {0}", _IO8AnalogInputCard.MinChange6_F);
                        CrestronConsole.PrintLine("Port 6. Digital Out {0}", _IO8AnalogInputCard.o6_F);
                        CrestronConsole.PrintLine("Port 6. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable6_F);
                        CrestronConsole.PrintLine("Port 6. External Resistor {0}", _IO8AnalogInputCard.Resistor6);
                        CrestronConsole.PrintLine("Port 6. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale6);
                        break;
                    case 7:
                        CrestronConsole.PrintLine("Port 7. Analog Input {0}", _IO8AnalogInputCard.ai7);
                        CrestronConsole.PrintLine("Port 7. Configuration {0}", _IO8AnalogInputCard.Configuration7.ToString());
                        CrestronConsole.PrintLine("Port 7. Digital In {0}", _IO8AnalogInputCard.di7);
                        CrestronConsole.PrintLine("Port 7. Minimum Change {0}", _IO8AnalogInputCard.MinChange7_F);
                        CrestronConsole.PrintLine("Port 7. Digital Out {0}", _IO8AnalogInputCard.o7_F);
                        CrestronConsole.PrintLine("Port 7. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable7_F);
                        CrestronConsole.PrintLine("Port 7. External Resistor {0}", _IO8AnalogInputCard.Resistor7);
                        CrestronConsole.PrintLine("Port 7. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale7);
                        break;
                    case 8:
                        CrestronConsole.PrintLine("Port 8. Analog Input {0}", _IO8AnalogInputCard.ai8);
                        CrestronConsole.PrintLine("Port 8. Configuration {0}", _IO8AnalogInputCard.Configuration8.ToString());
                        CrestronConsole.PrintLine("Port 8. Digital In {0}", _IO8AnalogInputCard.di8);
                        CrestronConsole.PrintLine("Port 8. Minimum Change {0}", _IO8AnalogInputCard.MinChange8_F);
                        CrestronConsole.PrintLine("Port 8. Digital Out {0}", _IO8AnalogInputCard.o8_F);
                        CrestronConsole.PrintLine("Port 8. Pull Up Resistor State {0}", _IO8AnalogInputCard.pu_disable8_F);
                        CrestronConsole.PrintLine("Port 8. External Resistor {0}", _IO8AnalogInputCard.Resistor8);
                        CrestronConsole.PrintLine("Port 8. Analog Output Scale {0}", _IO8AnalogInputCard.AnalogOutputScale8);
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
        }
        static void SetAnalogScale(string State)
        {
            string MessageHelp = "TAnalogScale {Port[1..8]} [0|1|2]";
            int port = GetFirstParameterInteger(State, MessageHelp);
            eAnalogOutputScale value = (eAnalogOutputScale)GetSecondParameterInteger(State, MessageHelp);
            if ((int)value < 0 || (int)value > 2) { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            if (port >= 1 && port <= 8)
            {
                switch (port)
                {
                    case 1:
                        _IO8AnalogInputCard.AnalogOutputScale1 = value;
                        break;
                    case 2:
                        _IO8AnalogInputCard.AnalogOutputScale2 = value;
                        break;
                    case 3:
                        _IO8AnalogInputCard.AnalogOutputScale3 = value;
                        break;
                    case 4:
                        _IO8AnalogInputCard.AnalogOutputScale4 = value;
                        break;
                    case 5:
                        _IO8AnalogInputCard.AnalogOutputScale5 = value;
                        break;
                    case 6:
                        _IO8AnalogInputCard.AnalogOutputScale6 = value;
                        break;
                    case 7:
                        _IO8AnalogInputCard.AnalogOutputScale7 = value;
                        break;
                    case 8:
                        _IO8AnalogInputCard.AnalogOutputScale8 = value;
                        break;
                    default:
                        break;
                }
            }
            else { CrestronConsole.ConsoleCommandResponse(MessageHelp); return; }
            CrestronConsole.ConsoleCommandResponse("CMD:Changing Minimum Change for Port {0} to {1}...\r\n", port, value);
        }
    }
}