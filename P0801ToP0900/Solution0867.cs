using static CommonLibrary.Extensions.ConsoleExtension;
using System.Linq;
using CommonLibrary.Extensions;

namespace P0801ToP0900
{
    /// <summary>
    /// 867. 转置矩阵
    /// </summary>
    public class Solution0867
    {
        public Solution0867()
        {
            var matrix = "[[1,2,3],[4,5,6],[7,8,9]]".ToArrayArray<int>();
            WriteLine(Transpose(matrix));
        }

        public int[][] Transpose(int[][] matrix)
        {
            var res = new int[matrix[0].Length][];
            for (int i = 0; i < matrix[0].Length; i++)
            {
                res[i] = new int[matrix.Length];
                for (int j = 0; j < matrix.Length; j++)
                {
                    res[i][j] = matrix[j][i];
                }
            }
            return res;
        }

        public int[][] Transpose1(int[][] matrix)
        {
            return Enumerable.Range(0, matrix[0].Length)
                .Select(i => Enumerable.Range(0, matrix.Length)
                    .Select(j => matrix[j][i])
                    .ToArray())
                .ToArray();
        }
    }
}