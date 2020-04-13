using System;
using System.Collections.Generic;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace IOPorts
{
    public class IOs8AnalogInputCard
    {
        #region public properties and events
        #region Versiport1
        public event Action<bool> o1_F_Changed;
        public event Action<bool> pu_disable1_F_Changed;
        public event Action<ushort> MinChange1_F_Changed;
        public event Action<double> ai1_Changed;
        public event Action<bool> di1_Changed;
        public bool o1 { set { SetDigitalOut(1, value); } }
        public bool o1_F { get { return GetDigitalOut(1); } }
        public bool pu_disable1 { set { SetPUDIsabled(1, value); } }
        public bool pu_disable1_F { get { return GetPUDIsabled(1); } }
        public ushort MinChange1 { set { SetMinChange(1, value); } }
        public ushort MinChange1_F { get { return GetMinChange(1); } }
        public double ai1 { get { return GetAnalogIn(1); } }
        public bool di1 { get { return GetDigitalIn(1); } }
        public double Resistor1 { get { return GetResistor(1); } set { SetResistor(1, value); } }
        public eVersiportConfiguration Configuration1 { get { return GetConfiguration(1); } set { SetConfiguration(1, value); } }
        public eAnalogOutputScale AnalogOutputScale1 { get { return GetAnalogOutputScale(1); } set { SetAnalogOutputScale(1, value); } }
        #endregion

        #region Versiport2
        public event Action<bool> o2_F_Changed;
        public event Action<bool> pu_disable2_F_Changed;
        public event Action<ushort> MinChange2_F_Changed;
        public event Action<double> ai2_Changed;
        public event Action<bool> di2_Changed;
        public bool o2 { set { SetDigitalOut(2, value); } }
        public bool o2_F { get { return GetDigitalOut(2); } }
        public bool pu_disable2 { set { SetPUDIsabled(2, value); } }
        public bool pu_disable2_F { get { return GetPUDIsabled(2); } }
        public ushort MinChange2 { set { SetMinChange(2, value); } }
        public ushort MinChange2_F { get { return GetMinChange(2); } }
        public double ai2 { get { return GetAnalogIn(2); } }
        public bool di2 { get { return GetDigitalIn(2); } }
        public double Resistor2 { get { return GetResistor(2); } set { SetResistor(2, value); } }
        public eVersiportConfiguration Configuration2 { get { return GetConfiguration(2); } set { SetConfiguration(2, value); } }
        public eAnalogOutputScale AnalogOutputScale2 { get { return GetAnalogOutputScale(2); } set { SetAnalogOutputScale(2, value); } }
        #endregion

        #region Versiport3
        public event Action<bool> o3_F_Changed;
        public event Action<bool> pu_disable3_F_Changed;
        public event Action<ushort> MinChange3_F_Changed;
        public event Action<double> ai3_Changed;
        public event Action<bool> di3_Changed;
        public bool o3 { set { SetDigitalOut(3, value); } }
        public bool o3_F { get { return GetDigitalOut(3); } }
        public bool pu_disable3 { set { SetPUDIsabled(3, value); } }
        public bool pu_disable3_F { get { return GetPUDIsabled(3); } }
        public ushort MinChange3 { set { SetMinChange(3, value); } }
        public ushort MinChange3_F { get { return GetMinChange(3); } }
        public double ai3 { get { return GetAnalogIn(3); } }
        public bool di3 { get { return GetDigitalIn(3); } }
        public double Resistor3 { get { return GetResistor(3); } set { SetResistor(3, value); } }
        public eVersiportConfiguration Configuration3 { get { return GetConfiguration(3); } set { SetConfiguration(3, value); } }
        public eAnalogOutputScale AnalogOutputScale3 { get { return GetAnalogOutputScale(3); } set { SetAnalogOutputScale(3, value); } }
        #endregion

        #region Versiport4
        public event Action<bool> o4_F_Changed;
        public event Action<bool> pu_disable4_F_Changed;
        public event Action<ushort> MinChange4_F_Changed;
        public event Action<double> ai4_Changed;
        public event Action<bool> di4_Changed;
        public bool o4 { set { SetDigitalOut(4, value); } }
        public bool o4_F { get { return GetDigitalOut(4); } }
        public bool pu_disable4 { set { SetPUDIsabled(4, value); } }
        public bool pu_disable4_F { get { return GetPUDIsabled(4); } }
        public ushort MinChange4 { set { SetMinChange(4, value); } }
        public ushort MinChange4_F { get { return GetMinChange(4); } }
        public double ai4 { get { return GetAnalogIn(4); } }
        public bool di4 { get { return GetDigitalIn(4); } }
        public double Resistor4 { get { return GetResistor(4); } set { SetResistor(4, value); } }
        public eVersiportConfiguration Configuration4 { get { return GetConfiguration(4); } set { SetConfiguration(4, value); } }
        public eAnalogOutputScale AnalogOutputScale4 { get { return GetAnalogOutputScale(4); } set { SetAnalogOutputScale(4, value); } }
        #endregion

        #region Versiport5
        public event Action<bool> o5_F_Changed;
        public event Action<bool> pu_disable5_F_Changed;
        public event Action<ushort> MinChange5_F_Changed;
        public event Action<double> ai5_Changed;
        public event Action<bool> di5_Changed;
        public bool o5 { set { SetDigitalOut(5, value); } }
        public bool o5_F { get { return GetDigitalOut(5); } }
        public bool pu_disable5 { set { SetPUDIsabled(5, value); } }
        public bool pu_disable5_F { get { return GetPUDIsabled(5); } }
        public ushort MinChange5 { set { SetMinChange(5, value); } }
        public ushort MinChange5_F { get { return GetMinChange(5); } }
        public double ai5 { get { return GetAnalogIn(5); } }
        public bool di5 { get { return GetDigitalIn(5); } }
        public double Resistor5 { get { return GetResistor(5); } set { SetResistor(5, value); } }
        public eVersiportConfiguration Configuration5 { get { return GetConfiguration(5); } set { SetConfiguration(5, value); } }
        public eAnalogOutputScale AnalogOutputScale5 { get { return GetAnalogOutputScale(5); } set { SetAnalogOutputScale(5, value); } }
        #endregion

        #region Versiport6
        public event Action<bool> o6_F_Changed;
        public event Action<bool> pu_disable6_F_Changed;
        public event Action<ushort> MinChange6_F_Changed;
        public event Action<double> ai6_Changed;
        public event Action<bool> di6_Changed;
        public bool o6 { set { SetDigitalOut(6, value); } }
        public bool o6_F { get { return GetDigitalOut(6); } }
        public bool pu_disable6 { set { SetPUDIsabled(6, value); } }
        public bool pu_disable6_F { get { return GetPUDIsabled(6); } }
        public ushort MinChange6 { set { SetMinChange(6, value); } }
        public ushort MinChange6_F { get { return GetMinChange(6); } }
        public double ai6 { get { return GetAnalogIn(6); } }
        public bool di6 { get { return GetDigitalIn(6); } }
        public double Resistor6 { get { return GetResistor(6); } set { SetResistor(6, value); } }
        public eVersiportConfiguration Configuration6 { get { return GetConfiguration(6); } set { SetConfiguration(6, value); } }
        public eAnalogOutputScale AnalogOutputScale6 { get { return GetAnalogOutputScale(6); } set { SetAnalogOutputScale(6, value); } }
        #endregion

        #region Versiport7
        public event Action<bool> o7_F_Changed;
        public event Action<bool> pu_disable7_F_Changed;
        public event Action<ushort> MinChange7_F_Changed;
        public event Action<double> ai7_Changed;
        public event Action<bool> di7_Changed;
        public bool o7 { set { SetDigitalOut(7, value); } }
        public bool o7_F { get { return GetDigitalOut(7); } }
        public bool pu_disable7 { set { SetPUDIsabled(7, value); } }
        public bool pu_disable7_F { get { return GetPUDIsabled(7); } }
        public ushort MinChange7 { set { SetMinChange(7, value); } }
        public ushort MinChange7_F { get { return GetMinChange(7); } }
        public double ai7 { get { return GetAnalogIn(7); } }
        public bool di7 { get { return GetDigitalIn(7); } }
        public double Resistor7 { get { return GetResistor(7); } set { SetResistor(7, value); } }
        public eVersiportConfiguration Configuration7 { get { return GetConfiguration(7); } set { SetConfiguration(7, value); } }
        public eAnalogOutputScale AnalogOutputScale7 { get { return GetAnalogOutputScale(7); } set { SetAnalogOutputScale(7, value); } }
        #endregion

        #region Versiport8
        public event Action<bool> o8_F_Changed;
        public event Action<bool> pu_disable8_F_Changed;
        public event Action<ushort> MinChange8_F_Changed;
        public event Action<double> ai8_Changed;
        public event Action<bool> di8_Changed;
        public bool o8 { set { SetDigitalOut(8, value); } }
        public bool o8_F { get { return GetDigitalOut(8); } }
        public bool pu_disable8 { set { SetPUDIsabled(8, value); } }
        public bool pu_disable8_F { get { return GetPUDIsabled(8); } }
        public ushort MinChange8 { set { SetMinChange(8, value); } }
        public ushort MinChange8_F { get { return GetMinChange(8); } }
        public double ai8 { get { return GetAnalogIn(8); } }
        public bool di8 { get { return GetDigitalIn(8); } }
        public double Resistor8 { get { return GetResistor(8); } set { SetResistor(8, value); } }
        public eVersiportConfiguration Configuration8 { get { return GetConfiguration(8); } set { SetConfiguration(8, value); } }
        public eAnalogOutputScale AnalogOutputScale8 { get { return GetAnalogOutputScale(8); } set { SetAnalogOutputScale(8, value); } }
        #endregion
        #endregion


        #region Private Methods
        void SetDigitalOut(int Index, bool state) { IOPorts[Index - 1].DigitalOutput = state; }
        void SetPUDIsabled(int Index, bool state) { IOPorts[Index - 1].PullUpResistorDisabled = state; }
        void SetMinChange(int Index, ushort value) { IOPorts[Index - 1].MinimumVoltageChange = value; }
        void SetConfiguration(int Index, eVersiportConfiguration Conf) { IOPorts[Index - 1].Configuration = Conf; }
        void SetAnalogOutputScale(int Index, eAnalogOutputScale Conf) { IOPorts[Index - 1].AnalogOutputScale = Conf; }
        void SetResistor(int Index, double value) { IOPorts[Index - 1].Resistor = value; }
        bool GetDigitalIn(int Index) { return IOPorts[Index - 1].DigitalInput??false; }
        bool GetDigitalOut(int Index) { return IOPorts[Index - 1].DigitalOutput ?? false ; }
        bool GetPUDIsabled(int Index) { return IOPorts[Index - 1].PullUpResistorDisabled??false; }
        ushort GetMinChange(int Index) { return IOPorts[Index - 1].MinimumVoltageChange??0; }
        double GetAnalogIn(int Index) { return IOPorts[Index - 1].AnalogInput??0; }
        double GetResistor(int Index) { return IOPorts[Index - 1].Resistor; }
        eAnalogOutputScale GetAnalogOutputScale(int Index) { return IOPorts[Index - 1].AnalogOutputScale; }
        eVersiportConfiguration GetConfiguration(int Index) { return IOPorts[Index - 1].Configuration; }

        #endregion
        
        private static List<IOPort> IOPorts = new List<IOPort>();

        private static CrestronCollection<Versiport> _Versiports;
        private static IOs8AnalogInputCard _IO8AnalogInputCard;

        public static IOs8AnalogInputCard GetIO8AnalogInputCard(CrestronCollection<Versiport> Versiports)
        {
            if (Versiports.Count != 8) return null;
            return _IO8AnalogInputCard ?? (_IO8AnalogInputCard = new IOs8AnalogInputCard(Versiports));
        }

        private IOs8AnalogInputCard(CrestronCollection<Versiport> Versiports)
        {
            _Versiports = Versiports;
            CreateIOPorts();
            SubscribeInDigitalOutChanged();
            SubscribeInPUDisableChanged();
            SubscribeInDigitalInChanged();
            SubscribeInMinChangeChanged();
            SubscribeInAnalogInChanged();
        }

        void SubscribeInDigitalOutChanged()
        {
            IOPorts[0].DigitalOutput_Changed += (port, state) => { if (o1_F_Changed != null) o1_F_Changed(state ?? false); };
            IOPorts[1].DigitalOutput_Changed += (port, state) => { if (o2_F_Changed != null) o2_F_Changed(state ?? false); };
            IOPorts[2].DigitalOutput_Changed += (port, state) => { if (o3_F_Changed != null) o3_F_Changed(state ?? false); };
            IOPorts[3].DigitalOutput_Changed += (port, state) => { if (o4_F_Changed != null) o4_F_Changed(state ?? false); };
            IOPorts[4].DigitalOutput_Changed += (port, state) => { if (o5_F_Changed != null) o5_F_Changed(state ?? false); };
            IOPorts[5].DigitalOutput_Changed += (port, state) => { if (o6_F_Changed != null) o6_F_Changed(state ?? false); };
            IOPorts[6].DigitalOutput_Changed += (port, state) => { if (o7_F_Changed != null) o7_F_Changed(state ?? false); };
            IOPorts[7].DigitalOutput_Changed += (port, state) => { if (o8_F_Changed != null) o8_F_Changed(state ?? false); };

        }

        void SubscribeInPUDisableChanged()
        {
            IOPorts[0].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable1_F_Changed != null) pu_disable1_F_Changed(state ?? false); };
            IOPorts[1].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable2_F_Changed != null) pu_disable2_F_Changed(state ?? false); };
            IOPorts[2].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable3_F_Changed != null) pu_disable3_F_Changed(state ?? false); };
            IOPorts[3].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable4_F_Changed != null) pu_disable4_F_Changed(state ?? false); };
            IOPorts[4].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable5_F_Changed != null) pu_disable5_F_Changed(state ?? false); };
            IOPorts[5].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable6_F_Changed != null) pu_disable6_F_Changed(state ?? false); };
            IOPorts[6].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable7_F_Changed != null) pu_disable7_F_Changed(state ?? false); };
            IOPorts[7].PullUpResistorDisabled_Changed += (port, state) => { if (pu_disable8_F_Changed != null) pu_disable8_F_Changed(state ?? false); };
        }

        void SubscribeInDigitalInChanged()
        {
            IOPorts[0].DigitalInput_Changed += (port, state) => { if (di1_Changed != null) di1_Changed(state??false); };
            IOPorts[1].DigitalInput_Changed += (port, state) => { if (di2_Changed != null) di2_Changed(state ?? false); };
            IOPorts[2].DigitalInput_Changed += (port, state) => { if (di3_Changed != null) di3_Changed(state ?? false); };
            IOPorts[3].DigitalInput_Changed += (port, state) => { if (di4_Changed != null) di4_Changed(state ?? false); };
            IOPorts[4].DigitalInput_Changed += (port, state) => { if (di5_Changed != null) di5_Changed(state ?? false); };
            IOPorts[5].DigitalInput_Changed += (port, state) => { if (di6_Changed != null) di6_Changed(state ?? false); };
            IOPorts[6].DigitalInput_Changed += (port, state) => { if (di7_Changed != null) di7_Changed(state ?? false); };
            IOPorts[7].DigitalInput_Changed += (port, state) => { if (di8_Changed != null) di8_Changed(state ?? false); };
        }

        void SubscribeInMinChangeChanged()
        {
            IOPorts[0].MinimumVoltageChange_Changed += (port, value) => { if (MinChange1_F_Changed != null) MinChange1_F_Changed(value??0); };
            IOPorts[1].MinimumVoltageChange_Changed += (port, value) => { if (MinChange2_F_Changed != null) MinChange2_F_Changed(value ?? 0); };
            IOPorts[2].MinimumVoltageChange_Changed += (port, value) => { if (MinChange3_F_Changed != null) MinChange3_F_Changed(value ?? 0); };
            IOPorts[3].MinimumVoltageChange_Changed += (port, value) => { if (MinChange4_F_Changed != null) MinChange4_F_Changed(value ?? 0); };
            IOPorts[4].MinimumVoltageChange_Changed += (port, value) => { if (MinChange5_F_Changed != null) MinChange5_F_Changed(value ?? 0); };
            IOPorts[5].MinimumVoltageChange_Changed += (port, value) => { if (MinChange6_F_Changed != null) MinChange6_F_Changed(value ?? 0); };
            IOPorts[6].MinimumVoltageChange_Changed += (port, value) => { if (MinChange7_F_Changed != null) MinChange7_F_Changed(value ?? 0); };
            IOPorts[7].MinimumVoltageChange_Changed += (port, value) => { if (MinChange8_F_Changed != null) MinChange8_F_Changed(value ?? 0); };
        }

        void SubscribeInAnalogInChanged()
        {
            IOPorts[0].AnalogInput_Changed += (port, value) => { if (ai1_Changed != null) ai1_Changed(value??0); };
            IOPorts[1].AnalogInput_Changed += (port, value) => { if (ai2_Changed != null) ai2_Changed(value ?? 0); };
            IOPorts[2].AnalogInput_Changed += (port, value) => { if (ai3_Changed != null) ai3_Changed(value ?? 0); };
            IOPorts[3].AnalogInput_Changed += (port, value) => { if (ai4_Changed != null) ai4_Changed(value ?? 0); };
            IOPorts[4].AnalogInput_Changed += (port, value) => { if (ai5_Changed != null) ai5_Changed(value ?? 0); };
            IOPorts[5].AnalogInput_Changed += (port, value) => { if (ai6_Changed != null) ai6_Changed(value ?? 0); };
            IOPorts[6].AnalogInput_Changed += (port, value) => { if (ai7_Changed != null) ai7_Changed(value ?? 0); };
            IOPorts[7].AnalogInput_Changed += (port, value) => { if (ai8_Changed != null) ai8_Changed(value ?? 0); };
        }

        void CreateIOPorts()
        {
            foreach (Versiport VP in _Versiports)
            {
                IOPorts.Add(new IOPort(VP));
            }
        }
    }
}

