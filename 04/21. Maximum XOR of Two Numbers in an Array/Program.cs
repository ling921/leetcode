using System;

namespace _21._Maximum_XOR_of_Two_Numbers_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 10, 5, 25, 2, 8 };
            Solution solution = new Solution();
            Console.WriteLine(solution.FindMaximumXOR(nums));

            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int FindMaximumXOR(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    max = Math.Max(max, nums[i] ^ nums[j]);
            return max;
        }
    }
}