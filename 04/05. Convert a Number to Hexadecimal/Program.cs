using System;

namespace _05._Convert_a_Number_to_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int num = 1;
            //int num = -1;
            //int num = -2147483648;
            Console.WriteLine(solution.ToHex(num));
            Console.WriteLine(Convert.ToString(num, 16));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string ToHex(int num)
        {
            if (num == 0)
                return "0";
            string numHex = "";
            char[] hex = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            while (num != 0 && numHex.Length < 8)
            {
                numHex = hex[num & 15] + numHex;
                num >>= 4;
            }
            return numHex;
        }
    }
}