namespace P0001ToP0100
{
    /// <summary>
    /// 45. Jump Game II
    /// </summary>
    public class Solution0045
    {
        public Solution0045()
        {

        }

        public int Jump(int[] nums)
        {
            int[] minStep = new int[nums.Length];
            for (int i = 1; i < nums.Length - 1; i++)
            {
                for (int j = 1; j <= nums[i] && i + j < nums.Length; j++)
                {
                    nums[i + j] = nums[i + j] >= nums[i] + 1 || nums[i + j] == 0 ? nums[i] + 1 : nums[i + j];
                }
            }
            return minStep[nums.Length - 1];
        }
    }
}
