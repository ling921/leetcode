using System;
using System.Linq;

namespace _68._Validate_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string ValidIPAddress(string IP)
        {
            if (IP.Contains('.'))
                if (IsIPv4(IP))
                    return "IPv4";
            else if(IP.Contains(':'))
                if (IsIPv6(IP))
                    return "IPv6";
            return "Neither";
        }

        private bool IsIPv4(string ip)
        {
            string[] ips = ip.Split('.');
            if (ips.Length == 4)
            {
                foreach (var i in ips)
                {
                    int temp = Convert.ToInt32(i);
                    if ((i.Length > 1 && i[0] == '0') || i.Length == 0 || temp < 0 || temp > 255)
                        return false;
                }
                return true;
            }
            else
                return false;
        }

        private bool IsIPv6(string ip)
        {
            string[] ips = ip.Split(':');
            if (ips.Length == 8)
            {
                foreach (var i in ips)
                {
                    int temp = ;
                    if ((i.Length > 1 && i[0] == '0') || temp < 0 || temp > 255)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
