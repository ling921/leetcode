using System;
using System.Linq;

namespace _05._Maximize_Sum_Of_Array_After_K_Negations
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            Array.Sort(A);
            int i = 0;
            while (K > 0 && i < A.Length && A[i] < 0)
            {
                A[i] = -A[i++];
                K--;
            }
            if (K % 2 == 0)
                return A.Sum();
            else
            {
                Array.Sort(A);
                return A.Sum() - 2 * A[0];
            }
        }
    }
}
