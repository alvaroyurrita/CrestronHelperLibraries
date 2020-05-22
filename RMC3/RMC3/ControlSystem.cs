using System;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       	// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading
using Crestron.SimplSharpPro.Diagnostics;		    	// For System Monitor Access
using Crestron.SimplSharpPro.DeviceSupport;
using IOPorts;
using Relays;
using Serial_Drivers;
using System_Monitors;
using USBPorts;
using Eternet_Extenders;
// For Generic Device Support

namespace RMC3
{
    public class ControlSystem : CrestronControlSystem
    {

        #region global variables: RMC3 OnBoard Devices
        public AdapterInformation Ethernet_Information;
        public TwoWaySerialDriver Com01;
        public DigitalInputs2Card C2I_RMC3_DI2;
        public Relays2Card C2I_RMC3_RY2;
       
        public IROutputPort IR1;
        public IROutputPort IR2;
        public UsbHid USBHid1;
        public System_Monitor C2I_RMC3_SYSTEMMONITOR;
        public System_Control C2I_RMC3_SYSTEMCONTROL;
        public System_Information C2I_RMC3_SYSTEMINFORMATION;
        public USBPort C2I_USB_HID;
        #endregion


        /// <summary>
        /// ControlSystem Constructor. Starting point for the SIMPL#Pro program.
        /// Use the constructor to:
        /// * Initialize the maximum number of threads (max = 400)
        /// * Register devices
        /// * Register event handlers
        /// * Add Console Commands
        /// 
        /// Please be aware that the constructor needs to exit quickly; if it doesn't
        /// exit in time, the SIMPL#Pro program will exit.
        /// 
        /// You cannot send / receive data in the constructor
        /// </summary>
        public ControlSystem()
            : base()
        {
            string DeviceType = this.ControllerPrompt;

            if (DeviceType != "RMC3")
            {
                ErrorLog.Warn("This program was written for an RMC3");
            }
            else
            {
                ErrorLog.Notice("Epstein didn't kill himself");
                CrestronConsole.PrintLine("IT'S GO TIME!");
                try
                {

                    #region Onboard Devices
                    //RMC3 onboard devices
                    //Slot-02
                    Ethernet_Information = AdapterInformation.GetAdapterInformation();
                    //Slot-04
                    Com01 = new TwoWaySerialDriver(this.ComPorts[1]);
                    //Slot-05                
                    C2I_RMC3_DI2 = DigitalInputs2Card.GetSlot2DigitalInputs(DigitalInputPorts);
                    //Slot-06
                    C2I_RMC3_RY2 = Relays2Card.GetRelay2Card(RelayPorts);
                    //Slot-07 Port-01
                    IR1 = this.IROutputPorts[1];
                    //Slot-07 Port-02
                    IR2 = this.IROutputPorts[2];
                    //Slot-08
                    C2I_RMC3_SYSTEMMONITOR = System_Monitor.GetSystemMonitor();
                    //Slot-07.Slot-01
                    C2I_RMC3_SYSTEMCONTROL = System_Control.GetSystemControl();
                    //Slot-7.Slot-02
                    C2I_RMC3_SYSTEMINFORMATION = System_Information.GetSystemInformation();
                    //Slot-10.Slot-01
                    C2I_USB_HID = new USBPort(UsbHids[1]);
                    #endregion


                    Thread.MaxNumberOfUserThreads = 200;

                    //Subscribe to the controller events (System, Program, and Ethernet)
                    //CrestronEnvironment.SystemEventHandler += new SystemEventHandler(ControlSystem_ControllerSystemEventHandler);
                    //CrestronEnvironment.ProgramStatusEventHandler += new ProgramStatusEventHandler(ControlSystem_ControllerProgramEventHandler);
                    //CrestronEnvironment.EthernetEventHandler += new EthernetEventHandler(ControlSystem_ControllerEthernetEventHandler);
                }
                catch (Exception e)
                {
                    ErrorLog.Error("Error in the constructor: {0}", e.Message);
                }
            }
        }

        /// <summary>
        /// InitializeSystem - this method gets called after the constructor 
        /// has finished. 
        /// 
        /// Use InitializeSystem to:
        /// * Start threads
        /// * Configure ports, such as serial and verisports
        /// * Start and initialize socket connections
        /// Send initial device configurations
        /// 
        /// Please be aware that InitializeSystem needs to exit quickly also; 
        /// if it doesn't exit in time, the SIMPL#Pro program will exit.
        /// </summary>
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