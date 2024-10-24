using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP_client_Project
{
    public enum NICType
    {
        Ethernet,
        TokenRing
    }
    public class NIC
    {
        private static NIC instance = null;
        public string Manufacturer { get; private set; }
        public string MACAddress { get; private set; }
        public NICType Type { get; private set; }

        private NIC(string manufacturer, string macAddress, NICType type)
        {
            Manufacturer = manufacturer;
            MACAddress = macAddress;
            Type = type;
        }
        public static NIC GetInstance(string manufacturer, string macAddress, NICType type)
        {
            
            if (instance == null)
            {
                               
                if (instance == null)
                {
                    instance = new NIC(manufacturer, macAddress, type);
                }
                
            }
            return instance;
        }

        public override string ToString()
        {
            return $"NIC Details:\nManufacturer: {Manufacturer}\nMAC Address: {MACAddress}\nType: {Type}";
        }
    }
}
