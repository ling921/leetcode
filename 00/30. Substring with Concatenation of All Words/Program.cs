using System;
using System.Collections.Generic;

namespace _30._Substring_with_Concatenation_of_All_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] words = { };
            string s = "";
            foreach (var item in solution.FindSubstring(s, words))
                Console.Write(item);
            Console.Read();
        }
    }
    public class Solution
    {
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
