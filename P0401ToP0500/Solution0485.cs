using System;

namespace P0401ToP0500
{
    /// <summary>
    /// 485. Max Consecutive Ones
    /// </summary>
    public class Solution0485
    {
        public Solution0485()
        {
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine($"最大连续1的个数为：{FindMaxConsecutiveOnes(nums)}");
        }

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
