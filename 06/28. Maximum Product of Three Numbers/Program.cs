using System;

namespace _28._Maximum_Product_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Solution
    {
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
