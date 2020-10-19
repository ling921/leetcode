using System;

namespace P0401ToP0500
{
    /// <summary>
    /// 421. Maximum XOR of Two Numbers in an Array
    /// </summary>
    public class Solution0421
    {
        public Solution0421()
        {
            int[] nums = { 2, 10, 5, 25, 2, 8 };
            Console.WriteLine(FindMaximumXOR(nums));
        }

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
