namespace P0601ToP0700
{
    /// <summary>
    /// 643. 子数组最大平均数 I
    /// </summary>
    public class Solution0643
    {
        public Solution0643()
        {
            var nums = "[0,4,0,3,2]".ToArray<int>();
            var k = 1;
            WriteLine(FindMaxAverage(nums, k));
        }

        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            var max = sum;
            for (int i = 0; i < nums.Length - k; i++)
            {
                sum = sum - nums[i] + nums[i + k];
                if (nums[i + k] > nums[i])
                    max = Math.Max(max, sum);
            }
            return max / (double)k;
        }
    }
}
