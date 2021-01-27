using CommonLibrary;

namespace P0501ToP0600
{
    /// <summary>
    /// 566. Reshape the Matrix
    /// </summary>
    public class Solution0566
    {
        public Solution0566()
        {
            int[,] nums = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] result = MatrixReshape(nums, 1, 4);
            result.Print();
        }

        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int len1 = nums.GetLength(0), len2 = nums.GetLength(1);
            if (len1 * len2 != r * c)
                return nums;
            int[,] result = new int[r, c];
            for (int i = 0; i < r * c; i++)
                result[i / c, i % c] = nums[i / len2, i % len2];
            return result;
        }
    }
}
