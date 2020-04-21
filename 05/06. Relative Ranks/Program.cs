using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Relative_Ranks
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new Solution().FindRelativeRanks(new int[] { 10, 3, 8, 9, 4 }))
                Console.WriteLine(item);

            Console.Read();
        }
    }
    public class Solution
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            List<Tuple<int, int>> tuples = new List<Tuple<int, int>>();
            for (int i = 0; i < nums.Length; i++)
                tuples.Add(new Tuple<int, int>(i, nums[i]));
            string[] result = new string[nums.Length];
            int j = 0;
            foreach (var t in tuples.OrderByDescending(t => t.Item2))
            {
                result[t.Item1] = j == 0 ? "Gold Medal" :
                                          j == 1 ? "Silver Medal" :
                                          j == 2 ? "Bronze Medal" :
                                          (j + 1).ToString();
                j++;
            }
            return result;
        }
    }
}
