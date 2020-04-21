using System;
using System.Collections.Generic;

namespace _87._Repeated_DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "AAAAAAAAAAA";
            string s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            foreach (var str in new Solution().FindRepeatedDnaSequences(s))
                Console.WriteLine(str);
            
            Console.Read();
        }
    }
    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            if (s.Length <= 10) return new List<string>();
            Dictionary<string, int> keys = new Dictionary<string, int>();
            List<string> results = new List<string>();
            for (int i = 0; i <= s.Length - 10; i++)
            {
                string str = s.Substring(i, 10);
                if (keys.ContainsKey(str))
                    keys[str]++;
                else
                    keys.Add(str, 1);
                if (keys[str] == 2)
                    results.Add(str);
            }
            return results;
        }
    }
}
