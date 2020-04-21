using System;
using System.Text;

namespace _81._Magical_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 9758;
            Console.WriteLine(solution.MagicalString(n));
            Console.Read();
        }
    }
    public class Solution
    {
        public int MagicalString(int n)
        {
            if (n < 4)
                return n == 0 ? 0 : 1;
            StringBuilder sb = new StringBuilder("122");
            int count = 1;

            for (int i = 2; ; i++)
            {
                if (sb[i] == '1')
                {
                    sb.Append(sb[sb.Length - 1] == '2' ? "1" : "2");
                    count++;
                }
                else
                    sb.Append(sb[sb.Length - 1] == '2' ? "11" : "22");
                //Console.WriteLine(sb.ToString());
                if (i == n - 1)
                    return count;
            }
        }
    }
}
