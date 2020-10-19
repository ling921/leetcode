using System;

namespace P0901ToP1000
{
    /// <summary>
    /// 977. Squares of a Sorted Array
    /// </summary>
    public class Solution0977
    {
        public Solution0977()
        {
            Console.WriteLine();
        }

        public int[] SortedSquares(int[] A)
        {
            int l = 0, r = A.Length - 1;
            int[] result = new int[A.Length];
            for (int i = A.Length - 1; i >= 0; i--)
                result[i] = A[l] + A[r] >= 0 ? A[r] * A[r--] : A[l] * A[l++];
            return result;
        }
    }
}
