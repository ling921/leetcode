using System;

namespace P0801ToP0900
{
    /// <summary>
    /// 807. Max Increase to Keep City Skyline
    /// </summary>
    public class Solution0807
    {
        public Solution0807()
        {
            //int[][] grid = { new int[] { 3, 0, 8, 4 }, new int[] { 2, 4, 5, 7 }, new int[] { 9, 2, 6, 3 }, new int[] { 0, 3, 1, 0 } };
            int[][] grid = { new int[] { 59, 88, 44 }, new int[] { 3, 18, 38 }, new int[] { 21, 26, 51 } };
            /*
            [[59,88,44],
             [ 3,18,38],
             [21,26,51]]
             =>>
            [[59,88,51],
             [38,38,38],
             [51,51,51]]
             0+0+7+ 35+20+0+ 30+25+0
            */
            Console.WriteLine(MaxIncreaseKeepingSkyline(grid));
        }

        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int len_H = grid.Length;
            int len_V = grid[0].Length;
            int[] skyLine_H = new int[len_H];
            int[] skyLine_V = new int[len_V];
            for (int i = 0; i < len_H; i++)
            {
                for (int j = 0; j < len_V; j++)
                {
                    skyLine_H[i] = Math.Max(skyLine_H[i], grid[i][j]);
                    skyLine_V[j] = Math.Max(skyLine_V[j], grid[i][j]);
                }
            }
            int result = 0;
            for (int i = 0; i < len_H; i++)
                for (int j = 0; j < len_V; j++)
                    result += Math.Max(Math.Min(skyLine_H[i], skyLine_V[j]) - grid[i][j], 0);
            return result;
        }
    }
}
