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
    public class DM_RMC_4KZ_100_C
    {
        DmRmc4kz100C _DmRmc4kz100C;
        public IROutputPort C2I_DMRMC100_4KZ_IR2;
        public DMPS3TwoWaySerialDriver Com01;
        public CECDevice CEC_DM_In;
        public CECDevice CEC_HDMI_Out;
        public HDMIOutputHDCP HDCP_HDMI_Out;
        public string Name { get; private set; }


        public DM_RMC_4KZ_100_C(ICardInputOutputType SwitcherOutput)
        {
            DMOutput _DMOutput = SwitcherOutput as DMOutput;
            _DmRmc4kz100C = new DmRmc4kz100C(_DMOutput);
            C2I_DMRMC100_4KZ_IR2 = _DmRmc4kz100C.IROutputPorts[1];
            Com01 = new DMPS3TwoWaySerialDriver(_DmRmc4kz100C.ComPorts[1]);
            CEC_DM_In = new CECDevice(_DmRmc4kz100C.DmInputStreamCec);
            CEC_HDMI_Out = new CECDevice(_DmRmc4kz100C.HdmiOutput.StreamCec);
            HDCP_HDMI_Out = new HDMIOutputHDCP(_DmRmc4kz100C.HdmiOutput);
        }

    }
}

