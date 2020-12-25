using System;
using System.Collections.Generic;
using System.Text;

namespace P0701ToP0800
{
    /// <summary>
    /// 791. Custom Sort String
    /// </summary>
    public class Solution0791
    {
        public Solution0791()
        {
            Console.WriteLine(CustomSortString("cba", "abcd"));
        }

        public string CustomSortString(string S, string T)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (var c in S)
                letters[c] = 0;
            foreach (var c in T)
            {
                if (letters.ContainsKey(c))
                    letters[c]++;
                else
                    letters[c] = 1;
            }

            var sb = new StringBuilder();
            foreach (var pair in letters)
            {
                int times = pair.Value;
                while (times > 0)
                {
                    sb.Append(pair.Key);
                    times--;
                }
            }
            return sb.ToString();
        }
    }
}
