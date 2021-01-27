using System;

namespace P0001ToP0100
{
    /// <summary>
    /// 62. Unique Paths
    /// </summary>
    public class Solution0062
    {
        public int[,] recode;

        public Solution0062()
        {
            Console.WriteLine(UniquePaths(19, 13));

            Console.ReadKey();
        }

        public int UniquePaths(int m, int n)
        {
            if (recode == null)
                recode = new int[m, n];

            if (m > 1 && n > 1)
            {
                if (recode[m - 1, n - 1] == 0)
                    recode[m - 1, n - 1] = UniquePaths(m, n - 1) + UniquePaths(m - 1, n);
                return recode[m - 1, n - 1];
            }
            return 1;
        }
    }
}
