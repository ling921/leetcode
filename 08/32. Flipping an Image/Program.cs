using System;

namespace _32._Flipping_an_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(~a);

            Console.ReadLine();
        }
    }

    public class Solution
    {
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
    }

    public class Solution2
    {
        public int[][] FlipAndInvertImage(int[][] A)
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
