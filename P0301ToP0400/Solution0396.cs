using System;

namespace P0301ToP0400
{
    /// <summary>
    /// 396. Rotate Function
    /// </summary>
    public class Solution0396
    {
        public Solution0396()
        {
            Console.WriteLine();
        }

        public int MaxRotateFunction(int[] A)
        {
            int sum = 0, f0 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                f0 += i * A[i];
            }
            int max = f0;
            for (int i = 1; i < A.Length; i++)
            {
                f0 = f0 + sum - A.Length * A[A.Length - i];
                max = max > f0 ? max : f0;
            }
            return max;
        }
    }
}
