using System;

namespace P0001ToP0100
{
    /// <summary>
    /// 33. Search in Rotated Sorted Array
    /// </summary>
    public class Solution0033
    {
        public Solution0033()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            Console.WriteLine(Search(nums, 0));

            Console.Read();
        }

        public int Search(int[] nums, int target)
        {
            return Search(nums, 0, nums.Length, target);
        }
        private int Search(int[] nums, int low, int high, int target)
        {
            if (low > high)
                return -1;
            int mid = (low + high) / 2;
            if (target == nums[mid])
                return mid;
            if (nums[low] < nums[mid])
            {
                if (target < nums[low] || target > nums[mid])
                    return Search(nums, mid + 1, high, target);
                else
                    return Search(nums, low, mid - 1, target);
            }
            else
            {
                if (target < nums[mid] || target > nums[high])
                    return Search(nums, low, mid - 1, target);
                else
                    return Search(nums, mid + 1, high, target);
            }
        }
    }
}
