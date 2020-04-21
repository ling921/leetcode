using System;

namespace _83._Projection_Area_of_3D_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] grid = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 1, 2 }, new int[] { 2, 2, 2 } };
            Console.WriteLine(solution.ProjectionArea(grid));
            Console.ReadKey();
        }
    }

    public class Solution
    {
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