using System;

namespace _65._Non_decreasing_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 2, 3, 4, 2, 4 };
            Console.WriteLine(solution.CheckPossibility(nums));
            Console.Read();
        }
    }
    public class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (i != 0 && nums[i - 1] > nums[i + 1] && i != nums.Length - 2 && nums[i] > nums[i + 2])
                        return false;
                    if (++count > 1)
                        return false;
                }
            }
            return true;
        }
    }
}
