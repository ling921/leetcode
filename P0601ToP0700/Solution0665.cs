using System;

namespace P0601ToP0700
{
    /// <summary>
    /// 665. Non-decreasing Array
    /// </summary>
    public class Solution0665
    {
        public Solution0665()
        {
            int[] nums = { 2, 3, 4, 2, 4 };
            Console.WriteLine(CheckPossibility(nums));
        }

        public bool CheckPossibility(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (i != 0 && nums[i - 1] > nums[i + 1] && i != nums.Length - 2 && nums[i] > nums[i + 2])
                        return false;
                    if (++count > 1)
                        return false;
                }
            }
            return true;
        }
    }
}
