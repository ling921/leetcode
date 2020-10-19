using System;

namespace P0401ToP0500
{
    /// <summary>
    /// 409. Longest Palindrome
    /// </summary>
    public class Solution0409
    {
        public Solution0409()
        {
            string s = "abccccdd";
            //for (int i = 0; i < s.Length; i++)
            //    Console.WriteLine($"{s[i]}:{(int)s[i]}");
            Console.WriteLine(LongestPalindrome(s));
        }

        //a-z 65-90  A-Z 97-122
        public int LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int[] value = new int[58];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (++value[s[i] - 65] == 2)
                {
                    count += 2;
                    value[s[i] - 65] = 0;
                }
            }
            return count == s.Length ? count : count + 1;
        }
    }
}
