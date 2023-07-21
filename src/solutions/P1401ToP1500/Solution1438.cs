namespace P1401ToP1500
{
    public class Solution1438
    {
        public Solution1438()
        {
            var nums = "[8,2,4,7]".ToArray<int>();
            var limit = 4;
            WriteLine(LongestSubarray(nums, limit));
        }

        public int LongestSubarray(int[] nums, int limit)
        {
            int max = nums[0], min = nums[0], left = 0, right = 0;
            while (right < nums.Length)
            {
                max = Math.Max(max, nums[right]);
                min = Math.Min(min, nums[right]);
                if (max - min > limit)
                {
                    left++;
                    if (max == nums[left - 1] && min == nums[left - 1])
                    {
                        max = min = nums[left];
                        for (int i = left + 1; i <= right; i++)
                        {
                            max = Math.Max(max, nums[i]);
                            min = Math.Min(min, nums[i]);
                        }
                    }
                    else if (max == nums[left - 1])
                    {
                        max = nums[left];
                        for (int i = left + 1; i <= right; i++)
                        {
                            max = Math.Max(max, nums[i]);
                        }
                    }
                    else if (min == nums[left - 1])
                    {
                        min = nums[left];
                        for (int i = left + 1; i <= right; i++)
                        {
                            min = Math.Min(min, nums[i]);
                        }
                    }
                }
                right++;
            }
            return right - left;
        }
    }
}
