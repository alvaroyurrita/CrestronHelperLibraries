using System;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       	// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading
using Crestron.SimplSharpPro.Diagnostics;		    	// For System Monitor Access
using Crestron.SimplSharpPro.DeviceSupport;         	// For Generic Device Support
using Crestron.SimplSharp.CrestronIO;
using Serial_Drivers;
using System_Monitors;
using IOPorts;
using Relays;
using USBPorts;
using Eternet_Extenders;

namespace CP3_CP3N
{
    public class ControlSystem : CrestronControlSystem
    {
        #region global variables: CP3 OnBoard Devices
        public AdapterInformation Ethernet_Information;
        public TwoWaySerialDriver Com01;
        public RS232OnlyTwoWaySerialDriver Com02;
        public RS232OnlyTwoWaySerialDriver Com03;
        public IOs8AnalogInputCard C2I_CP3_IO8;
        //public IOPort IOPort8;
        public Relays8Card C2I_CP3_RY8;
        //public SingleRelay Relay8;
        public IROutputPort IR1;
        public IROutputPort IR2;
        public UsbHid USBHid1;
        public System_Monitor C2I_CP3_SYSTEMMONITOR;
        public System_Control C2I_CP3_SYSTEMCONTROL;
        public System_Information C2I_CP3_SYSTEMINFORMATION;
        public USBPort C2I_USB_HID;
        #endregion

        //constructor
        public ControlSystem()
            : base()
        {
            string DeviceType = this.ControllerPrompt;
            if (DeviceType != "CP3" && DeviceType != "CP3N" )
            {
                ErrorLog.Error("This program is for a CP3 or CP3N Control System");
                ErrorLog.Error("Terminating Execution");
                throw new NotSupportedException();
            }

            try
            {
                #region Onboard Devices
                //CP3 onboard devices
                //Slot-02.Slot2.1
                Ethernet_Information = AdapterInformation.GetAdapterInformation();
                //Slot-03.Slot-01
                Com01 = new TwoWaySerialDriver(this.ComPorts[1]);
                //Slot-03.Slot-02
                Com02 = new RS232OnlyTwoWaySerialDriver(this.ComPorts[2]);
                //Slot-03.Slot-03
                Com03 = new RS232OnlyTwoWaySerialDriver(this.ComPorts[3]);
                //Slot-04
                C2I_CP3_IO8 = IOs8AnalogInputCard.GetIO8AnalogInputCard(VersiPorts);
                //Slot-05
                C2I_CP3_RY8 = Relays8Card.GetRelay8Card(RelayPorts);
                //Slot-06 Port-01
                IR1 = this.IROutputPorts[1];
                //Slot-06 Port-02
                IR2 = this.IROutputPorts[2];
                //Slot-07
                C2I_CP3_SYSTEMMONITOR = System_Monitor.GetSystemMonitor();
                //Slot-07.Slot-01
                C2I_CP3_SYSTEMCONTROL = System_Control.GetSystemControl();
                //Slot-7.Slot-02
                C2I_CP3_SYSTEMINFORMATION = System_Information.GetSystemInformation();
                //Slot-10.Slot-01
                C2I_USB_HID = new USBPort(UsbHids[1]);
                #endregion  

                //Single Port examples:
                //IOPort8 = new IOPort(VersiPorts[8]);
                //Relay8 = new SingleRelay(RelayPorts[8]);

                Thread.MaxNumberOfUserThreads = 20;

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
                //Test_Components.TestTwoWayComPort TestCom01 = new Test_Components.TestTwoWayComPort(Com01);
                //Test_Components.TestRS232OnlyTwoWayComPort TestCom02 = new Test_Components.TestRS232OnlyTwoWayComPort(Com02);
                //Test_Components.TestSystemMonitor.Start(SysMon);
                //Test_Components.TestSystemControl.Start(SysControl);
                //Test_Components.TestC2ICP3IO8.Start(C2I_CP3_IO8);
                //Test_Components.TestIOPort TestIOPort8 = new Test_Components.TestIOPort(IOPort8);
                //Test_Components.TestSingleRelay TestRelay8 = new Test_Components.TestSingleRelay(Relay8);
                //Test_Components.TestC2ICP3RY8.Start(C2I_CP3_RY8);
                //Test_Components.TestIR.Start(IR1);
                //Test_Components.TestIRasSerial.Start(IR2);
                //Test_Components.TestEthernetInformation.Start(Ethernet_Information);
                Test_Components.TestSystemInformation.Start(C2I_CP3_SYSTEMINFORMATION);
                //Test_Components.TestUSBPort TestC2IUSBHid = new CP3_CP3N.Test_Components.TestUSBPort(C2I_USB_HID);
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }
        
        

        

        
    }
}