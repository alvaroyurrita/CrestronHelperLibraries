using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Endpoints.Receivers;
using Serial_Drivers;
using CECDevices;
using HDCPSupport;

namespace DMReceivers
{
    public class DM_RMC_4K_100_C_1G
    {
        DmRmc4K100C1G _DmRmc4K100C1G;
        public IROutputPort IR;
        public RS232OnlyTwoWaySerialDriver Com01;
        public CECDevice HDMI_Out;
        public string Name { get; private set; }


        public DM_RMC_4K_100_C_1G(ICardInputOutputType SwitcherOutput)
        {
            DMOutput _DMOutput = SwitcherOutput as DMOutput;
            _DmRmc4K100C1G = new DmRmc4K100C1G(_DMOutput);
            IR = _DmRmc4K100C1G.IROutputPorts[1];
            Com01 = new RS232OnlyTwoWaySerialDriver(_DmRmc4K100C1G.ComPorts[1]);
            HDMI_Out = new CECDevice(_DmRmc4K100C1G.StreamCec);
            Name = _DmRmc4K100C1G.Name;
        }

    }
}

