using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace IOPorts
{
    public class DigitalInputs2Card
    {
        public event Action<bool> I1_F_Changed;
        public bool I1_F { get { return GetDigitalInState(1); } }
        public event Action<bool> I2_F_Changed;
        public bool I2_F { get { return GetDigitalInState(2); } }

        bool GetDigitalInState(int Index) { return DigitalInputPorts[Index - 1].State; }

        private static DigitalInputs2Card _Slot2DigitalInputs;
        private static List<DigitalInputPort> DigitalInputPorts = new List<DigitalInputPort>();

        private static CrestronCollection<DigitalInput> _CrestronDigitalInputPorts;

        public static DigitalInputs2Card GetSlot2DigitalInputs(CrestronCollection<DigitalInput> DigitalInputs)
        {
            if (DigitalInputs.Count != 2) return null;
            return _Slot2DigitalInputs ?? (_Slot2DigitalInputs = new DigitalInputs2Card(DigitalInputs));
        }

        private DigitalInputs2Card(CrestronCollection<DigitalInput> DigitalInputs)
        {
            _CrestronDigitalInputPorts = DigitalInputs;
            CreateDigitalInputPorts();
            SubscribeDigitalInputPortStateChanged();
        }

        void SubscribeDigitalInputPortStateChanged()
        {
            DigitalInputPorts[0].State_Changed += (port, state) => { if (I1_F_Changed != null) I1_F_Changed(state); };
            DigitalInputPorts[1].State_Changed += (port, state) => { if (I2_F_Changed != null) I2_F_Changed(state); };
        }

        void CreateDigitalInputPorts()
        {
            foreach (DigitalInput DI in _CrestronDigitalInputPorts)
            {
                DigitalInputPorts.Add(new DigitalInputPort(DI));
            }
        }
    }
}