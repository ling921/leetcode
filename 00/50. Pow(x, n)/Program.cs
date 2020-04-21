using System;

namespace _50._Pow_x__n_
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            double x = 34.00515;
            int n = -3;
            Console.WriteLine(solution.MyPow(x, n));
            Console.Read();
        }
    }
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return x;
            else if (n == 2)
                return x * x;
            else if (n < 0)
                return 1 / (x * MyPow(x, -(n + 1)));
            else
                return n % 2 == 0 ? MyPow(MyPow(x, n >> 1), 2) : x * MyPow(MyPow(x, n >> 1), 2);
        }
    }
}
