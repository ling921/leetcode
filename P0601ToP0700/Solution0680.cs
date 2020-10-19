using System;

namespace P0601ToP0700
{
    /// <summary>
    /// 680. Valid Palindrome II
    /// </summary>
    public class Solution0680
    {
        public Solution0680()
        {
            Console.WriteLine();
        }

        public bool ValidPalindrome(string s)
        {
            if (s.Length < 3)
                return true;
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                }
                else
                    return IsPalindrome(s.Substring(l, s.Length - 2 * l - 1))
                        || IsPalindrome(s.Substring(l + 1, s.Length - 2 * l - 1));
            }
            return true;

        }
        public bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
