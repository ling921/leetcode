using System;

namespace _99._Evaluate_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[,] equations = { };
            double[] values = { };
            string[,] queries = { };
            foreach (var item in solution.CalcEquation(equations, values, queries))
                Console.WriteLine(item);
            Console.Read();
        }
    }
    public class Solution
    {
        public double[] CalcEquation(string[,] equations, double[] values, string[,] queries)
        {

        }
    }
}
