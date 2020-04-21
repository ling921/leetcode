using System.Collections.Generic;

namespace _46._Permutations
{
    public class Solution_1
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> pList = new List<IList<int>>() { new List<int> { nums[0] } };
            if (nums.Length == 1)
                return pList;

            for (int i = 1; i < nums.Length; i++)
            {
                pList = GetPermute(pList, nums[i]);
            }
            return pList;
        }
        public IList<IList<int>> GetPermute(IList<IList<int>> permuteList, int num)
        {
            IList<IList<int>> pList = new List<IList<int>>();
            foreach (List<int> intList in permuteList)
            {
                for (int i = 0; i < intList.Count; i++)
                {
                    List<int> temp = new List<int>();
                    intList.ForEach((item) => { temp.Add(item); });
                    temp.Insert(i, num);
                    pList.Add(temp);
                }
                pList.Add(intList);
                pList[pList.Count - 1].Add(num);
            }
            return pList;
        }
    }
}