namespace P0301ToP0400
{
    /// <summary>
    /// 304. 二维区域和检索 - 矩阵不可变
    /// </summary>
    public class Solution0304
    {
        public Solution0304()
        {
            var matrix = "[[3,0,1,4,2],[5,6,3,2,1],[1,2,0,1,5],[4,1,0,1,7],[1,0,3,0,5]]".ToArrayArray<int>();
            var numMatrix = new NumMatrix(matrix);
            WriteLine(numMatrix.SumRegion(2, 1, 4, 3));
            WriteLine(numMatrix.SumRegion(1, 1, 2, 2));
            WriteLine(numMatrix.SumRegion(1, 2, 2, 4));
        }

        public class NumMatrix
        {
            private readonly int[,] _matrix;

            public NumMatrix(int[][] matrix)
            {
                _matrix = new int[matrix.Length + 1, matrix[0].Length + 1];
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        _matrix[i + 1, j + 1] = j == 0
                            ? _matrix[i, j + 1] + matrix[i][j]
                            : _matrix[i + 1, j] + _matrix[i, j + 1] - _matrix[i, j] + matrix[i][j];
                    }
                }
            }

            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                return _matrix[row2 + 1, col2 + 1] - _matrix[row2 + 1, col1] - _matrix[row1, col2 + 1] + _matrix[row1, col1];
            }
        }
    }
}
