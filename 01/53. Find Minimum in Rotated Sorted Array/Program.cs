using System;

namespace _53._Find_Minimum_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int left = 0, right = nums.Length - 1, mid = (left + right + 1) / 2;
            while (left < right)
            {
                if (nums[left] < nums[right])
                    return nums[left];
                else
                {
                    if (nums[left] < nums[mid])
                        left = mid + 1;
                    else
                        right = mid;
                    mid = (left + right + 1) / 2;
                }
                if (left + 1 == right)
                    return nums[left] < nums[right] ? nums[left] : nums[right];
            }
            return nums[left];
        }
    }
}
