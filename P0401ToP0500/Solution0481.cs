using System;
using System.Text;

namespace P0401ToP0500
{
    /// <summary>
    /// 481. Magical String
    /// </summary>
    public class Solution0481
    {
        public Solution0481()
        {
            int n = 9758;
            Console.WriteLine(MagicalString(n));
        }

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
