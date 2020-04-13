using System;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       	// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading
using Crestron.SimplSharpPro.Diagnostics;		    	// For System Monitor Access
using Crestron.SimplSharpPro.DeviceSupport;         	// For Generic Device Support
using Crestron.SimplSharpPro.ThreeSeriesCards;
using Crestron.SimplSharpPro.DM.Cards;
using Crestron.SimplSharpPro.Keypads;
using Crestron.SimplSharpPro.DM;
using System.Collections.Generic;
using Crestron.SimplSharpPro.DM.Endpoints.Receivers;
using Crestron.SimplSharpPro.DM.Endpoints.Transmitters;
using USBPorts;
using DMReceivers;
using DMTransmitters;
using Serial_Drivers;
using IOPorts;
using Relays;
using Eternet_Extenders;
using ConnectItDevices;
using System_Monitors;

namespace DMPS4K150
{
    public class ControlSystem : CrestronControlSystem
    {
        #region DMPS4K150 OnBoard Devices using SIMPL Like Helpers
        public DMPS3TwoWaySerialDriver Com01;
        public IROutputPort IRIn1;
        public DigitalInputs2Card Digtal_Inputs;
        public Relays2Card Relays;
        public AdapterInformation Ethernet_Information;
        public DMPS4K150C_AVControl AVControl;
        public DMPS4K150C_DeviceControl DeviceControl;
        public DMPS4K150C_Mic1 Mic1;
        public DMPS4K150C_VGA_Input VGA1;
        public DMPS4K150C_VGA_Input VGA2;
        public DMPS4K150C_VGA_Input VGA3;
        public DMPS4K150C_VGA_Input VGA4;
        public DMPS4K150C_HDMI_Input HDMI1;
        public DMPS4K150C_HDMI_Input HDMI2;
        public DMPS4K150C_HDMI_Input HDMI3;
        public DMPS4K150C_HDMI_Input HDMI4;
        public DMPS4K150C_DM_Input DM1;
        public DMPS4K150C_DM_Input DM2;
        public DMPS4K150C_AnalogAudioOutput AnalogAudioOutput;
        public DMPS4K150C_DM_Output DM1Out;
        public ConnectItDevice TT_1XX;
        public USBPort C2I_USB_HID1;
        public USBPort C2I_USB_HID2;
        public USBPort C2I_USB_HID3;
        public USBPort C2I_USB_HID4;
        public System_Monitor System_Monitor;
        public System_Control System_Control;
        public System_Information SystemInformation;
        #endregion

        #region  Endpoints
        DM_TX_4K_100_C_1G Transmitter1;
        DM_RMC_4K_100_C_1G Receiver1;
        #endregion  

