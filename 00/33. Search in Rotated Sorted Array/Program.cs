using System;
using System.Diagnostics;

namespace _33._Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            Solution_1 solution_1 = new Solution_1();
            Solution solution = new Solution();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(solution_1.Search(nums, 0));
            stopwatch.Stop();
            Console.WriteLine($"Solution_1耗时：{stopwatch.ElapsedMilliseconds}");
            stopwatch.Restart();
            Console.WriteLine(solution.Search(nums, 0));
            stopwatch.Stop();
            Console.WriteLine($"Solution耗时：{stopwatch.ElapsedMilliseconds}");

            Console.Read();
        }
    }
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            return Search(nums, 0, nums.Length, target);
        }
        public int Search(int[] nums, int low, int high, int target)
        {
            if (low > high)
                return -1;
            int mid = (low + high) / 2;
            if (target == nums[mid])
                return mid;
            if (nums[low] < nums[mid])
            {
                if (target < nums[low] || target > nums[mid])
                    return Search(nums, mid + 1, high, target);
                else
                    return Search(nums, low, mid - 1, target);
            }
            else
            {
                if (target < nums[mid] || target > nums[high])
                    return Search(nums, low, mid - 1, target);
                else
                    return Search(nums, mid + 1, high, target);
            }
        }
    }
}
