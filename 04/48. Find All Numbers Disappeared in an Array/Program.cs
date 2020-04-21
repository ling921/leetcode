using System;
using System.Collections.Generic;

namespace _48._Find_All_Numbers_Disappeared_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            foreach (int a in solution.FindDisappearedNumbers(nums))
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int[] n = new int[nums.Length];
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                n[nums[i] - 1]++;
            for (int j = 0; j < n.Length; j++)
                if (n[j] == 0)
                    result.Add(j + 1);
            return result;
        }
    }
}