using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Endpoints.Transmitters;
using Serial_Drivers;
using CECDevices;

namespace DMTransmitters
{
    public class DM_TX_4K_100_C_1G
    {
        DmTx4K100C1G _DmTx4K100C1G;
        public IROutputPort IR;
        public RS232OnlyTwoWaySerialDriver Com01;
        public CECDevice HDMI_In;
        public string Name { get; private set; }


        public DM_TX_4K_100_C_1G(ICardInputOutputType SwitcherInput)
        {
            DMInput _DMInput = SwitcherInput as DMInput;
            _DmTx4K100C1G = new DmTx4K100C1G(_DMInput);
            IR = _DmTx4K100C1G.IROutputPorts[1];
            Com01 = new RS232OnlyTwoWaySerialDriver(_DmTx4K100C1G.ComPorts[1]);
            HDMI_In = new CECDevice(_DmTx4K100C1G.StreamCec);
            Name = _DmTx4K100C1G.Name;
        }
    }
}

