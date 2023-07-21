namespace P0001ToP0100
{
    /// <summary>
    /// 9. 回文数
    /// </summary>
    public class Solution0009
    {
        public Solution0009()
        {
            var x = 121;
            WriteLine(IsPalindrome(x));
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            int rx = x % 10, temp = x / 10;
            while (temp > 0)
            {
                rx = rx * 10 + temp % 10;
                temp /= 10;
            }
            return x == rx;
        }

        public bool IsPalindrome1(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            var str = x.ToString();
            int l = 0, r = str.Length - 1;
            while (l < r)
            {
                if (str[l] != str[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }
}
