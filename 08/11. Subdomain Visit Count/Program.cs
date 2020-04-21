using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Subdomain_Visit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int times = 0;
            string domain = null;
            string[] parts;
            foreach (var s in cpdomains)
            {
                times = Convert.ToInt32(s.Split(' ')[0]);
                parts = s.Split(' ')[1].Split('.');
                for (int i = 0; i < parts.Length; i++)
                {
                    domain = domain == null ? parts[parts.Length - 1 - i] : parts[parts.Length - 1 - i] + '.' + domain;
                    if (dic.ContainsKey(domain))
                        dic[domain] += times;
                    else
                        dic[domain] = times;
                }
                domain = null;
            }
            List<string> result = new List<string>();
            dic.ToList().ForEach(k => result.Add(k.Value.ToString() + " " + k.Key));
            return result;
        }
    }
}
