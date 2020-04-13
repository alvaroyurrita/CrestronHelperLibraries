using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.Diagnostics;

namespace System_Monitors
{

    public class System_Control
    {
        

        #region public properties and events

        #region Program1
        public event Action<bool> Program1_Start_Changed;
        public bool Program1_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[1].OperatingState == eProgramOperatingState.Start)?true:false; }
            private set { if (Program1_Start_Changed != null) Program1_Start_Changed(Program1_Start_F); }
        }
        public event Action<bool> Program1_Stop_Changed;
        public bool Program1_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[1].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program1_Stop_Changed != null) Program1_Stop_Changed(Program1_Stop_F); }
        }
        public event Action<bool> Program1_Registered_Changed;
        public bool Program1_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[1].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program1_Registered_Changed != null) Program1_Registered_Changed(Program1_Registered_F); }
        }
        public event Action<bool> Program1_Unregistered_Changed;
        public bool Program1_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[1].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program1_Unregistered_Changed != null) Program1_Unregistered_Changed(Program1_Unregistered_F); }
        }
        #endregion

        #region Program2
        public event Action<bool> Program2_Start_Changed;
        public bool Program2_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[2].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program2_Start_Changed != null) Program2_Start_Changed(Program2_Start_F); }
        }
        public event Action<bool> Program2_Stop_Changed;
        public bool Program2_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[2].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program2_Stop_Changed != null) Program2_Stop_Changed(Program2_Stop_F); }
        }
        public event Action<bool> Program2_Registered_Changed;
        public bool Program2_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[2].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program2_Registered_Changed != null) Program2_Registered_Changed(Program2_Registered_F); }
        }
        public event Action<bool> Program2_Unregistered_Changed;
        public bool Program2_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[2].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program2_Unregistered_Changed != null) Program2_Unregistered_Changed(Program2_Unregistered_F); }
        }
        #endregion

        #region Program3
        public event Action<bool> Program3_Start_Changed;
        public bool Program3_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[3].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program3_Start_Changed != null) Program3_Start_Changed(Program3_Start_F); }
        }
        public event Action<bool> Program3_Stop_Changed;
        public bool Program3_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[3].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program3_Stop_Changed != null) Program3_Stop_Changed(Program3_Stop_F); }
        }
        public event Action<bool> Program3_Registered_Changed;
        public bool Program3_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[3].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program3_Registered_Changed != null) Program3_Registered_Changed(Program3_Registered_F); }
        }
        public event Action<bool> Program3_Unregistered_Changed;
        public bool Program3_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[3].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program3_Unregistered_Changed != null) Program3_Unregistered_Changed(Program3_Unregistered_F); }
        }
        #endregion

        #region Program4
        public event Action<bool> Program4_Start_Changed;
        public bool Program4_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[4].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program4_Start_Changed != null) Program4_Start_Changed(Program4_Start_F); }
        }
        public event Action<bool> Program4_Stop_Changed;
        public bool Program4_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[4].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program4_Stop_Changed != null) Program4_Stop_Changed(Program4_Stop_F); }
        }
        public event Action<bool> Program4_Registered_Changed;
        public bool Program4_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[4].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program4_Registered_Changed != null) Program4_Registered_Changed(Program4_Registered_F); }
        }
        public event Action<bool> Program4_Unregistered_Changed;
        public bool Program4_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[4].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program4_Unregistered_Changed != null) Program4_Unregistered_Changed(Program4_Unregistered_F); }
        }
        #endregion

        #region Program5
        public event Action<bool> Program5_Start_Changed;
        public bool Program5_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[5].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program5_Start_Changed != null) Program5_Start_Changed(Program5_Start_F); }
        }
        public event Action<bool> Program5_Stop_Changed;
        public bool Program5_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[5].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program5_Stop_Changed != null) Program5_Stop_Changed(Program5_Stop_F); }
        }
        public event Action<bool> Program5_Registered_Changed;
        public bool Program5_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[5].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program5_Registered_Changed != null) Program5_Registered_Changed(Program5_Registered_F); }
        }
        public event Action<bool> Program5_Unregistered_Changed;
        public bool Program5_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[5].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program5_Unregistered_Changed != null) Program5_Unregistered_Changed(Program5_Unregistered_F); }
        }
        #endregion

        #region Program6
        public event Action<bool> Program6_Start_Changed;
        public bool Program6_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[6].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program6_Start_Changed != null) Program6_Start_Changed(Program6_Start_F); }
        }
        public event Action<bool> Program6_Stop_Changed;
        public bool Program6_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[6].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program6_Stop_Changed != null) Program6_Stop_Changed(Program6_Stop_F); }
        }
        public event Action<bool> Program6_Registered_Changed;
        public bool Program6_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[6].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program6_Registered_Changed != null) Program6_Registered_Changed(Program6_Registered_F); }
        }
        public event Action<bool> Program6_Unregistered_Changed;
        public bool Program6_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[6].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program6_Unregistered_Changed != null) Program6_Unregistered_Changed(Program6_Unregistered_F); }
        }
        #endregion

        #region Program7
        public event Action<bool> Program7_Start_Changed;
        public bool Program7_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[7].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program7_Start_Changed != null) Program7_Start_Changed(Program7_Start_F); }
        }
        public event Action<bool> Program7_Stop_Changed;
        public bool Program7_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[7].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program7_Stop_Changed != null) Program7_Stop_Changed(Program7_Stop_F); }
        }
        public event Action<bool> Program7_Registered_Changed;
        public bool Program7_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[7].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program7_Registered_Changed != null) Program7_Registered_Changed(Program7_Registered_F); }
        }
        public event Action<bool> Program7_Unregistered_Changed;
        public bool Program7_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[7].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program7_Unregistered_Changed != null) Program7_Unregistered_Changed(Program7_Unregistered_F); }
        }
        #endregion

        #region Program8
        public event Action<bool> Program8_Start_Changed;
        public bool Program8_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[8].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program8_Start_Changed != null) Program8_Start_Changed(Program8_Start_F); }
        }
        public event Action<bool> Program8_Stop_Changed;
        public bool Program8_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[8].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program8_Stop_Changed != null) Program8_Stop_Changed(Program8_Stop_F); }
        }
        public event Action<bool> Program8_Registered_Changed;
        public bool Program8_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[8].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program8_Registered_Changed != null) Program8_Registered_Changed(Program8_Registered_F); }
        }
        public event Action<bool> Program8_Unregistered_Changed;
        public bool Program8_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[8].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program8_Unregistered_Changed != null) Program8_Unregistered_Changed(Program8_Unregistered_F); }
        }
        #endregion

        #region Program9
        public event Action<bool> Program9_Start_Changed;
        public bool Program9_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[9].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program9_Start_Changed != null) Program9_Start_Changed(Program9_Start_F); }
        }
        public event Action<bool> Program9_Stop_Changed;
        public bool Program9_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[9].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program9_Stop_Changed != null) Program9_Stop_Changed(Program9_Stop_F); }
        }
        public event Action<bool> Program9_Registered_Changed;
        public bool Program9_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[9].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program9_Registered_Changed != null) Program9_Registered_Changed(Program9_Registered_F); }
        }
        public event Action<bool> Program9_Unregistered_Changed;
        public bool Program9_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[9].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program9_Unregistered_Changed != null) Program9_Unregistered_Changed(Program9_Unregistered_F); }
        }
        #endregion

        #region Program10
        public event Action<bool> Program10_Start_Changed;
        public bool Program10_Start_F
        {
            get { return (SystemMonitor.ProgramCollection[10].OperatingState == eProgramOperatingState.Start) ? true : false; }
            private set { if (Program10_Start_Changed != null) Program10_Start_Changed(Program10_Start_F); }
        }
        public event Action<bool> Program10_Stop_Changed;
        public bool Program10_Stop_F
        {
            get { return (SystemMonitor.ProgramCollection[10].OperatingState == eProgramOperatingState.Stop) ? true : false; }
            private set { if (Program10_Stop_Changed != null) Program10_Stop_Changed(Program10_Stop_F); }
        }
        public event Action<bool> Program10_Registered_Changed;
        public bool Program10_Registered_F
        {
            get { return (SystemMonitor.ProgramCollection[10].RegistrationState == eProgramRegistrationState.Register) ? true : false; }
            private set { if (Program10_Registered_Changed != null) Program10_Registered_Changed(Program10_Registered_F); }
        }
        public event Action<bool> Program10_Unregistered_Changed;
        public bool Program10_Unregistered_F
        {
            get { return (SystemMonitor.ProgramCollection[10].RegistrationState == eProgramRegistrationState.Unregister) ? true : false; }
            private set { if (Program10_Unregistered_Changed != null) Program10_Unregistered_Changed(Program10_Unregistered_F); }
        }
        #endregion

        public event Action<bool> OSD_InSetup_Changed;
        public bool OSD_InSetup_F
        {
            get { return SystemMonitor.OSDInformation.InSetupMode; }
            private set { if (OSD_InSetup_Changed != null) OSD_InSetup_Changed(OSD_InSetup_F); }
        }

        public event Action<int> CurrentTimeZone_Changed;
        public int CurrentTimeZone_F
        {
            get { return SystemMonitor.TimeZoneInformation.TimeZoneNumber; }
            private set { if (CurrentTimeZone_Changed != null) CurrentTimeZone_Changed(CurrentTimeZone_F); }
        }

        public event Action<string> VideoResolution_Changed;
        public string VideoResolution_F
        {
            get { return SystemMonitor.OSDInformation.OutputResolutionFeedbackAsString;}
            private set { if (VideoResolution_Changed != null) VideoResolution_Changed(VideoResolution_F); }
        }
        public event Action<string> TimeZoneText_Changed;
        public string TimeZoneText_F
        {
            get { return SystemMonitor.TimeZoneInformation.TimeZoneName;}
            private set { if (TimeZoneText_Changed != null) TimeZoneText_Changed(TimeZoneText_F); }
        }


        #endregion

        #region Public Methods

        #region Program1
        public void Program1_Start() { SystemMonitor.ProgramCollection[1].OperatingState = eProgramOperatingState.Start; }
        public void Program1_Stop() { SystemMonitor.ProgramCollection[1].OperatingState = eProgramOperatingState.Stop; }
        public void Program1_Register() { SystemMonitor.ProgramCollection[1].RegistrationState = eProgramRegistrationState.Register; }
        public void Program1_Unregister() { SystemMonitor.ProgramCollection[1].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program2
        public void Program2_Start() { SystemMonitor.ProgramCollection[2].OperatingState = eProgramOperatingState.Start; }
        public void Program2_Stop() { SystemMonitor.ProgramCollection[2].OperatingState = eProgramOperatingState.Stop; }
        public void Program2_Register() { SystemMonitor.ProgramCollection[2].RegistrationState = eProgramRegistrationState.Register; }
        public void Program2_Unregister() { SystemMonitor.ProgramCollection[2].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program3
        public void Program3_Start() { SystemMonitor.ProgramCollection[3].OperatingState = eProgramOperatingState.Start; }
        public void Program3_Stop() { SystemMonitor.ProgramCollection[3].OperatingState = eProgramOperatingState.Stop; }
        public void Program3_Register() { SystemMonitor.ProgramCollection[3].RegistrationState = eProgramRegistrationState.Register; }
        public void Program3_Unregister() { SystemMonitor.ProgramCollection[3].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program4
        public void Program4_Start() { SystemMonitor.ProgramCollection[4].OperatingState = eProgramOperatingState.Start; }
        public void Program4_Stop() { SystemMonitor.ProgramCollection[4].OperatingState = eProgramOperatingState.Stop; }
        public void Program4_Register() { SystemMonitor.ProgramCollection[4].RegistrationState = eProgramRegistrationState.Register; }
        public void Program4_Unregister() { SystemMonitor.ProgramCollection[4].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program5
        public void Program5_Start() { SystemMonitor.ProgramCollection[5].OperatingState = eProgramOperatingState.Start; }
        public void Program5_Stop() { SystemMonitor.ProgramCollection[5].OperatingState = eProgramOperatingState.Stop; }
        public void Program5_Register() { SystemMonitor.ProgramCollection[5].RegistrationState = eProgramRegistrationState.Register; }
        public void Program5_Unregister() { SystemMonitor.ProgramCollection[5].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program6
        public void Program6_Start() { SystemMonitor.ProgramCollection[6].OperatingState = eProgramOperatingState.Start; }
        public void Program6_Stop() { SystemMonitor.ProgramCollection[6].OperatingState = eProgramOperatingState.Stop; }
        public void Program6_Register() { SystemMonitor.ProgramCollection[6].RegistrationState = eProgramRegistrationState.Register; }
        public void Program6_Unregister() { SystemMonitor.ProgramCollection[6].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program7
        public void Program7_Start() { SystemMonitor.ProgramCollection[7].OperatingState = eProgramOperatingState.Start; }
        public void Program7_Stop() { SystemMonitor.ProgramCollection[7].OperatingState = eProgramOperatingState.Stop; }
        public void Program7_Register() { SystemMonitor.ProgramCollection[7].RegistrationState = eProgramRegistrationState.Register; }
        public void Program7_Unregister() { SystemMonitor.ProgramCollection[7].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program8
        public void Program8_Start() { SystemMonitor.ProgramCollection[8].OperatingState = eProgramOperatingState.Start; }
        public void Program8_Stop() { SystemMonitor.ProgramCollection[8].OperatingState = eProgramOperatingState.Stop; }
        public void Program8_Register() { SystemMonitor.ProgramCollection[8].RegistrationState = eProgramRegistrationState.Register; }
        public void Program8_Unregister() { SystemMonitor.ProgramCollection[8].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program9
        public void Program9_Start() { SystemMonitor.ProgramCollection[9].OperatingState = eProgramOperatingState.Start; }
        public void Program9_Stop() { SystemMonitor.ProgramCollection[9].OperatingState = eProgramOperatingState.Stop; }
        public void Program9_Register() { SystemMonitor.ProgramCollection[9].RegistrationState = eProgramRegistrationState.Register; }
        public void Program9_Unregister() { SystemMonitor.ProgramCollection[9].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion

        #region Program10
        public void Program10_Start() { SystemMonitor.ProgramCollection[10].OperatingState = eProgramOperatingState.Start; }
        public void Program10_Stop() { SystemMonitor.ProgramCollection[10].OperatingState = eProgramOperatingState.Stop; }
        public void Program10_Register() { SystemMonitor.ProgramCollection[10].RegistrationState = eProgramRegistrationState.Register; }
        public void Program10_Unregister() { SystemMonitor.ProgramCollection[10].RegistrationState = eProgramRegistrationState.Unregister; }
        #endregion



        //public void OSD_EnterSetup() { SystemMonitor.OSDInformation.InSetupMode = true; }
        //public void OSD_ExitSetup() { SystemMonitor.OSDInformation.InSetupMode = false; }


        public bool TimeZone(int Zone)
        {
            var result = CrestronEnvironment.SetTimeZone(Zone);
            if (!result) ErrorLog.Notice("An attemt to set an undetermined Time Zone was made");
            return result;
        }

        /*
        public void VideoResolution(eOutputResolution Resolution)
        {
            if (Resolution != eOutputResolution.Res_Unknown) SystemMonitor.OSDInformation.OutputResolution = Resolution;
        }*/
        #endregion

        #region Private Fields
        //Singleton
        private static System_Control _System_Control;

        #endregion

        public static System_Control GetSystemControl()
        {
            return _System_Control ?? (_System_Control = new System_Control());
        }

        //constructor
        private System_Control() 
        {
            //SystemMonitor.OSDInformation.ResolutionChange += new ResolutionChangeEventHandler(OSDInformation_ResolutionChange);
            //SystemMonitor.OSDInformation.SetupModeChange += new SetupModeChangeEventHandler(OSDInformation_SetupModeChange);
            SystemMonitor.ProgramChange += new ProgramStateChangeEventHandler(SystemMonitor_ProgramChange);
            SystemMonitor.TimeZoneInformation.TimeZoneChange += new TimeZoneChangeEventHandler(TimeZoneInformation_TimeZoneChange);
        }

        void TimeZoneInformation_TimeZoneChange(TimeZoneEventArgs args)
        {
            switch (args.EventType)
            {
                case eTimeZoneEventType.TimeZoneName:
                    TimeZoneText_F = SystemMonitor.TimeZoneInformation.TimeZoneName;
                    break;
                case eTimeZoneEventType.TimeZoneNumber:
                    CurrentTimeZone_F = SystemMonitor.TimeZoneInformation.TimeZoneNumber;
                    break;
                case eTimeZoneEventType.UndeterminedEvent:
                    break;
                default:
                    break;
            }
        }

        void SystemMonitor_ProgramChange(Program sender, ProgramEventArgs args)
        {
            uint ProgNo = args.ProgramNumber;
            bool ProgState = args.OperatingState == eProgramOperatingState.Start?true:false;
            bool ProgRegistration = args.RegistrationState == eProgramRegistrationState.Register?true:false;
            switch (args.EventType)
            {
                case eProgramChangeEventType.NoChange:
                    break;
                case eProgramChangeEventType.OperatingState:
                    UpdateOperatingState(ProgNo, ProgState);
                    break;
                case eProgramChangeEventType.RegistrationState:
                    UpdateRegistrationState(ProgNo, ProgRegistration);
                    break;
                default:
                    break;
            }
        }

        private void UpdateOperatingState(uint ProgNo, bool State)
        {
            switch (ProgNo)
            {
                case 1:
                    Program1_Start_F = State;
                    Program1_Stop_F = !State;
                    break;
                case 2:
                    Program2_Start_F = State;
                    Program2_Stop_F = !State;
                    break;
                case 3:
                    Program3_Start_F = State;
                    Program3_Stop_F = !State;
                    break;
                case 4:
                    Program4_Start_F = State;
                    Program4_Stop_F = !State;
                    break;
                case 5:
                    Program5_Start_F = State;
                    Program5_Stop_F = !State;
                    break;
                case 6:
                    Program6_Start_F = State;
                    Program6_Stop_F = !State;
                    break;
                case 7:
                    Program7_Start_F = State;
                    Program7_Stop_F = !State;
                    break;
                case 8:
                    Program8_Start_F = State;
                    Program8_Stop_F = !State;
                    break;
                case 9:
                    Program9_Start_F = State;
                    Program9_Stop_F = !State;
                    break;
                case 10:
                    Program10_Start_F = State;
                    Program10_Stop_F = !State;
                    break;
                default:
                    break;
            }
        }

        private void UpdateRegistrationState(uint ProgNo, bool Registration)
        {
            switch (ProgNo)
            {
                case 1:
                    Program1_Registered_F = Registration;
                    Program1_Unregistered_F = !Registration;
                    break;
                case 2:
                    Program2_Registered_F = Registration;
                    Program2_Unregistered_F = !Registration;
                    break;
                case 3:
                    Program3_Registered_F = Registration;
                    Program3_Unregistered_F = !Registration;
                    break;
                case 4:
                    Program4_Registered_F = Registration;
                    Program4_Unregistered_F = !Registration;
                    break;
                case 5:
                    Program5_Registered_F = Registration;
                    Program5_Unregistered_F = !Registration;
                    break;
                case 6:
                    Program6_Registered_F = Registration;
                    Program6_Unregistered_F = !Registration;
                    break;
                case 7:
                    Program7_Registered_F = Registration;
                    Program7_Unregistered_F = !Registration;
                    break;
                case 8:
                    Program8_Registered_F = Registration;
                    Program8_Unregistered_F = !Registration;
                    break;
                case 9:
                    Program9_Registered_F = Registration;
                    Program9_Unregistered_F = !Registration;
                    break;
                case 10:
                    Program10_Registered_F = Registration;
                    Program10_Unregistered_F = !Registration;
                    break;
                default:
                    break;
            }
        }

        void OSDInformation_SetupModeChange(SetupModeEventArgs args)
        {
            OSD_InSetup_F = args.InSetupMode;
        }

        void OSDInformation_ResolutionChange(ResolutionEventArgs args)
        {
            VideoResolution_F = args.OutputResolutionAsString;
        }
    }
}

