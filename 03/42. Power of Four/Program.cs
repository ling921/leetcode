using System;

namespace _42._Power_of_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4, 6, 7, 8, 12, 16, 256, 1024, 2046 };

            foreach (var n in nums)
                Console.WriteLine($"{n} is power of two? : {new Solution().IsPowerOfFour(n)}");

            //Console.WriteLine(new Solution().IsPowerOfFour(6));

            Console.Read();
        }
    }
    public class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            if (num <= 0) return false;
            else if (num == 1) return true;
            else if ((num >> 2 << 2) != num) return false;
            else return IsPowerOfFour(num >> 2);
        }
    }
}
