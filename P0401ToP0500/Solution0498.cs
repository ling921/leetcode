using CommonLibrary;

namespace P0401ToP0500
{
    /// <summary>
    /// 498. Diagonal Traverse
    /// </summary>
    public class Solution0498
    {
        public Solution0498()
        {
            //int[][] matrix = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            int[][] matrix = { };
            FindDiagonalOrder(matrix).Print();
        }

        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix == null)
                return new int[] { };
            int m = matrix.Length, n = matrix[0].Length;
            int[] result = new int[m * n];
            int i = 0;
            for (int j = 0; j < m + n - 1; j++)
            {
                if (j % 2 == 0)
                {
                    int k = j > m - 1 ? j - m + 1 : 0;
                    while (j - k >= 0 && k < n)
                    {
                        result[i++] = matrix[j - k][k];
                        k++;
                    }
                }
                else
                {
                    int k = j > n - 1 ? j - n + 1 : 0;
                    while (j - k >= 0 && k < m)
                    {
                        result[i++] = matrix[k][j - k];
                        k++;
                    }
                }
            }
            return result;
        }
    }
}
