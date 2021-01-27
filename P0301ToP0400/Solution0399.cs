using System;

namespace P0301ToP0400
{
    /// <summary>
    /// 399. Evaluate Division
    /// </summary>
    public class Solution0399
    {
        public Solution0399()
        {
            string[,] equations = { };
            double[] values = { };
            string[,] queries = { };
            foreach (var item in CalcEquation(equations, values, queries))
                Console.WriteLine(item);
        }

        public double[] CalcEquation(string[,] equations, double[] values, string[,] queries)
        {
            return null;
        }
    }
}
