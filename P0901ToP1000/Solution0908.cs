using System;

namespace P0901ToP1000
{
    /// <summary>
    /// 908. Smallest Range I
    /// </summary>
    public class Solution0908
    {
        public Solution0908()
        {
            Console.WriteLine();
        }

        public int SmallestRangeI(int[] A, int K)
        {
            //return Math.Max(A.Max() - A.Min() - K * 2, 0);

            //Array.Sort(A);
            //return Math.Max(A[A.Length - 1] - A[0] - K * 2, 0);

            int max = int.MinValue, min = int.MaxValue;
            foreach (var n in A)
            {
                max = max > n ? max : n;
                min = min < n ? min : n;
            }
            return Math.Max(max - min - K * 2, 0);
        }
    }
}
