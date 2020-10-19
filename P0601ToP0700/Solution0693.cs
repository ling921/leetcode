using System;

namespace P0601ToP0700
{
    /// <summary>
    /// 693. Binary Number with Alternating Bits
    /// </summary>
    public class Solution0693
    {
        public Solution0693()
        {
            int n = 5;
            Console.WriteLine(HasAlternatingBits(n));
        }

        public bool HasAlternatingBits(int n)
        {
            if (n % 2 == (n >> 1) % 2)
                return false;
            if (n == 1)
                return true;
            return HasAlternatingBits((int)n >> 1);
            //return ((n ^ (n >> 1)) & ((n ^ (n >> 1)) + 1)) == 0;
        }
    }
}
