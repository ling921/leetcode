using System;

namespace _31._Power_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4, 6, 7, 8, 12, 16, 256, 1024, 2046 };

            foreach (var n in nums)
                Console.WriteLine($"{n} is power of two? : {new Solution().IsPowerOfTwo(n)}");

            //Console.WriteLine(new Solution().IsPowerOfTwo(6));

            Console.Read();
        }
    }
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            else if (n == 1) return true;
            else if ((n >> 1 << 1) != n) return false;
            else return IsPowerOfTwo(n >> 1);
        }
    }
}
