using System;

namespace P0201ToP0300
{
    /// <summary>
    /// 231. Power of Two
    /// </summary>
    public class Solution0231
    {
        public Solution0231()
        {
            int[] nums = { 0, 1, 2, 3, 4, 6, 7, 8, 12, 16, 256, 1024, 2046 };

            foreach (var n in nums)
                Console.WriteLine($"{n} is power of two? : {IsPowerOfTwo(n)}");

            Console.Read();
        }

        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
                return false;
            else if (n == 1)
                return true;
            else if ((n >> 1 << 1) != n)
                return false;
            else
                return IsPowerOfTwo(n >> 1);
        }
    }
}
