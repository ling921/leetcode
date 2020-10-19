namespace P0101ToP0200
{
    /// <summary>
    /// 125. Valid Palindrome
    /// </summary>
    public class Solution0125
    {
        public Solution0125()
        {

        }

        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 2)
                return true;
            int l = 0, r = s.Length - 1;
            s = s.ToLower();
            while (l < r)
            {
                if ((s[l] < 'a' || s[l] > 'z') && (s[l] < '0' || s[l] > '9'))
                {
                    l++;
                    continue;
                }
                if ((s[r] < 'a' || s[r] > 'z') && (s[r] < '0' || s[r] > '9'))
                {
                    r--;
                    continue;
                }
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
