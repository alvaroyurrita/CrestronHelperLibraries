using System;
using System.Text;
using System.Collections.Generic;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace Serial_Drivers
{
    public class RS232OnlyTwoWaySerialDriver : SerialDriverBase
    {
        #region public properties and events
        public delegate void PresetStringReceivedHandler(ComPortPresetStrings PresetString, bool State);

        public event Action<string> rx_Changed;
        public string rx
        {
            get { return _ComPort.RcvdString; }
            private set { if (rx_Changed != null) rx_Changed(rx); }
        }


        public event PresetStringReceivedHandler PresetStringReceived;
        #endregion


        #region public methods


        public bool GetPresetStringStatus(string Name)
        {
            var preset = PresetStrings.Find(prst => prst.Name == Name);
            return (preset != null) ? preset.Active : false;
        }
        #endregion

        private bool localstarted;

        public RS232OnlyTwoWaySerialDriver(ComPort ComPort): base(ComPort)
        {
            if (ComPort.Supports422 || ComPort.Supports485 )
            {
                throw new NotSupportedException("ComPort is not an RS232 only Two Way Serial Driver");
            } 
            Start();
            LocalStart();
        }


        private void LocalStart()
        {
            if (!localstarted)
            {
                localstarted = true;

                PresetStrings = new List<ComPortPresetStrings>();
                var ProcessData = new ProcessedReceivedData(PresetStrings, _delimiter);
                ProcessData.rx_Changed += rxData => { if (rx_Changed != null) rx_Changed(rxData); };
                ProcessData.PresetStringReceived += (PresetString, State) => { if (PresetStringReceived != null) PresetStringReceived(PresetString, State); };
                _ComPort.SerialDataReceived += new ComPortDataReceivedEvent(ProcessData._ComPort_SerialDataReceived);
            }
        }
    }
}

