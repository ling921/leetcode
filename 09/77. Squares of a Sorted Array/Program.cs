using System;

namespace _77._Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
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
