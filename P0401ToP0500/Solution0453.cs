using System;

namespace P0401ToP0500
{
    /// <summary>
    /// 453. Minimum Moves to Equal Array Elements
    /// </summary>
    public class Solution0453
    {
        public Solution0453()
        {
            Console.WriteLine();
        }

        public int MinMoves(int[] nums)
        {
            int min = int.MaxValue, sum = 0;
            foreach (var n in nums)
            {
                min = min > n ? n : min;
                sum += n;
            }
            return sum - min * nums.Length;
        }
    }
}
