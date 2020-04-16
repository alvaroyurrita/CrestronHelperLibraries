using System;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       	// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading
using Crestron.SimplSharpPro.Diagnostics;		    	// For System Monitor Access
using Crestron.SimplSharpPro.DeviceSupport;         	// For Generic Device Support
using Crestron.SimplSharp.CrestronIO;
using Crestron.SimplSharpPro.ThreeSeriesCards;


namespace AV3_PRO3
{
    public class ControlSystem : CrestronControlSystem
    {
        #region global variables: CP3 OnBoard Devices

        #endregion

        #region Add-On Cards

        #endregion  

        //constructor
        public ControlSystem()
            : base()
        {
            try
            {

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in the constructor: {0}", e.Message);
            }

        }

        public override void InitializeSystem()
        {
            try
            {

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }
    }
}