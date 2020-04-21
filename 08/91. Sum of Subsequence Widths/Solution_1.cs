using System;

namespace _91._Sum_of_Subsequence_Widths
{
    class Solution_1
    {
        public int SumSubseqWidths(int[] A)
        {
            Array.Sort(A);
            decimal count = 0;
            for (int i = 0; i < A.Length - 1; i++)
                for (int j = i + 1; j < A.Length; j++)
                    count += Pow(j - i - 1) * ((decimal)A[j] - A[i]) % 1000000007;
            return (int)(count % 1000000007);
        }
        private int Pow(int n)
        {
            return n == 0 ? 1 : (Pow(n - 1) << 1) % 1000000007;
        }
    }
}
