using System;
using System.Text;

namespace _43._Multiply_Strings
{
    public class Solution_1
    {
        //直接按低位到位处理
        public string Multiply(string num1, string num2)
        {
            int len1 = num1.Length, len2 = num2.Length;
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < len1 + len2; i++)
            {
                int j = Math.Max(0, i - len2), sum = 0;
                while (j < i && j < len1 && i - 1 - j < len2)
                {
                    sum += (num1[len1 - 1 - j] - '0') * (num2[len2 - i + j] - '0');
                    j++;
                }
                sum += carry;
                carry = sum / 10;
                sb.Insert(0, sum % 10);
            }
            if (carry != 0)
                sb.Insert(0, carry);
            while (sb[0] == '0' && sb.Length > 1)
                sb.Remove(0, 1);
            return sb.ToString();
        }
    }
}
