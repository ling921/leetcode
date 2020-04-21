using System;

namespace _28._Implement_strStr__
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            return -1;
        }
    }
}
