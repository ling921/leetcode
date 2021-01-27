using System;
using System.Collections.Generic;

namespace P0001ToP0100
{
    /// <summary>
    /// 30. Substring with Concatenation of All Words
    /// </summary>
    public class Solution0030
    {
        public Solution0030()
        {
            string[] words = { };
            string s = "";
            foreach (var item in FindSubstring(s, words))
                Console.Write(item);
            Console.Read();
        }

        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> result = new List<int>();

            return result;
        }

        private int FirstIndex(string s, string search)
        {
            for (int i = 0; i < s.Length - search.Length; i++)
                if (s.Substring(i, search.Length) == search)
                    return i;
            return -1;
        }

        private int LastIndex(string s, string search)
        {
            for (int i = s.Length - 1; i >= search.Length - 1; i--)
                if (s.Substring(i - search.Length, search.Length) == search)
                    return i;
            return -1;
        }
    }
}
