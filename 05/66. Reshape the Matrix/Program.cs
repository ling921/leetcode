using System;

namespace _66._Reshape_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] nums = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] result = solution.MatrixReshape(nums, 1, 4);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int len1 = nums.GetLength(0), len2 = nums.GetLength(1);
            if (len1 * len2 != r * c)
                return nums;
            int[,] result = new int[r, c];
            for (int i = 0; i < r * c; i++)
                result[i / c, i % c] = nums[i / len2, i % len2];
            return result;
        }
    }
}