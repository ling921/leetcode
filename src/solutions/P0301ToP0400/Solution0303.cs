namespace P0301ToP0400
{
    /// <summary>
    /// 303. 区域和检索 - 数组不可变
    /// </summary>
    public class Solution0303
    {
        public Solution0303()
        {
        }

        public class NumArray
        {
            private readonly int[] _sums;

            public NumArray(int[] nums)
            {
                _sums = new int[nums.Length + 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    _sums[i + 1] = _sums[i] + nums[i];
                }
            }

            public int SumRange(int i, int j)
            {
                return _sums[j] - _sums[i];
            }
        }

        public class NumArray1
        {
            private readonly int[] _nums;

            public NumArray1(int[] nums)
            {
                _nums = nums;
            }

            public int SumRange(int i, int j)
            {
                var sum = 0;
                for (int k = i; k <= j; k++)
                {
                    sum += _nums[k];
                }
                return sum;
            }
        }
    }
}
