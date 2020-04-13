using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro.DM.Cards;
using Crestron.SimplSharpPro.DM;



namespace DMPS4K150
{
    public class DMPS4K150C_SwitcherOutput
    {
        public delegate void SwitcherOutputEventHandler(IDmCardStreamBase stream, DMOutputEventArgs args);

        public event SwitcherOutputEventHandler HdmiOutputStreamChanged;
        public event SwitcherOutputEventHandler DmpsAudioOutputStreamChanged;
        public event SwitcherOutputEventHandler DmOutputStreamChanged;
        public event SwitcherOutputEventHandler DmpsDmHdmiOutputStreamChanged;
        public event SwitcherOutputEventHandler DMOutputChanged;


        //singleton
        private static DMPS4K150C_SwitcherOutput _SwitcherOutput;

        private ControlSystem _ControlSystem;

        public static DMPS4K150C_SwitcherOutput GetDMPS4K150C_SwitcherOutput(ControlSystem _ControlSystem)
        {
            return _SwitcherOutput ?? (_SwitcherOutput = new DMPS4K150C_SwitcherOutput(_ControlSystem));
        }

        private DMPS4K150C_SwitcherOutput(ControlSystem ControlSystem)
        {
            TestControlSystemType.isDMPS4K150C(ControlSystem, "This Module is for a DMPS4K150C Control System");
            this._ControlSystem = ControlSystem;
            _ControlSystem.DMOutputChange += new DMOutputEventHandler(_ControlSystem_DMOutputChange);
        }

        private void _ControlSystem_DMOutputChange(Switch device, DMOutputEventArgs args)
        {
            if (args.Stream == null)
            {
                if (DMOutputChanged != null) DMOutputChanged(args.Stream, args);
            }            
            else
            {
                switch (args.Stream.Type)
                {
                    case eDmStreamType.Aec:
                        break;
                    case eDmStreamType.AirMedia:
                        break;
                    case eDmStreamType.AirMediaStreamingInput:
                        break;
                    case eDmStreamType.AnalogAudio:
                        break;
                    case eDmStreamType.AnalogAudioInput:
                        break;
                    case eDmStreamType.AvStream:
                        break;
                    case eDmStreamType.Balanced:
                        break;
                    case eDmStreamType.Bnc:
                        break;
                    case eDmStreamType.Camera:
                        break;
                    case eDmStreamType.Coaxial:
                        break;
                    case eDmStreamType.Codec:
                        break;
                    case eDmStreamType.Cvbs:
                        break;
                    case eDmStreamType.DM:
                        if (DmOutputStreamChanged != null) DmOutputStreamChanged(args.Stream, args);
                        break;
                    case eDmStreamType.Dialer:
                        break;
                    case eDmStreamType.DisplayPort:
                        break;
                    case eDmStreamType.DmLite:
                        break;
                    case eDmStreamType.DmpsAudio:
                        if (DmpsAudioOutputStreamChanged != null) DmpsAudioOutputStreamChanged(args.Stream, args);
                        break;
                    case eDmStreamType.DmpsDmHdmi:
                        if (DmpsDmHdmiOutputStreamChanged != null) DmpsDmHdmiOutputStreamChanged(args.Stream, args);
                        break;
                    case eDmStreamType.Dvi:
                        break;
                    case eDmStreamType.Hdmi:
                        if (HdmiOutputStreamChanged != null) HdmiOutputStreamChanged(args.Stream, args);
                        break;
                    case eDmStreamType.HdmiVga:
                        break;
                    case eDmStreamType.HdmiVgaBnc:
                        break;
                    case eDmStreamType.Optical:
                        break;
                    case eDmStreamType.Sip:
                        break;
                    case eDmStreamType.StreamingRx:
                        break;
                    case eDmStreamType.StreamingTx:
                        break;
                    case eDmStreamType.Vga:
                        break;
                    default:
                        break;
                }
            }

        }
    }
}