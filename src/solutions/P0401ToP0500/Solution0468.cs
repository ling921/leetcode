using System.Globalization;

namespace P0401ToP0500
{
    /// <summary>
    /// 468. Validate IP Address
    /// </summary>
    public class Solution0468
    {
        public Solution0468()
        {
            Console.WriteLine();
        }

        public string ValidIPAddress(string IP)
        {
            if (IP.Contains('.'))
                if (IsIPv4(IP))
                    return "IPv4";
                else if (IP.Contains(':'))
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
                    if (i.Length > 0 && i.Length <= 3)
                    {
                        var result = int.TryParse(i, out int temp);
                        if (!result || temp < 0 || temp > 255)
                            return false;
                    }
                    else
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
                    if (i.Length > 0 && i.Length <= 4)
                    {
                        var result = int.TryParse(i, NumberStyles.HexNumber, default, out int temp);
                        if (!result || temp < 0 || temp > 65535)
                            return false;
                    }
                    else
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
