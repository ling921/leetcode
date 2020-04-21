using System;

namespace _08._String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MyAtoi("4193 with words"));

            Console.Read();
        }
    }
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            StringBuilder sb = new StringBuilder();
            bool isNumStart = false, isNegative = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    isNumStart = true;
                    if (sb.Length > 0 || str[i] != '0')
                        sb.Append(str[i]);
                }
                else if (sb.Length == 0 && !isNumStart)
                {
                    if (str[i] == ' ')
                        continue;
                    else if (str[i] == '+')
                        isNumStart = true;
                    else if (str[i] == '-')
                        isNumStart = isNegative = true;
                    else
                        return 0;
                }
                else
                    break;
            }
            if (sb.Length > 10)
                return isNegative ? int.MinValue : int.MaxValue;
            else if (sb.Length == 0)
                return 0;
            else
            {
                Int64 num = isNegative ? -Convert.ToInt64(sb.ToString()) : Convert.ToInt64(sb.ToString());
                return (num > int.MaxValue || num < int.MinValue) ? (isNegative ? int.MinValue : int.MaxValue) : (int)num;
            }
        }
    }
}
