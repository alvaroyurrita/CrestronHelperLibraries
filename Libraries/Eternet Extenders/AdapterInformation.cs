using System;
using System.Text.RegularExpressions;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       				// For Basic SIMPL#Pro classes

namespace Eternet_Extenders
{
    public class AdapterInformation
    {
        #region public properties and events
        public event Action<bool> StartupDHCP_State_F_Changed;
        public bool StartupDHCP_State_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_STARTUP_DHCP_STATUS, AdapterId) == "ON"? true: false; }
            private set { if (StartupDHCP_State_F_Changed != null) StartupDHCP_State_F_Changed(StartupDHCP_State_F); }
        }
        public event Action<bool> CurrentDHCP_State_F_Changed;
        public bool CurrentDHCP_State_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_CURRENT_DHCP_STATE, AdapterId) == "ON" ? true : false; }
            private set { if (CurrentDHCP_State_F_Changed != null) CurrentDHCP_State_F_Changed(CurrentDHCP_State_F); }
        }
        public event Action<bool> LinkStatus_F_Changed;
        public bool LinkStatus_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_LINK_STATUS, AdapterId) == "ON" ? true : false; }
            private set { if (LinkStatus_F_Changed != null) LinkStatus_F_Changed(LinkStatus_F); }
        }
        public event Action<bool> EthernetStatus_F_Changed;
        public bool EthernetStatus_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_ETHERNET_STATUS, AdapterId) == "ON" ? true : false; }
            private set { if (EthernetStatus_F_Changed != null) EthernetStatus_F_Changed(EthernetStatus_F); }
        }
        public event Action<bool> Webserver_Status_F_Changed;
        public bool Webserver_Status_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_WEBSERVER_STATUS, AdapterId) == "ON" ? true : false; }
            private set { if (Webserver_Status_F_Changed != null) Webserver_Status_F_Changed(Webserver_Status_F); }
        }
        public event Action<bool> SSL_SelfOn_F_Changed;
        public bool SSL_SelfOn_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_SELF_STATUS, AdapterId) == "ON" ? true : false; }
            private set { if (SSL_SelfOn_F_Changed != null) SSL_SelfOn_F_Changed(SSL_SelfOn_F); }
        }
        public event Action<bool> SSL_CA_On_F_Changed;
        public bool SSL_CA_On_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_CA_STATUS, AdapterId) == "ON" ? true : false; }
            private set { if (SSL_CA_On_F_Changed != null) SSL_CA_On_F_Changed(EthernetStatus_F); }
        }
        public event Action<bool> SSL_Off_F_Changed;
        public bool SSL_Off_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId) == "ON" ? true : false; }
            private set { if (SSL_Off_F_Changed != null) SSL_Off_F_Changed(SSL_Off_F); }
        }

        public event Action<string> StaticIPAddress_F_Changed;
        public string StaticIPAddress_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_STATIC_IPADDRESS, AdapterId); }
            private set { if (StaticIPAddress_F_Changed != null) StaticIPAddress_F_Changed(StaticIPAddress_F); }
        }
        public event Action<string> CurrentIPAddress_F_Changed;
        public string CurrentIPAddress_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_CURRENT_IP_ADDRESS, AdapterId); }
            private set { if (CurrentIPAddress_F_Changed != null) CurrentIPAddress_F_Changed(CurrentIPAddress_F); }
        }
        public event Action<string> StaticNetMask_F_Changed;
        public string StaticNetMask_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_STATIC_IPMASK, AdapterId); }
            private set { if (StaticNetMask_F_Changed != null) StaticNetMask_F_Changed(StaticNetMask_F); }
        }
        public event Action<string> CurrentNetMask_F_Changed;
        public string CurrentNetMask_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_CURRENT_IP_MASK, AdapterId); }
            private set { if (CurrentNetMask_F_Changed != null) CurrentNetMask_F_Changed(CurrentNetMask_F); }
        }
        public event Action<string> StaticDefaultRouter_F_Changed;
        public string StaticDefaultRouter_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_STATIC_ROUTER, AdapterId); }
            private set { if (StaticDefaultRouter_F_Changed != null) StaticDefaultRouter_F_Changed(StaticDefaultRouter_F); }
        }
        public event Action<string> CurrentDefaultRouter_F_Changed;
        public string CurrentDefaultRouter_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_CURRENT_ROUTER, AdapterId); }
            private set { if (CurrentDefaultRouter_F_Changed != null) CurrentDefaultRouter_F_Changed(CurrentDefaultRouter_F); }
        }
        public event Action<string> HostName_F_Changed;
        public string HostName_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_HOSTNAME, AdapterId); }
            private set { if (HostName_F_Changed != null) HostName_F_Changed(HostName_F); }
        }
        public event Action<string> DomainName_F_Changed;
        public string DomainName_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_DOMAIN_NAME, AdapterId); }
            private set { if (DomainName_F_Changed != null) DomainName_F_Changed(DomainName_F); }
        }
        public event Action<string> DNS_Server_1_F_Changed;
        public string DNS_Server_1_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_DNS_SERVER(, AdapterId); }
            private set { if (DNS_Server_1_F_Changed != null) DNS_Server_1_F_Changed(DNS_Server_1_F); }
        }
        public event Action<string> DNS_Server_2_F_Changed;
        public string DNS_Server_2_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (DNS_Server_2_F_Changed != null) DNS_Server_2_F_Changed(DNS_Server_2_F); }
        }
        public event Action<string> DNS_Server_3_F_Changed;
        public string DNS_Server_3_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (DNS_Server_3_F_Changed != null) DNS_Server_3_F_Changed(DNS_Server_3_F); }
        }
        public event Action<string> MAC_Address_F_Changed;
        public string MAC_Address_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (MAC_Address_F_Changed != null) MAC_Address_F_Changed(MAC_Address_F); }
        }
        public event Action<string> CIP_Port_F_Changed;
        public string CIP_Port_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (CIP_Port_F_Changed != null) CIP_Port_F_Changed(CIP_Port_F); }
        }
        public event Action<string> SecureCIP_Port_Changed;
        public string SecureCIP_Port_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (SecureCIP_Port_Changed != null) SecureCIP_Port_Changed(SecureCIP_Port_F); }
        }
        public event Action<string> CTP_Port_F_Changed;
        public string CTP_Port_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (CTP_Port_F_Changed != null) CTP_Port_F_Changed(CTP_Port_F); }
        }
        public event Action<string> SecureCTP_Port_F_Changed;
        public string SecureCTP_Port_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (SecureCTP_Port_F_Changed != null) SecureCTP_Port_F_Changed(SecureCTP_Port_F); }
        }
        public event Action<string> WebPort_F_Changed;
        public string WebPort_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (WebPort_F_Changed != null) WebPort_F_Changed(WebPort_F); }
        }
        public event Action<string> SecureWebPort_F_Changed;
        public string SecureWebPort_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (SecureWebPort_F_Changed != null) SecureWebPort_F_Changed(SecureWebPort_F); }
        }
        public event Action<string> SSL_CertificateType_F_Changed;
        public string SSL_CertificateType_F
        {
            get { return CrestronEthernetHelper.GetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_GET.GET_SSL_OFF_STATUS, AdapterId); }
            private set { if (SSL_CertificateType_F_Changed != null) SSL_CertificateType_F_Changed(SSL_CertificateType_F); }
        }

        #endregion

        #region Public Methods

        public void Retrigger()
        {
            StartupDHCP_State_F = false;
            CurrentDHCP_State_F = false;
            LinkStatus_F = false;
            EthernetStatus_F = false;
            Webserver_Status_F = false;
            SSL_SelfOn_F = false;
            SSL_CA_On_F = false;
            SSL_Off_F = false;
            StaticIPAddress_F = "";
            CurrentIPAddress_F = "";
            StaticNetMask_F = "";
            CurrentNetMask_F = "";
            StaticDefaultRouter_F = "";
            CurrentDefaultRouter_F = "";
            HostName_F = "";
            DomainName_F  = "";
            DNS_Server_1_F = "";
            DNS_Server_2_F = "";
            DNS_Server_3_F = "";
            MAC_Address_F = "";
            CIP_Port_F = "";
            SecureCIP_Port_F = "";
            CTP_Port_F = "";
            SecureCTP_Port_F = "";
            WebPort_F = "";
            SecureWebPort_F = "";
            SSL_CertificateType_F = "";
        }

        public void DHCP_On() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_DHCP_STATE, AdapterId, "ON"); }
        public void DHCP_Off() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_DHCP_STATE, AdapterId, "OFF"); }
        public void Webserver_On() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_WEBSERVER_STATE, AdapterId, "ON"); }
        public void Webserver_Off() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_WEBSERVER_STATE, AdapterId, "OFF"); }
        public void SSL_SelfOn() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_SSL_STATE, AdapterId, "SELF"); }
        public void SSL_CA_On() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_SSL_STATE, AdapterId, "CA"); }
        public void SSL_Off() { CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_SSL_STATE, AdapterId, "OFF"); }

        public void StaticIPAddress(string Address)
        {
            if (!CheckIP(Address)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_STATIC_IPADDRESS, AdapterId, Address);
        }
        public void StaticNetMask(string Address)
        {
            if (!CheckIP(Address)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_STATIC_IPMASK, AdapterId, Address);
        }
        public void StaticDefaultRouter(string Address)
        {
            if (!CheckIP(Address)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_STATIC_DEFROUTER, AdapterId, Address);
        }
        public void HostName(string Name)
        {
            if (!CheckHostName(Name)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_HOSTNAME, AdapterId, Name);
        }
        public void DomainName(string Name)
        {
            if (!CheckDomainName(Name)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_DOMAINNAME, AdapterId, Name);
        }
        public void AddDNS_Server(string Address)
        {
            if (!CheckIP(Address)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.ADD_DNS_SERVER, AdapterId, Address);
        }
        public void RemoveDNS_Server(string Address)
        {
            if (!CheckIP(Address)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.REMOVE_DNS_SERVER, AdapterId, Address);
        }
        public void CIP_Port(string Port)
        {
            if (!CheckCrestronPort(Port)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_CIP_PORT, AdapterId, Port);
        }
        public void SecureCIP_Port(string Port)
        {
            if (!CheckCrestronPort(Port)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_SECURE_CIP_PORT, AdapterId, Port);
        }
        public void CTP_Port(string Port)
        {
            if (!CheckCrestronPort(Port)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_CTP_PORT, AdapterId, Port);
        }
        public void SecureCTP_Port(string Port)
        {
            if (!CheckCrestronPort(Port)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_SECURE_CTP_PORT, AdapterId, Port);
        }
        public void WebPort(string Port)
        {
            if (!CheckCrestronPort(Port)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_WEB_PORT, AdapterId, Port);
        }
        public void SecureWebPort(string Port)
        {
            if (!CheckCrestronPort(Port)) return;
            CrestronEthernetHelper.SetEthernetParameter(CrestronEthernetHelper.ETHERNET_PARAMETER_TO_SET.SET_SECURE_WEB_PORT, AdapterId, Port);
        }

        #endregion
        #region Private Fields
        internal short AdapterId = 1;
        private static AdapterInformation _AdapterInformation;
        #endregion


        public bool CheckIP(string IPAddress)
        {
            return true;
        }

        public bool CheckHostName(string HostName)
        {
            return true;
        }
        public bool CheckDomainName(string HostName)
        {
            return true;
        }

        public bool CheckCrestronPort(string MacAddress)
        {
            return true;
        }

        public static AdapterInformation GetAdapterInformation()
        {
            return _AdapterInformation ?? (_AdapterInformation = new AdapterInformation());
        }


        private AdapterInformation()
        {
            //this.AdapterId = AdapterId;
        }

    }
}

