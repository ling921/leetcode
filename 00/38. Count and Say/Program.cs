using System;
using System.Text;

namespace _38._Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 2;
            for (int i = 1; i <= 30; i++)
                Console.WriteLine($"{i}: {new Solution().CountAndSay(i)}");

            Console.Read();
        }
    }
    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";
            string str = CountAndSay(n - 1);
            StringBuilder sb = new StringBuilder();
            int count = 0;
            char c = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    count++;
                else
                {
                    sb.Append(count).Append(c);
                    c = str[i];
                    count = 1;
                }
            }
            return sb.Append(count).Append(c).ToString();
        }
    }
}
