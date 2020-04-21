using System;

namespace _07._Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().CheckPerfectNumber(28));

            Console.ReadKey();
        }
    }
    public class Solution
    {
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
