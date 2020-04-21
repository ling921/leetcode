using System;

namespace _80._Valid_Palindrome_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
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
