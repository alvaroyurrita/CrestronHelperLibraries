using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharp;

namespace Relays
{
    public class Relays2Card
    {
        #region public properties and events

        #region Relay1
        public event Action<bool> A1_F_Changed;
        public bool A1 { set { SetRelayState(1, value); } }
        public bool A1_F { get { return (GetRelayState(1)); } }
        #endregion

        #region Relay2
        public event Action<bool> A2_F_Changed;
        public bool A2 { set { SetRelayState(2, value); } }
        public bool A2_F { get { return (GetRelayState(2)); } }
        #endregion
        #endregion


        #region Private Methods
        void SetRelayState(int Index, bool state) { Relays[Index - 1].RelayState = state; }
        bool GetRelayState(int Index) { return Relays[Index - 1].RelayState; }

        #endregion


        private static List<SingleRelay> Relays = new List<SingleRelay>();
        private static CrestronCollection<Relay> _Relays;
        private static Relays2Card _Relay8Card;

        public static Relays2Card GetRelay2Card(CrestronCollection<Relay> Relays)
        {
            if (Relays.Count != 2) return null;
            return _Relay8Card ?? (_Relay8Card = new Relays2Card(Relays));
        }

        private Relays2Card(CrestronCollection<Relay> Relays)
        {
            if (Relays.Count != 2) return;
            _Relays = Relays;
            CreateRelays();
            SubscribeRelayChanged();

        }

        void CreateRelays()
        {
            foreach (Relay Rly in _Relays)
            {
                Relays.Add(new SingleRelay(Rly));
            }
        }

        void SubscribeRelayChanged()
        {
            Relays[0].RelayStateChanged += (rly, value) => { if (A1_F_Changed != null) A1_F_Changed(value); };
            Relays[1].RelayStateChanged += (rly, value) => { if (A2_F_Changed != null) A2_F_Changed(value); };
        }


    }
}