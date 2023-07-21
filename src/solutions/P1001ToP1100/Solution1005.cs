namespace P1001ToP1100
{
    /// <summary>
    /// 1005. Maximize Sum Of Array After K Negations
    /// </summary>
    public class Solution1005
    {
        public Solution1005()
        {
            Console.WriteLine();
        }

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
