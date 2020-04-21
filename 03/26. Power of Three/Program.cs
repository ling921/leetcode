using System;

namespace _26._Power_of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 0, 1, 3, 7, 9, 12, 27, 81 };
            foreach (var n in nums)
                Console.WriteLine($"{n} is power of three? : {solution.IsPowerOfThree(n)}");

            Console.Read();
        }
    }
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            while (n > 1)
            {
                if(n % 3 == 0)
                    n /= 3;
                else
                    return false;
            }
            return true;
        }
    }
}
