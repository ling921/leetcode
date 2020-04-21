using System;
using System.Collections.Generic;
using System.Linq;

namespace _46._Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            IList<IList<int>> list = solution.Permute(nums);
            foreach (IList<int> intList in list)
            {
                foreach (int num in intList)
                    Console.Write($"{num}   ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> pList = new List<IList<int>>() { new List<int> { nums[0] } };
            if (nums.Length == 1)
                return pList;

            for (int i = 1; i < nums.Length; i++)
            {
                IList<IList<int>> temp = new List<IList<int>>();
                for (int j = 0; j < pList.Count; j++)
                {
                    for (int k = 0; k < pList[j].Count; k++)
                    {
                        IList<int> p = pList[j].ToList();
                        p.Insert(k, nums[i]);
                        temp.Add(p);
                    }
                    temp.Add(pList[j]);
                    temp[temp.Count - 1].Add(nums[i]);
                }
                pList = temp;
            }
            return pList;
        }
    }
}
