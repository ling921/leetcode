using System;
using System.Collections.Generic;

namespace _19._Contains_Duplicate_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            Console.WriteLine(new Solution().ContainsNearbyDuplicate(nums, 2));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                    for (int j = i - 1; j >= i - k && j >= 0; j--)
                        if (nums[i] == nums[j])
                            return true;
                set.Add(nums[i]);
            }
            return false;
        }
    }

    public class Solution2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]) && i - dic[nums[i]] <= k)
                    return true;
                dic[nums[i]] = i;
            }
            return false;
        }
    }
}
