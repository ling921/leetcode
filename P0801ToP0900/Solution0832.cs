using System;

namespace P0801ToP0900
{
    /// <summary>
    /// 832. Flipping an Image
    /// </summary>
    public class Solution0832
    {
        public Solution0832()
        {
            Console.WriteLine();
        }

        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] res = new int[A.Length][];

            for (int i = 0; i < A.Length; i++)
            {
                int len = A[i].Length;
                res[i] = new int[len];
                for (int j = 0; j < len; j++)
                {
                    res[i][len - 1 - j] = A[i][j] == 0 ? 1 : 0;
                }
            }

            return res;
        }

        public int[][] FlipAndInvertImage2(int[][] A)
        {
            int temp;
            for (int i = 0; i < A.Length; i++)
            {
                int len = A[i].Length;
                for (int j = 0; j < (len + 1) / 2; j++)
                {
                    temp = A[i][len - 1 - j] == 0 ? 1 : 0;
                    A[i][len - 1 - j] = A[i][j] == 0 ? 1 : 0;
                    A[i][j] = temp;
                }
            }

            return A;
        }
    }
}
