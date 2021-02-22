using static CommonLibrary.Extensions.ConsoleExtension;
using CommonLibrary.Extensions;

namespace P0701ToP0800
{
    /// <summary>
    /// 766. 托普利茨矩阵
    /// </summary>
    public class Solution0766
    {
        public Solution0766()
        {
            var matrix = "[[1,2,3,4],[5,1,2,3],[9,5,1,2]]".ToArrayArray<int>();
            WriteLine(IsToeplitzMatrix(matrix));
        }

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int m = matrix.Length, n = matrix[0].Length, temp;
            for (int r = 0; r < m - 1; r++)
            {
                temp = matrix[r][0];
                int i = r + 1, j = 1;
                while (i < m && j < n)
                {
                    if (matrix[i++][j++] != temp)
                        return false;
                }
            }
            for (int c = 1; c < n - 1; c++)
            {
                temp = matrix[0][c];
                int i = 1, j = c + 1;
                while (i < m && j < n)
                {
                    if (matrix[i++][j++] != temp)
                        return false;
                }
            }
            return true;
        }
    }
}