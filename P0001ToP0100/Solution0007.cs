using System;

namespace P0001ToP0100
{
    /// <summary>
    /// 7. Reverse Integer
    /// </summary>
    public class Solution0007
    {
        public Solution0007()
        {
            var x = int.MinValue;
            Console.WriteLine(Reverse(x));
        }

        public int Reverse(int x)
        {
            bool negative = x < 0;
            x = negative ? -x : x;
            long reverse = 0;
            while (x > 0)
            {
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }
            reverse = negative ? -reverse : reverse;
            return reverse < int.MinValue || reverse > int.MaxValue ? 0 : (int)reverse;
        }
    }
}
