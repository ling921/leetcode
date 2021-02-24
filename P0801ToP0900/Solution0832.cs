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
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < (A[0].Length + 1) / 2; j++)
                {
                    if (A[i][j] == A[i][A[0].Length - 1 - j])
                    {
                        A[i][j] = A[i][A[0].Length - 1 - j] = A[i][j] ^ 1;
                    }
                }
            }
            return A;
        }

        public int[][] FlipAndInvertImage2(int[][] A)
        {
            int temp;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < (A[0].Length + 1) / 2; j++)
                {
                    temp = A[i][A[0].Length - 1 - j];
                    A[i][A[0].Length - 1 - j] = A[i][j] ^ 1;
                    A[i][j] = temp ^ 1;
                }
            }
            return A;
        }
    }
}