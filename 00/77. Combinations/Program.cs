using System;
using System.Collections.Generic;

namespace _77._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 4;
            int k = 2;
            IList<IList<int>> result = solution.Combine(n, k);
            foreach (IList<int> list in result)
            {
                foreach (int item in list)
                    Console.Write($"{item}  ");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
    public class Solution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            if (n * k == 0)
                return null;
            int len = Factorial(n) / (Factorial(k) * Factorial(n - k));
            int[,] combineArr = new int[len, k];
            IList<IList<int>> result = new List<IList<int>>();


            return result;
        }
        private int Factorial(int num)
        {
            return num == 1 ? 1 : Factorial(num - 1) * num;
        }
        private void Combine(int n, int k, List<int> list, ref IList<IList<int>> combineList)
        {

        }
    }
}
