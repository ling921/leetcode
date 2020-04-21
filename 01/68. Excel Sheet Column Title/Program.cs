using System;
using System.Text;

namespace _68._Excel_Sheet_Column_Title
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{1}: {new Solution().ConvertToTitle(1)}");
            Console.WriteLine($"{26}: {new Solution().ConvertToTitle(26)}");
            Console.WriteLine($"{27}: {new Solution().ConvertToTitle(27)}");
            Console.WriteLine($"{676}: {new Solution().ConvertToTitle(26 * 26)}");
            Console.WriteLine($"{702}: {new Solution().ConvertToTitle(702)}");
            Console.WriteLine($"{16384}: {new Solution().ConvertToTitle(16384)}");

            Console.Read();
        }
    }
    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                sb.Insert(0, (char)('A' + (n - 1) % 26));
                n = (n - 1) / 26;
            }
            return sb.ToString();
        }
    }
}
