using System;
using System.Collections.Generic;

namespace P0501ToP0600
{
    /// <summary>
    /// 532. K-diff Pairs in an Array
    /// </summary>
    public class Solution0532
    {
        public Solution0532()
        {
            Console.WriteLine();
        }

        public int FindPairs(int[] nums, int k)
        {
            if (k < 0)
                return 0;
            Array.Sort(nums);
            Dictionary<int, bool> dic = new Dictionary<int, bool>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]) && dic[nums[i]])
                {
                    Console.WriteLine($"({nums[i] - k}, {nums[i]})");
                    result++;
                    dic[nums[i]] = false;
                }
                if (!dic.ContainsKey(nums[i] + k))
                    dic[nums[i] + k] = true;
            }
            return result;
        }

        public int FindPairs2(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 1 || k < 0)
                return 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic[num] = 1;
            }

            int result = 0;

            foreach (var d in dic)
            {
                if (k == 0)
                {
                    if (d.Value >= 2)
                    {
                        result++;
                        Console.WriteLine($"({d.Key}, {d.Key})");
                    }
                }
                else
                {
                    if (dic.ContainsKey(d.Key + k))
                    {
                        result++;
                        Console.WriteLine($"({d.Key}, {d.Key + k})");
                    }
                }
            }
            return result;
        }
    }
}