        public ControlSystem()
            : base()
        {

            TestControlSystemType.isDMPS4K150C(this,"This program is for a DMPS4K150 Control System");

            try
            {
                Thread.MaxNumberOfUserThreads = 20;

                #region Assigning SIMPL like classes
                //This clases are created to mimic the modules find in SIMPL
                //Slot-01
                Com01 = new DMPS3TwoWaySerialDriver(this.ComPorts[1]);
                //Slot-02
                IRIn1 = this.IROutputPorts[1];
                //Slot-03
                Digtal_Inputs = DigitalInputs2Card.GetSlot2DigitalInputs(this.DigitalInputPorts);
                //Slot-04
                Relays = Relays2Card.GetRelay2Card(this.RelayPorts);
                //Slot-07.Slot01
                Ethernet_Information = AdapterInformation.GetAdapterInformation();
                //Slot-08.Slot-01
                DeviceControl = DMPS4K150C_DeviceControl.GetDMPS4K150C_DeviceControl(this);
                //Slot-08.Slot-02
                AVControl = DMPS4K150C_AVControl.GetDMPS4K150C_AVControl(this);
                //Slot-08.Slot-02.Slot-01.Slot-01
                Mic1 = DMPS4K150C_Mic1.GetDMPS4K150C_Mic(this);
                //Slot-08.Slot-02.Slot-02.Slot-01
                VGA1 = DMPS4K150C_VGA_Input.GetVGAInput(this, eDmps34K150CInputs.Vga1);
                //Slot-08.Slot-02.Slot-02.Slot-02
                VGA2 = DMPS4K150C_VGA_Input.GetVGAInput(this, eDmps34K150CInputs.Vga2);
                //Slot-08.Slot-02.Slot-02.Slot-03
                VGA3 = DMPS4K150C_VGA_Input.GetVGAInput(this, eDmps34K150CInputs.Vga3);
                //Slot-08.Slot-02.Slot-02.Slot-04
                VGA4 = DMPS4K150C_VGA_Input.GetVGAInput(this, eDmps34K150CInputs.Vga4);
                //Slot-08.Slot-02.Slot-02.Slot-05
                HDMI1 = DMPS4K150C_HDMI_Input.GetHDMIInput(this, eDmps34K150CInputs.Hdmi1);
                //Slot-08.Slot-02.Slot-02.Slot-06
                HDMI2 = DMPS4K150C_HDMI_Input.GetHDMIInput(this, eDmps34K150CInputs.Hdmi2);
                //Slot-08.Slot-02.Slot-02.Slot-07
                HDMI3 = DMPS4K150C_HDMI_Input.GetHDMIInput(this, eDmps34K150CInputs.Hdmi3);
                //Slot-08.Slot-02.Slot-02.Slot-08
                HDMI4 = DMPS4K150C_HDMI_Input.GetHDMIInput(this, eDmps34K150CInputs.Hdmi4);
                //Slot-08.Slot-02.Slot-02.Slot-09
                DM1 = DMPS4K150C_DM_Input.GetDMInput(this, eDmps34K150CInputs.Dm1);
                //Slot-08.Slot-02.Slot-02.Slot-10
                DM2 = DMPS4K150C_DM_Input.GetDMInput(this, eDmps34K150CInputs.Dm2);
                //Slot-08.Slot-02.Slot-03.Slot-01
                AnalogAudioOutput = DMPS4K150C_AnalogAudioOutput.GetDMPS4K150C_Mic(this);
                //Slot-08.Slot-02.Slot-03.Slot-02
                DM1Out = DMPS4K150C_DM_Output.GetDMOutput(this, eDmps34K150COutputs.DmHdmiAnalogOutput);
                //Slot-09.Slot-01
                TT_1XX = new ConnectItDevice(new Tt1xx(this,1));
                //Slot-11.Slot-01
                C2I_USB_HID1 = new USBPort(this.UsbHids[1]);
                //Slot-11.Slot-02
                C2I_USB_HID2 = new USBPort(this.UsbHids[2]);
                //Slot-11.Slot-03
                C2I_USB_HID3 = new USBPort(this.UsbHids[3]);
                //Slot-11.Slot-04
                C2I_USB_HID4 = new USBPort(this.UsbHids[4]);
                //Slot-12
                System_Monitor = System_Monitor.GetSystemMonitor();
                //Slot-12.Slot-01
                System_Control = System_Control.GetSystemControl();
                //Slot-12.Slot-02
                SystemInformation = System_Information.GetSystemInformation();
                #endregion

                #region Enpoints
                var DMTransmitter1 = this.SwitcherInputs[(uint)eDmps34K150CInputs.Dm1] as DMInput;
                Transmitter1 = new DM_TX_4K_100_C_1G(DMTransmitter1);
                var DMReciver = this.SwitcherOutputs[(uint)eDmps34K150COutputs.DmHdmiAnalogOutput] as DMOutput;
                Receiver1 = new DM_RMC_4K_100_C_1G(DMReciver);
                #endregion  

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
                //Test_Components.TestDMPS3TwoWaySerialDriver TestCom01 = new Test_Components.TestDMPS3TwoWaySerialDriver(Com01);
                //Test_Components.TestIR.Start(IRIn1);
                //Test_Components.TestDigitalInputs.Start(Digtal_Inputs);
                //Test_Components.Test2Relays.Start(Relays);
                //Test_Components.TestEthernetInformation.Start(Ethernet_Information);
                //Test_Components.TestDeviceControl.Start(DeviceControl);
                //Test_Components.TestAVControl.Start(AVControl);
                //Test_Components.TestMic1.Start(Mic1);
                //Test_Components.TestHDMIInput TestHDMI1 = new Test_Components.TestHDMIInput(HDMI1);
                //Test_Components.TestHDMIInput TestHDMI2 = new Test_Components.TestHDMIInput(HDMI2);
                //Test_Components.TestHDMIInput TestHDMI3 = new Test_Components.TestHDMIInput(HDMI3);
                //Test_Components.TestHDMIInput TestHDMI4 = new Test_Components.TestHDMIInput(HDMI4);
                //Test_Components.TestVGAInput TestVGA1 = new Test_Components.TestVGAInput(VGA1);
                //Test_Components.TestDMInput TestDM1 = new Test_Components.TestDMInput(DM1);
                //Test_Components.TestDMInput TestDM2 = new Test_Components.TestDMInput(DM2);
                //Test_Components.TestAnalogAudioOutput.Start(AnalogAudioOutput);
                //Test_Components.TestDMOutput TestDM1Out = new Test_Components.TestDMOutput(DM1Out);
                //Test_Components.TestUsbHids UsbHid1 = new DMPS4K150.Test_Components.TestUsbHids(C2I_USB_HID1);
                //Test_Components.TestUsbHids UsbHid2 = new DMPS4K150.Test_Components.TestUsbHids(C2I_USB_HID2);
                //Test_Components.TestUsbHids UsbHid3 = new DMPS4K150.Test_Components.TestUsbHids(C2I_USB_HID3);
                //Test_Components.TestUsbHids UsbHid4 = new DMPS4K150.Test_Components.TestUsbHids(C2I_USB_HID4);
                //Test_Components.TestDMTx4K100C1G TestTransmitter = new DMPS4K150.Test_Components.TestDMTx4K100C1G(Transmitter1);
                //Test_Components.TestDMRmc4KZ100C1G TestReceiver = new DMPS4K150.Test_Components.TestDMRmc4KZ100C1G(Receiver1);

                //Test_Components.TestSystemMonitor.Start(System_Monitor);
                //Test_Components.TestSystemControl.Start(System_Control);
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }
    }
}