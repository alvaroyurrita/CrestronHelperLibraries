using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Eternet_Extenders;

namespace CP3_CP3N.Test_Components
{
    public static class TestEthernetInformation
    {
        static AdapterInformation _AdapterInformation;
        static public void Start(AdapterInformation AdapterInfo)
        {
            _AdapterInformation = AdapterInfo;


            _AdapterInformation.CIP_Port_F_Changed += value => CrestronConsole.PrintLine("CIP_Port_F_Changed  :{0}", value);
            _AdapterInformation.CTP_Port_F_Changed += value => CrestronConsole.PrintLine("CTP_Port_F_Changed  :{0}", value);
            _AdapterInformation.CurrentDefaultRouter_F_Changed += value => CrestronConsole.PrintLine("CurrentDefaultRouter_F_Changed  :{0}", value);
            _AdapterInformation.CurrentDHCP_State_F_Changed += value => CrestronConsole.PrintLine("CurrentDHCP_State_F_Changed  :{0}", value);
            _AdapterInformation.CurrentIPAddress_F_Changed += value => CrestronConsole.PrintLine("CurrentIPAddress_F_Changed  :{0}", value);
            _AdapterInformation.CurrentNetMask_F_Changed += value => CrestronConsole.PrintLine("CurrentNetMask_F_Changed  :{0}", value);
            _AdapterInformation.DNS_Server_1_F_Changed += value => CrestronConsole.PrintLine("DNS_Server_1_F_Changed  :{0}", value);
            _AdapterInformation.DNS_Server_2_F_Changed += value => CrestronConsole.PrintLine("DNS_Server_2_F_Changed  :{0}", value);
            _AdapterInformation.DNS_Server_3_F_Changed += value => CrestronConsole.PrintLine("DNS_Server_3_F_Changed  :{0}", value);
            _AdapterInformation.DomainName_F_Changed += value => CrestronConsole.PrintLine("DomainName_F_Changed  :{0}", value);
            _AdapterInformation.EthernetStatus_F_Changed += value => CrestronConsole.PrintLine("EthernetStatus_F_Changed  :{0}", value);
            _AdapterInformation.HostName_F_Changed += value => CrestronConsole.PrintLine("HostName_F_Changed  :{0}", value);
            _AdapterInformation.LinkStatus_F_Changed += value => CrestronConsole.PrintLine("LinkStatus_F_Changed  :{0}", value);
            _AdapterInformation.MAC_Address_F_Changed += value => CrestronConsole.PrintLine("MAC_Address_F_Changed  :{0}", value);
            _AdapterInformation.SecureCIP_Port_Changed += value => CrestronConsole.PrintLine("SecureCIP_Port_Changed  :{0}", value);
            _AdapterInformation.SecureCTP_Port_F_Changed += value => CrestronConsole.PrintLine("SecureCTP_Port_F_Changed  :{0}", value);
            _AdapterInformation.SecureWebPort_F_Changed += value => CrestronConsole.PrintLine("SecureWebPort_F_Changed  :{0}", value);
            _AdapterInformation.SSL_CA_On_F_Changed += value => CrestronConsole.PrintLine("SSL_CA_On_F_Changed  :{0}", value);
            _AdapterInformation.SSL_CertificateType_F_Changed += value => CrestronConsole.PrintLine("SSL_CertificateType_F_Changed  :{0}", value);
            _AdapterInformation.SSL_Off_F_Changed += value => CrestronConsole.PrintLine("SSL_Off_F_Changed  :{0}", value);
            _AdapterInformation.SSL_SelfOn_F_Changed += value => CrestronConsole.PrintLine("SSL_SelfOn_F_Changed  :{0}", value);
            _AdapterInformation.StartupDHCP_State_F_Changed += value => CrestronConsole.PrintLine("StartupDHCP_State_F_Changed :{0}", value);
            _AdapterInformation.StaticDefaultRouter_F_Changed += value => CrestronConsole.PrintLine("StaticDefaultRouter_F_Changed  :{0}", value);
            _AdapterInformation.StaticIPAddress_F_Changed += value => CrestronConsole.PrintLine("StaticIPAddress_F_Changed  :{0}", value);
            _AdapterInformation.StaticNetMask_F_Changed += value => CrestronConsole.PrintLine("StaticNetMask_F_Changed  :{0}", value);
            _AdapterInformation.WebPort_F_Changed += value => CrestronConsole.PrintLine("WebPort_F_Changed  :{0}", value);
            _AdapterInformation.Webserver_Status_F_Changed += value => CrestronConsole.PrintLine("Webserver_Status_F_Changed  :{0}", value);


            CrestronConsole.AddNewConsoleCommand(EthernetInfo, "TEthernetInfo", "Show all Etherner Properties", ConsoleAccessLevelEnum.AccessOperator);
            CrestronConsole.AddNewConsoleCommand(Retrigger, "TEtherInfoRetrig", "Retrigger Ethernet Info", ConsoleAccessLevelEnum.AccessOperator);
        }
        static void EthernetInfo(string message)
        {
            CrestronConsole.PrintLine("StartupDHCP_State_F:  {0}", _AdapterInformation.StartupDHCP_State_F);
            CrestronConsole.PrintLine("CurrentDHCP_State_F:  {0}", _AdapterInformation.CurrentDHCP_State_F);
            CrestronConsole.PrintLine("LinkStatus_F:  {0}", _AdapterInformation.LinkStatus_F);
            CrestronConsole.PrintLine("EthernetStatus_F:  {0}", _AdapterInformation.EthernetStatus_F);
            CrestronConsole.PrintLine("Webserver_Status_F:  {0}", _AdapterInformation.Webserver_Status_F);
            CrestronConsole.PrintLine("SSL_SelfOn_F:  {0}", _AdapterInformation.SSL_SelfOn_F);
            CrestronConsole.PrintLine("SSL_CA_On_F:  {0}", _AdapterInformation.SSL_CA_On_F);
            CrestronConsole.PrintLine("SSL_Off_F:  {0}", _AdapterInformation.SSL_Off_F);
            CrestronConsole.PrintLine("StaticIPAddress_F:  {0}", _AdapterInformation.StaticIPAddress_F);
            CrestronConsole.PrintLine("CurrentIPAddress_F:  {0}", _AdapterInformation.CurrentIPAddress_F);
            CrestronConsole.PrintLine("StaticNetMask_F:  {0}", _AdapterInformation.StaticNetMask_F);
            CrestronConsole.PrintLine("CurrentNetMask_F:  {0}", _AdapterInformation.CurrentNetMask_F);
            CrestronConsole.PrintLine("StaticDefaultRouter_F:  {0}", _AdapterInformation.StaticDefaultRouter_F);
            CrestronConsole.PrintLine("CurrentDefaultRouter_F:  {0}", _AdapterInformation.CurrentDefaultRouter_F);
            CrestronConsole.PrintLine("HostName_F:  {0}", _AdapterInformation.HostName_F);
            CrestronConsole.PrintLine("DomainName_F:  {0}", _AdapterInformation.DomainName_F);
            CrestronConsole.PrintLine("DNS_Server_1_F:  {0}", _AdapterInformation.DNS_Server_1_F);
            CrestronConsole.PrintLine("DNS_Server_2_F:  {0}", _AdapterInformation.DNS_Server_2_F);
            CrestronConsole.PrintLine("DNS_Server_3_F:  {0}", _AdapterInformation.DNS_Server_3_F);
            CrestronConsole.PrintLine("MAC_Address_F:  {0}", _AdapterInformation.MAC_Address_F);
            CrestronConsole.PrintLine("CIP_Port_F:  {0}", _AdapterInformation.CIP_Port_F);
            CrestronConsole.PrintLine("SecureCTP_Port:  {0}", _AdapterInformation.CTP_Port_F);
            CrestronConsole.PrintLine("CTP_Port_F:  {0}", _AdapterInformation.CTP_Port_F);
            CrestronConsole.PrintLine("SecureCTP_Port_F:  {0}", _AdapterInformation.SecureCTP_Port_F);
            CrestronConsole.PrintLine("WebPort_F:  {0}", _AdapterInformation.WebPort_F);
            CrestronConsole.PrintLine("SecureWebPort_F:  {0}", _AdapterInformation.SecureWebPort_F);
            CrestronConsole.PrintLine("SSL_CertificateType_F:  {0}", _AdapterInformation.SSL_CertificateType_F);
        }
        static void Retrigger(string message)
        {
            _AdapterInformation.Retrigger();
        }
    }
}