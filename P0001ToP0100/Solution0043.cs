using System;
using System.Text;

namespace P0001ToP0100
{
    /// <summary>
    /// 43. Multiply Strings
    /// </summary>
    public class Solution0043
    {
        public Solution0043()
        {
            string num1 = "98973", num2 = "98973";
            Console.WriteLine(Multiply(num1, num2));
            Console.Read();
        }

        public string Multiply(string num1, string num2)
        {
            int len1 = num1.Length, len2 = num2.Length;
            int[] nums = new int[len1 + len2 - 1];
            for (int i = len1 - 1; i >= 0; i--)
                for (int j = len2 - 1; j >= 0; j--)
                    nums[len1 + len2 - i - j - 2] += (num1[i] - '0') * (num2[j] - '0');
            int endIndex = nums.Length - 1;
            int carry = 0;
            while (nums[endIndex] == 0 && endIndex > 0)
                endIndex--;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= endIndex; i++)
            {
                sb.Insert(0, (nums[i] + carry) % 10);
                carry = (nums[i] + carry) / 10;
            }
            if (carry != 0)
                sb.Insert(0, carry);
            return sb.ToString();
        }
    }
}
