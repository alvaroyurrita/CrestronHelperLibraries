using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro.DM.Cards;
using Crestron.SimplSharpPro.DM;



namespace DMPS4K150
{
    public class DMPS4K150C_SwitcherInput
    {
        public delegate void SwitcherInputEventHandler(IDmCardStreamBase stream, DMInputEventArgs args);

        public event SwitcherInputEventHandler VGA1InputChanged;
        public event SwitcherInputEventHandler VGA2InputChanged;
        public event SwitcherInputEventHandler VGA3InputChanged;
        public event SwitcherInputEventHandler VGA4InputChanged;
        public event SwitcherInputEventHandler HDMI1InputChanged;
        public event SwitcherInputEventHandler HDMI2InputChanged;
        public event SwitcherInputEventHandler HDMI3InputChanged;
        public event SwitcherInputEventHandler HDMI4InputChanged;
        public event SwitcherInputEventHandler DM1InputChanged;
        public event SwitcherInputEventHandler DM2InputChanged;


        private ControlSystem DMPS4K150C_ControlSystem;

        //Singleton
        private static DMPS4K150C_SwitcherInput _SwitcherInput;


        public static DMPS4K150C_SwitcherInput GetDMPS4K150C_SwitcherInput(ControlSystem DMPS4K150C_ControlSystem)
        {
            return _SwitcherInput ?? (_SwitcherInput = new DMPS4K150C_SwitcherInput(DMPS4K150C_ControlSystem));
        }

        private DMPS4K150C_SwitcherInput(ControlSystem DMPS4K150C_ControlSystem)
        {
            TestControlSystemType.isDMPS4K150C(DMPS4K150C_ControlSystem, "This Module is for a DMPS4K150C Control System");

            this.DMPS4K150C_ControlSystem = DMPS4K150C_ControlSystem;

            DMPS4K150C_ControlSystem.DMInputChange += new DMInputEventHandler(DMPS4K150ControlSystem_DMInputChange);
        }
        
        void DMPS4K150ControlSystem_DMInputChange(Switch device, DMInputEventArgs args)
        {
            var InputSlotChanged = args.Number;
            switch (InputSlotChanged)
            {
                case (int)ControlSystem.eDmps34K150CInputs.Vga1:
                    if (VGA1InputChanged != null) VGA1InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Vga2:
                    if (VGA2InputChanged != null) VGA2InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Vga3:
                    if (VGA3InputChanged != null) VGA3InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Vga4:
                    if (VGA4InputChanged != null) VGA4InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi1:
                    if (HDMI1InputChanged != null) HDMI1InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi2:
                    if (HDMI2InputChanged != null) HDMI2InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi3:
                    if (HDMI3InputChanged != null) HDMI3InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Hdmi4:
                    if (HDMI4InputChanged != null) HDMI4InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Dm1:
                    if (DM1InputChanged != null) DM1InputChanged(args.Stream, args);
                    break;
                case (int)ControlSystem.eDmps34K150CInputs.Dm2:
                    if (DM1InputChanged != null) DM2InputChanged(args.Stream, args);
                    break;

                default:
                    break;
            }
        }
    }
}