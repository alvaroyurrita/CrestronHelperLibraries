using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace Serial_Drivers
{
    public class ProcessedReceivedData
    {
        internal delegate void PresetStringReceivedHandler(ComPortPresetStrings PresetString, bool State);
        internal event PresetStringReceivedHandler PresetStringReceived;
        internal event Action<string> rx_Changed;
        internal List<ComPortPresetStrings> PresetStrings;
        internal StringBuilder _delimiter;

        //public ProcessedReceivedData(Action<string> rx_Changed, List<ComPortPresetStrings> PresetStrings, Action<ComPortPresetStrings, bool> PresetStringReceived, string delimiter)
        public ProcessedReceivedData(List<ComPortPresetStrings> PresetStrings, StringBuilder delimiter)
        {
            this.PresetStrings = PresetStrings;
            this._delimiter = delimiter;
        }


        StringBuilder ReceiveDataBuffer = new StringBuilder(512);
        private CCriticalSection CriticalProcessingReceivedData = new CCriticalSection();
        public void _ComPort_SerialDataReceived(ComPort ReceivingComPort, ComPortSerialDataEventArgs args)
        {
            ReceiveDataBuffer.Append(args.SerialData);
            if (rx_Changed != null) rx_Changed(args.SerialData);
            CriticalProcessingReceivedData.Enter();
            try
            {
                string delimiter = _delimiter.ToString();
                string CompareBuffer = ReceiveDataBuffer.ToString();
                foreach (var cmd in PresetStrings)
                {
                    if (CompareBuffer.EndsWith(cmd.Command + delimiter))
                    {
                        if (!cmd.Active)
                        {
                            if (PresetStringReceived != null)
                            {
                                cmd.Active = true;
                                PresetStringReceived(cmd, cmd.Active);
                            }
                        }
                    }
                    else
                    {
                        if (cmd.Active)
                        {
                            if (PresetStringReceived != null)
                            {
                                cmd.Active = false;
                                PresetStringReceived(cmd, cmd.Active);
                            }
                        }
                    }
                }
                if (ReceiveDataBuffer.Length > 400) ReceiveDataBuffer.Remove(0, 256);
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error Processsing Data Received - {0}", e.Message);
            }
            CriticalProcessingReceivedData.Leave();
        }

    }
}