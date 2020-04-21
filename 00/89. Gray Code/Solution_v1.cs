using System.Collections.Generic;

namespace _89._Gray_Code
{
    class Solution_v1
    {
        public IList<int> GrayCode(int n)
        {
            List<int> result = new List<int>();
            result.Add(0);
            if (n == 0)
                return result;
            result.Add(1);
            if (n == 1)
                return result;
            for (int i = 1; i < n; i++)
            {
                int len = result.Count;
                for (int j = len - 1; j >= 0; j--)
                {
                    result.Add(result[j] + (1 << i));
                }
            }
            return result;
        }
    }
}
