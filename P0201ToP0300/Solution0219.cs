using System;
using System.Collections.Generic;

namespace P0201ToP0300
{
    /// <summary>
    /// 219. Contains Duplicate II
    /// </summary>
    public class Solution0219
    {
        public Solution0219()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            Console.WriteLine(ContainsNearbyDuplicate(nums, 2));

            Console.ReadLine();
        }

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

        public bool ContainsNearbyDuplicate2(int[] nums, int k)
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
