namespace P1401ToP1500
{
    /// <summary>
    /// 1476. 子矩形查询
    /// </summary>
    public class Solution1476
    {
        public Solution1476()
        {
        }

        public class SubrectangleQueries
        {
            private readonly int[][] _value;

            public SubrectangleQueries(int[][] rectangle)
            {
                _value = rectangle;
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (int i = row1; i <= row2; i++)
                {
                    for (int j = col1; j <= col2; j++)
                    {
                        _value[i][j] = newValue;
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return _value[row][col];
            }
        }
    }
}