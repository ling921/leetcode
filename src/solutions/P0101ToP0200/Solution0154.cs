namespace P0101ToP0200
{
    /// <summary>
    /// 154. Find Minimum in Rotated Sorted Array II
    /// </summary>
    public class Solution0154
    {
        public Solution0154()
        {
            //int[] nums = { 0, 1, 2, 3, 4, 5, 6 };
            //int[] nums = { 3, 4, 5, 6, 0, 1, 2 };
            //int[] nums = { 3, 1, 3 };
            int[] nums = { 1, 1 };

            Console.WriteLine(FindMin(nums));

            Console.Read();
        }

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
