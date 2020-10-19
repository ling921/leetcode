using System;

namespace P0601ToP0700
{
    /// <summary>
    /// 628. Maximum Product of Three Numbers
    /// </summary>
    public class Solution0628
    {
        public Solution0628()
        {
            Console.WriteLine();
        }

        public int MaximumProduct(int[] nums)
        {
            int a, b, c, d, e;
            a = b = c = int.MinValue;
            d = e = int.MaxValue;
            foreach (var num in nums)
            {
                if (num > a)
                {
                    c = b;
                    b = a;
                    a = num;
                }
                else if (num > b)
                {
                    c = b;
                    b = num;
                }
                else if (num > c)
                    c = num;

                if (num < d)
                {
                    e = d;
                    d = num;
                }
                else if (num < e)
                    e = num;
            }
            return Math.Max(a * b * c, a * d * e);
        }
    }
}
