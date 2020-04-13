using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes
using Crestron.SimplSharp;

namespace Relays
{
    public class Relays8Card
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

        #region Relay3
        public event Action<bool> A3_F_Changed;
        public bool A3 { set { SetRelayState(3, value); } }
        public bool A3_F { get { return (GetRelayState(3)); } }
        #endregion

        #region Relay4
        public event Action<bool> A4_F_Changed;
        public bool A4 { set { SetRelayState(4, value); } }
        public bool A4_F { get { return (GetRelayState(4)); } }
        #endregion

        #region Relay5
        public event Action<bool> A5_F_Changed;
        public bool A5 { set { SetRelayState(5, value); } }
        public bool A5_F { get { return (GetRelayState(5)); } }
        #endregion

        #region Relay6
        public event Action<bool> A6_F_Changed;
        public bool A6 { set { SetRelayState(6, value); } }
        public bool A6_F { get { return (GetRelayState(6)); } }
        #endregion

        #region Relay7
        public event Action<bool> A7_F_Changed;
        public bool A7 { set { SetRelayState(7, value); } }
        public bool A7_F { get { return (GetRelayState(7)); } }
        #endregion

        #region Relay8
        public event Action<bool> A8_F_Changed;
        public bool A8 { set { SetRelayState(8, value); } }
        public bool A8_F { get { return (GetRelayState(8)); } }
        #endregion

        #endregion


        #region Private Methods
        void SetRelayState(int Index, bool state) { Relays[Index - 1].RelayState = state; }
        bool GetRelayState(int Index) { return Relays[Index - 1].RelayState; }

        #endregion


        private static List<SingleRelay> Relays = new List<SingleRelay>();
        private static CrestronCollection<Relay> _Relays;
        private static Relays8Card _Relay8Card;

        public static Relays8Card GetRelay8Card(CrestronCollection<Relay> Relays)
        {
            if (Relays.Count != 8) return null;
            return _Relay8Card ?? (_Relay8Card = new Relays8Card(Relays));
        }

        private Relays8Card(CrestronCollection<Relay> Relays)
        {
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
            Relays[2].RelayStateChanged += (rly, value) => { if (A3_F_Changed != null) A3_F_Changed(value); };
            Relays[3].RelayStateChanged += (rly, value) => { if (A4_F_Changed != null) A4_F_Changed(value); };
            Relays[4].RelayStateChanged += (rly, value) => { if (A5_F_Changed != null) A5_F_Changed(value); };
            Relays[5].RelayStateChanged += (rly, value) => { if (A6_F_Changed != null) A6_F_Changed(value); };
            Relays[6].RelayStateChanged += (rly, value) => { if (A7_F_Changed != null) A7_F_Changed(value); };
            Relays[7].RelayStateChanged += (rly, value) => { if (A8_F_Changed != null) A8_F_Changed(value); };
        }


    }
}