using System;

namespace _91._Sum_of_Subsequence_Widths
{
    class Solution_2
    {
        public int SumSubseqWidths(int[] A)
        {
            Array.Sort(A);
            int count = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    count += PowAndMul(j - i - 1, A[j] - A[i]);
                    count %= 1000000007;
                }
            }
            return count;
        }
        private int PowAndMul(int n, int mul)
        {
            return n == 0 ? mul : (PowAndMul(n - 1, mul) << 1) % 1000000007;
        }
    }
}
