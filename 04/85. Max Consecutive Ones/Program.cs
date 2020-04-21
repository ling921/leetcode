using System;

namespace _85._Max_Consecutive_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine($"最大连续1的个数为：{solution.FindMaxConsecutiveOnes(nums)}");
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    count++;
                if (nums[i] == 0 || i == nums.Length - 1)
                {
                    max = max > count ? max : count;
                    count = 0;
                }
            }
            return max;
        }
    }
}