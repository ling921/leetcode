using System;

namespace _70._Implement_Rand10___Using_Rand7__
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            for (int i = 0; i < 100; i++)
                Console.WriteLine(solution.Rand10());

            Console.Read();
        }
    }
    public class SolBase
    {
        public int Rand7()
        {
            Random rnd = new Random();
            return rnd.Next(1, 8);
        }
    }
    public class Solution : SolBase
    {
        public int Rand10()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
                sum += Rand7();
            return (sum - 1) % 7 + 1;
        }
    }
}
