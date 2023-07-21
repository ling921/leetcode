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
            private readonly List<int[]> _history;

            public SubrectangleQueries(int[][] rectangle)
            {
                _value = rectangle;
                _history = new List<int[]>();
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                _history.Add(new[] { row1, row2, col1, col2, newValue });
            }

            public int GetValue(int row, int col)
            {
                if (_history.Count > 0)
                {
                    for (int i = _history.Count - 1; i >= 0; i--)
                    {
                        if (_history[i][0] <= row && row <= _history[i][1] && _history[i][2] <= col && col <= _history[i][3])
                            return _history[i][4];
                    }
                }
                return _value[row][col];
            }
        }

        public class SubrectangleQueries1
        {
            private readonly int[][] _value;

            public SubrectangleQueries1(int[][] rectangle)
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
