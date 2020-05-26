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
                    //Slot-07.Port-01
                    IR1 = this.IROutputPorts[1];
                    //Slot-07.Port-02
                    IR2 = this.IROutputPorts[2];
                    //Slot-08
                    C2I_RMC3_SYSTEMMONITOR = System_Monitor.GetSystemMonitor();
                    //Slot-08.Slot-01
                    C2I_RMC3_SYSTEMCONTROL = System_Control.GetSystemControl();
                    //Slot-08.Slot-02
                    C2I_RMC3_SYSTEMINFORMATION = System_Information.GetSystemInformation();
                    //Slot-11.Slot-01
                    C2I_USB_HID = new USBPort(UsbHids[1]);
                    #endregion


                    Thread.MaxNumberOfUserThreads = 200;
                }
                catch (Exception e)
                {
                    ErrorLog.Error("Error in the constructor: {0}", e.Message);
                }
            }
        }


        public override void InitializeSystem()
        {
            try
            {
                //Test_Components.TestEthernetInformation.Start(Ethernet_Information);
                //Test_Components.TestTwoWayComPort TestCom01 = new Test_Components.TestTwoWayComPort(Com01);
                Test_Components.TestDigitalInputs.Start(C2I_RMC3_DI2);
                //Test_Components.Test2Relays.Start(C2I_RMC3_RY2);
                //Test_Components.TestIR.Start(IRIn1);
                //Test_Components.TestSystemMonitor.Start(SysMon);
                //Test_Components.TestSystemControl.Start(SysControl);
                //Test_Components.TestSystemInformation.Start(C2I_CP3_SYSTEMINFORMATION);

                
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }




        


            

        
    }
}