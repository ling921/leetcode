using System;
using System.Text;

namespace P0101ToP0200
{
    /// <summary>
    /// 168. Excel Sheet Column Title
    /// </summary>
    public class Solution0168
    {
        public Solution0168()
        {
            Console.WriteLine($"{1}: {ConvertToTitle(1)}");
            Console.WriteLine($"{26}: {ConvertToTitle(26)}");
            Console.WriteLine($"{27}: {ConvertToTitle(27)}");
            Console.WriteLine($"{676}: {ConvertToTitle(26 * 26)}");
            Console.WriteLine($"{702}: {ConvertToTitle(702)}");
            Console.WriteLine($"{16384}: {ConvertToTitle(16384)}");

            Console.Read();
        }

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
