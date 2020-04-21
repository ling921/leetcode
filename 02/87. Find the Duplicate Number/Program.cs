using System;

namespace _87._Find_the_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 1, 3, 4, 2, 2 };
            Console.WriteLine(solution.FindDuplicate(nums));
            Console.Read();
        }
    }
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            int fast = 0, slow = 0;
            while (true)
            {
                fast = nums[nums[fast]];
                slow = nums[slow];
                if(fast == slow)
                {
                    fast = 0;
                    while (fast != slow)
                    {
                        fast = nums[fast];
                        slow = nums[slow];
                    }
                    return fast;
                }
            }
        }
    }
}
