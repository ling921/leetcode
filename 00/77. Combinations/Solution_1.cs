using System.Collections.Generic;

namespace _77._Combinations
{
    class Solution_1
    {
        private IList<IList<int>> Temp = new List<IList<int>>();
        public IList<IList<int>> Combine(int n, int k)
        {
            if (n * k == 0)
                return null;
            if (Temp.Count == 0)
            {
                for (int i = 1; i <= n - k + 1; i++)
                    Temp.Add(new List<int>() { i });
                Combine(n, k - 1);
            }
            else
            {
                IList<IList<int>> newTemp = new List<IList<int>>();
                foreach (IList<int> list in Temp)
                {
                    for (int i = list[list.Count - 1] + 1; i <= n; i++)
                    {
                        newTemp.Add(new List<int>(list));
                        newTemp[newTemp.Count - 1].Add(i);
                    }
                }
                Temp = newTemp;
                Combine(n, k - 1);
            }
            return Temp;
        }
    }
}