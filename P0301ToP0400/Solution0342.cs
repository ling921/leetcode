using System;

namespace P0301ToP0400
{
    /// <summary>
    /// 342. Power of Four
    /// </summary>
    public class Solution0342
    {
        public Solution0342()
        {
            int[] nums = { 0, 1, 2, 3, 4, 6, 7, 8, 12, 16, 256, 1024, 2046 };

            foreach (var n in nums)
                Console.WriteLine($"{n} is power of two? : {IsPowerOfFour(n)}");

            Console.Read();
        }

        public bool IsPowerOfFour(int num)
        {
            if (num <= 0)
                return false;
            else if (num == 1)
                return true;
            else if ((num >> 2 << 2) != num)
                return false;
            else
                return IsPowerOfFour(num >> 2);
        }
    }
}
