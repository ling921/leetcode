using System;

namespace P0501ToP0600
{
    /// <summary>
    /// 507. Perfect Number
    /// </summary>
    public class Solution0507
    {
        public Solution0507()
        {
            Console.WriteLine(CheckPerfectNumber(28));
        }

        public bool CheckPerfectNumber(int num)
        {
            int s = (int)Math.Sqrt(num);
            int sum = 1;
            for (int i = 2; i <= s; i++)
                if (num % i == 0)
                    sum += i * i == num ? i : (i + num / i);
            return num == 1 ? false : num == sum;
        }
    }
}
