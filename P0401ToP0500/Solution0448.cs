using static CommonLibrary.Extensions.ConsoleExtension;
using System.Collections.Generic;

namespace P0401ToP0500
{
    /// <summary>
    /// 448. Find All Numbers Disappeared in an Array
    /// </summary>
    public class Solution0448
    {
        public Solution0448()
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            WriteLine(FindDisappearedNumbers(nums));
        }

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
