using static CommonLibrary.Extensions.ConsoleExtension;
using System;

namespace P1201ToP1300
{
    /// <summary>
    /// 1208. 尽可能使字符串相等
    /// </summary>
    public class Solution1208
    {
        public Solution1208()
        {
            var s = "krpgjbjjznpzdfy";
            var t = "nxargkbydxmsgby";
            var maxCount = 14;
            WriteLine(EqualSubstring(s, t, maxCount));
        }

        public int EqualSubstring(string s, string t, int maxCost)
        {
            int left = 0, right = 0, count = 0;
            while (right < s.Length)
            {
                while (count <= maxCost && right < s.Length)
                {
                    var temp = count + Math.Abs(s[right] - t[right]);
                    if (temp > maxCost)
                    {
                        break;
                    }
                    count = temp;
                    right++;
                }
                if (right == s.Length)
                    break;
                count += Math.Abs(s[right] - t[right]) - Math.Abs(s[left] - t[left]);
                left++;
                right++;
            }
            return right - left;
        }
    }
}