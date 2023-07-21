namespace P0001ToP0100
{
    /// <summary>
    /// 55. Jump Game
    /// </summary>
    public class Solution0055
    {
        public Solution0055()
        {
            Console.WriteLine(CanJump(new int[] { 1, 2 }));

            Console.Read();
        }

        public bool CanJump(int[] nums)
        {
            int maxIndex = 0;
            for (int i = 0; i < nums.Length - 1 && i <= maxIndex; i++)
                maxIndex = Math.Max(maxIndex, i + nums[i]);
            return maxIndex >= nums.Length - 1;
        }
    }
}
