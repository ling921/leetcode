using System;

namespace P0801ToP0900
{
    /// <summary>
    /// 883. Projection Area of 3D Shapes
    /// </summary>
    public class Solution0883
    {
        public Solution0883()
        {
            int[][] grid = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 1, 2 }, new int[] { 2, 2, 2 } };
            Console.WriteLine(ProjectionArea(grid));
        }

        public int ProjectionArea(int[][] grid)
        {
            int area = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                int xy = 0, yz = 0, xz = 0;
                for (int j = 0; j < grid.Length; j++)
                {
                    xy += grid[i][j] == 0 ? 0 : 1;
                    yz = yz > grid[i][j] ? yz : grid[i][j];
                    xz = xz > grid[j][i] ? xz : grid[j][i];
                }
                area += xy + yz + xz;
            }
            return area;
        }
    }
}
