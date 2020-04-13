using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro.Diagnostics;

namespace System_Monitors
{
    public class System_Information
    {
        #region public properties and events

        public event Action<string> IOControllerVersion_Changed;
        public string IOControllerVersion
        {
            get { return SystemMonitor.VersionInformation.IOPVersion; }
            private set { if (IOControllerVersion_Changed != null) IOControllerVersion_Changed(IOControllerVersion); } 
        }
        public event Action<string> SNMPAppVersion_Changed;
        public string SNMPAppVersion
        {
            get { return SystemMonitor.VersionInformation.SNMPVersion; }
            private set { if (SNMPAppVersion_Changed != null) SNMPAppVersion_Changed(SNMPAppVersion); } 
        }
        public event Action<string> BACnetAppVersion_Changed;
        public string BACnetAppVersion
        {
            get { return SystemMonitor.VersionInformation.BACNetVersion; }
            private set { if (BACnetAppVersion_Changed != null) BACnetAppVersion_Changed(BACnetAppVersion); }
        }
        public event Action<string> ControllerVersion_Changed;
        public string ControllerVersion
        {
            get { return SystemMonitor.VersionInformation.ControlSystemVersion; }
            private set { if (ControllerVersion_Changed != null) ControllerVersion_Changed(ControllerVersion); } 
        }


        #endregion  
        
        #region Public Methods
        public void ReportFirmwareVersion()
        {
            IOControllerVersion = "";
            SNMPAppVersion = "";
            BACnetAppVersion = "";
            ControllerVersion = "";
        }

        #endregion

        #region Private Fields
        //Singleton
        private static System_Information _System_Information;

        #endregion

        public static System_Information GetSystemInformation()
        {
            return _System_Information ?? (_System_Information = new System_Information());
        }
    }
}