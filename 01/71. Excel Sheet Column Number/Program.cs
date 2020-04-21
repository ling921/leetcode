using System;

namespace _71._Excel_Sheet_Column_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().TitleToNumber("A"));
            Console.WriteLine(new Solution().TitleToNumber("Z"));
            Console.WriteLine(new Solution().TitleToNumber("AA"));
            Console.WriteLine(new Solution().TitleToNumber("ZZ"));
            Console.WriteLine(new Solution().TitleToNumber("XFD"));

            Console.Read();
        }
    }

    public class Solution
    {
        public int TitleToNumber(string s)
        {
            int num = 0, len = s.Length;
            for (int i = 0; i < len; i++)
                num += (s[len - i - 1] - 'A' + 1) * (int)Math.Pow(26, i);
            return num;
        }
    }
}
