using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace DMPS4K150
{
    public static class TestControlSystemType
    {
        public static void isDMPS4K150C(ControlSystem ControlSystem, String Message)
        {
            if (ControlSystem.ToString() != "DMPS4K150.ControlSystem")
            {
                ErrorLog.Error("Message");
                ErrorLog.Error("Terminating Execution");
                throw new NotSupportedException();
            }
        }
    }

}