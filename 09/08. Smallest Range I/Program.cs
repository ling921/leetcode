using System;

namespace _08._Smallest_Range_I
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
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
