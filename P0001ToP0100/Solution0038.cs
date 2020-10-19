using System;
using System.Text;

namespace P0001ToP0100
{
    /// <summary>
    /// 38. Count and Say
    /// </summary>
    public class Solution0038
    {
        public Solution0038()
        {
            //int i = 2;
            for (int i = 1; i <= 30; i++)
                Console.WriteLine($"{i}: {CountAndSay(i)}");

            Console.Read();
        }

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
