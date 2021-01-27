using System;

namespace P0401ToP0500
{
    /// <summary>
    /// 470. Implement Rand10() Using Rand7()
    /// </summary>
    public class Solution0470
    {
        public Solution0470()
        {
            Solution solution = new Solution();
            for (int i = 0; i < 100; i++)
                Console.WriteLine(solution.Rand10());
        }

        private class SolBase
        {
            public int Rand7()
            {
                Random rnd = new Random();
                return rnd.Next(1, 8);
            }
        }

        private class Solution : SolBase
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
}
