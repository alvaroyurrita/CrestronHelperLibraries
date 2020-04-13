using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.DM;
using Crestron.SimplSharpPro.DM.Endpoints.Receivers;

namespace DMReceivers
{
    public class DM_RMC_4KZ_100_C
    {
        DmRmc4kz100C _DmRmc4kz100C;


        public DM_RMC_4KZ_100_C(ICardInputOutputType SwitcherOutput)
        {
            DMOutput _DMOutput = SwitcherOutput as DMOutput;
            _DmRmc4kz100C = new DmRmc4kz100C(_DMOutput);
        }

    }
}

