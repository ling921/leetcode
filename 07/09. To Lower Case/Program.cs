using System;
using System.Text;

namespace _09._To_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().ToLowerCase("Hello"));

            Console.Read();
        }
    }
    public class Solution
    {
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
                sb.Append((str[i] >= 'A' && str[i] <= 'Z') ? (char)(str[i] - 'A' + 'a') : str[i]);
            return sb.ToString();
        }
    }
}
