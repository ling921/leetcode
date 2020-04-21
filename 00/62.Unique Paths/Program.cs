using System;
using System.Diagnostics;

namespace _62.Unique_Paths
{
    //执行用时: 56 ms, 在Unique Paths的C#提交中击败了88.89% 的用户
    /*
     A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

    The robot can only move either down or right at any point in time. 
    The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

    How many possible unique paths are there?
    */

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();

            Solution solution = new Solution();
            Console.WriteLine(solution.UniquePaths(19, 13));

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds.ToString());
            Console.ReadKey();
        }
    }
    public class Solution
    {
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
        public int[,] recode;
    }
}
