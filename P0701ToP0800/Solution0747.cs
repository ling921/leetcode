using System;

namespace P0701ToP0800
{
    /// <summary>
    /// 747. Largest Number At Least Twice of Others
    /// </summary>
    public class Solution0747
    {
        public Solution0747()
        {
            Console.WriteLine();
        }

        public int DominantIndex(int[] nums)
        {
            bool isMoreThanTwice = false;
            int index = -1, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 2 * max)
                {
                    max = nums[i];
                    index = i;
                    isMoreThanTwice = true;
                }
                else if (nums[i] >= max)
                {
                    max = nums[i];
                    index = i;
                    isMoreThanTwice = false;
                }
                else if (nums[i] * 2 > max)
                {
                    isMoreThanTwice = false;
                }
            }
            return isMoreThanTwice ? index : -1;
        }
    }
}
