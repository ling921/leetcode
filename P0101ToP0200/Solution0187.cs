using System;
using System.Collections.Generic;

namespace P0101ToP0200
{
    /// <summary>
    /// 187. Repeated DNA Sequences
    /// </summary>
    public class Solution0187
    {
        public Solution0187()
        {
            //string s = "AAAAAAAAAAA";
            string s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            foreach (var str in FindRepeatedDnaSequences(s))
                Console.WriteLine(str);

            Console.Read();
        }

        public IList<string> FindRepeatedDnaSequences(string s)
        {
            if (s.Length <= 10)
                return new List<string>();
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
