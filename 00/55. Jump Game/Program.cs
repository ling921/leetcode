using System;

namespace _55._Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().CanJump(new int[] { 1, 2 }));

            Console.Read();
        }
    }
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int maxIndex = 0;
            for (int i = 0; i < nums.Length - 1 && i <= maxIndex; i++)
                maxIndex = Math.Max(maxIndex, i + nums[i]);
            return maxIndex >= nums.Length - 1;
        }
    }
}
