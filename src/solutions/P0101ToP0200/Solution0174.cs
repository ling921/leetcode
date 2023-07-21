namespace P0101ToP0200
{
    /// <summary>
    /// 174. Dungeon Game
    /// </summary>
    public class Solution0174
    {
        public Solution0174()
        {
            int[][] dungeon = { new int[]{ -2, -3, 3 },
                                new int[]{ -5, -10, 1 },
                                new int[]{ 10, 30, -5 } };
            Console.WriteLine(CalculateMinimumHP(dungeon));

            Console.ReadKey();
        }

        public int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length, n = dungeon[0].Length;
            int[,] minHP = new int[m, n];
            minHP[m - 1, n - 1] = dungeon[m - 1][n - 1] >= 0 ? 1 : -dungeon[m - 1][n - 1] + 1;
            for (int i = m - 1; i >= 0; i--)
            {
                if (i < m - 1)
                    minHP[i, n - 1] = dungeon[i][n - 1] >= minHP[i + 1, n - 1] ? 1 : minHP[i + 1, n - 1] - dungeon[i][n - 1];
                for (int j = n - 2; j >= 0; j--)
                {
                    if (i == m - 1)
                    {
                        minHP[i, j] = dungeon[i][j] >= minHP[i, j + 1] ? 1 : minHP[i, j + 1] - dungeon[i][j];
                    }
                    else
                    {
                        int min = Math.Min(minHP[i + 1, j], minHP[i, j + 1]);
                        minHP[i, j] = dungeon[i][j] >= min ? 1 : min - dungeon[i][j];
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{minHP[i, j]}    ");
                }
                Console.WriteLine();
            }
            return minHP[0, 0];
        }
    }
}
