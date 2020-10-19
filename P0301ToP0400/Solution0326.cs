using System;

namespace P0301ToP0400
{
    /// <summary>
    /// 326. Power of Three
    /// </summary>
    public class Solution0326
    {
        public Solution0326()
        {
            int[] nums = { 0, 1, 3, 7, 9, 12, 27, 81 };
            foreach (var n in nums)
                Console.WriteLine($"{n} is power of three? : {IsPowerOfThree(n)}");

            Console.Read();
        }

        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            while (n > 1)
            {
                if (n % 3 == 0)
                    n /= 3;
                else
                    return false;
            }
            return true;
        }
    }
}
