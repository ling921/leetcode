using System;

namespace _99._Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            //string secret = "1807";
            //string guess = "7810";
            string secret = "1123";
            string guess = "0111";

            Solution solution = new Solution();
            Console.WriteLine(solution.GetHint(secret, guess));

            Console.ReadKey();
        }
    }
    public class Solution
    {
        public string GetHint(string secret, string guess)
        {
            char[] se = secret.ToCharArray();
            char[] gu = guess.ToCharArray();
            int a = 0, b = 0, len = se.Length;
            for (int k = 0; k < len; k++)
                if (Equals(se[k], gu[k]))
                    a++;

            Array.Sort(se);
            Array.Sort(gu);
            int i = 0, j = 0;
            do
            {
                if (se[i] > gu[j])
                    j++;
                else if (se[i] < gu[j])
                    i++;
                else if (se[i] == gu[j])
                {
                    b++;
                    i++;
                    j++;
                }
            } while (i < len && j < len);

            return $"{a}A{b - a}B";
        }
    }
}
