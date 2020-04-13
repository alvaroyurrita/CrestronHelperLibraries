using System;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace USBPorts
{
    public class USBPort
    {

        #region public properties and events
        public event Action<eUsbHidCountryCodes> Country_Code_Changed;
        public eUsbHidCountryCodes Country_Code
        {
            get { return _C2IUSBHID.CountryCodeFeedback; }
            set { if (Country_Code_Changed != null) Country_Code_Changed(Country_Code); }
        }

        public event Action<string> Manufacturer_Changed;
        public string Manufacturer
        {
            get { return _C2IUSBHID.ManufacturerFeedback.StringValue; }
            set { if (Manufacturer_Changed != null) Manufacturer_Changed(Manufacturer); }
        }
        public event Action<string> Product_Changed;
        public string Product
        {
            get { return _C2IUSBHID.ProductFeedback.StringValue; }
            set { if (Product_Changed != null) Product_Changed(Product); }
        }
        public event Action<string> Serial_Number_Changed;
        public string Serial_Number
        {
            get { return _C2IUSBHID.SerialNumberFeedback.StringValue; }
            set { if (Serial_Number_Changed != null) Serial_Number_Changed(Serial_Number); }
        }
        public event Action<string> Report_Descriptor_Changed;
        public string Report_Descriptor
        {
            get { return _C2IUSBHID.ReportDescriptorFeedback.StringValue; }
            set { if (Report_Descriptor_Changed != null) Report_Descriptor_Changed(Report_Descriptor); }
        }
        public event Action<string> Input_Report_Changed;
        public string Input_Report
        {
            get { return _C2IUSBHID.InputReportFeedback.StringValue; }
            set { if (Input_Report_Changed != null) Input_Report_Changed(Input_Report); }
        }
        public event Action<string> Feature_Report_F_Changed;
        public string Feature_Report_F
        {
            get { return _C2IUSBHID.FeatureReportFeedback.StringValue; }
            set { if (Feature_Report_F_Changed != null) Feature_Report_F_Changed(Feature_Report_F); }
        }
        public event Action<bool> offline_Changed;
        public bool offline
        {
            get { return !_C2IUSBHID.IsOnline; }
            set { if (offline_Changed != null) offline_Changed(offline); }
        }

        public string Name { get; private set; }

        #endregion

        #region public methods
        public void Output_Report(string Message) { _C2IUSBHID.OutputReport.StringValue = Message; }
        public void Feature_Report(string Message) { _C2IUSBHID.FeatureReport.StringValue = Message; }

        #endregion

        #region Private Fields
        UsbHid _C2IUSBHID;
        bool started;
        #endregion

        private void start()
        {
            if (!started)
            {
                started = true;

                if (_C2IUSBHID.Register() != eDeviceRegistrationUnRegistrationResponse.Success)
                {
                    ErrorLog.Error("Error Registering USB ID {0}: {1}:", _C2IUSBHID.ID, _C2IUSBHID.RegistrationFailureReason);
                }
                else
                {
                    _C2IUSBHID.BaseEvent += new BaseEventHandler(_C2IUSBHID_BaseEvent);
                    _C2IUSBHID.OnlineStatusChange += new OnlineStatusChangeEventHandler(_C2IUSBHID_OnlineStatusChange);
                }
            }

        }

        public USBPort(UsbHid C2IUSBHID)
        {
            if (C2IUSBHID == null)
            {
                ErrorLog.Error("Error Initializing C2IUSBHID. USB Port is null");
                return;
            }
            Name = "USB"+C2IUSBHID.PortNumber;
            _C2IUSBHID = C2IUSBHID;
            start();
        }

        void _C2IUSBHID_OnlineStatusChange(GenericBase currentDevice, OnlineOfflineEventArgs args)
        {
            offline = !args.DeviceOnLine;
        }

        void _C2IUSBHID_BaseEvent(GenericBase device, BaseEventArgs args)
        {
            switch (args.EventId)
            {
                case UsbHid.CountryCodeFeedbackEventId:
                    Country_Code = _C2IUSBHID.CountryCodeFeedback;
                    break;
                case UsbHid.FeatureReportFeedbackEventId:
                    Feature_Report_F = _C2IUSBHID.FeatureReportFeedback.StringValue;
                    break;
                case UsbHid.InputReportFeedbackEventId:
                    Input_Report = _C2IUSBHID.InputReportFeedback.StringValue;
                    break;
                case UsbHid.ManufacturerFeedbackEventId:
                    Manufacturer = _C2IUSBHID.ManufacturerFeedback.StringValue;
                    break;
                case UsbHid.ProductFeedbackEventId:
                    Product = _C2IUSBHID.ProductFeedback.StringValue;
                    break;
                case UsbHid.ReportDescriptorFeedbackEventId:
                    Report_Descriptor = _C2IUSBHID.ReportDescriptorFeedback.StringValue;
                    break;
                case UsbHid.SerialNumberFeedbackEventId:
                    Serial_Number = _C2IUSBHID.SerialNumberFeedback.StringValue;
                    break;
                default:
                    break;
            }
        }
    }
}

