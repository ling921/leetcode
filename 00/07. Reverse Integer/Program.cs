using System;

namespace _07._Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //int x =-2147483648;
            int x = -123;
            Console.WriteLine(x);
            Console.WriteLine(solution.Reverse(x));
            Console.Read();
        }
    }
    public class Solution
    {
        public int Reverse(int x)
        {
            bool negative = x < 0;
            x = negative ? -x : x;
            long reverse = 0;
            while (x > 0)
            {
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }
            reverse = negative ? -reverse : reverse;
            return reverse < int.MinValue || reverse > int.MaxValue ? 0 : (int)reverse;
        }
    }
}
