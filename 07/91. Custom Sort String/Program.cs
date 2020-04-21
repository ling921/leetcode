using System;
using System.Collections.Generic;
using System.Text;

namespace _91._Custom_Sort_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().CustomSortString("cba", "abcd"));

            Console.ReadLine();
        }
    }
    public class Solution
    {
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
                
            StringBuilder sb = new StringBuilder();
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
