using System;
using System.Linq;

namespace P0401ToP0500
{
    /// <summary>
    /// 462. Minimum Moves to Equal Array Elements II
    /// </summary>
    public class Solution0462
    {
        public Solution0462()
        {
            int[] nums = { 203125577, -349566234, 230332704, 48321315, 66379082, 386516853, 50986744, -250908656, -425653504, -212123143 };
            Console.WriteLine(MinMoves2(nums));
            Console.WriteLine(MinMoves2(new int[] { 2, 3, 8 }));
        }

        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            long sum = nums.Sum(), sumLeft = nums[0];
            long move = sum - (long)nums[0] * nums.Length;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    long left = nums[i] * i - sumLeft;
                    long right = sum - sumLeft - (long)nums[i] * (nums.Length - i);
                    //Console.WriteLine(left + right);
                    if (left + right > move)
                        break;
                    move = left + right;
                }
                sumLeft += nums[i];
            }
            return (int)move;
        }
    }

    internal class Solution2
    {
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int i = 0, j = nums.Length - 1, res = 0;
            while (i < j)
            {
                res += nums[j--] - nums[i++];
            }
            return res;
        }
    }
}
