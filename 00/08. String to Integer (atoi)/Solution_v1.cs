using System;
using System.Text;

namespace _08._String_to_Integer__atoi_
{
    class Solution_v1
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            StringBuilder sb = new StringBuilder();
            bool isNumStart = false, zeroSkipped = false, isNegative = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!isNumStart)
                {
                    if (str[i] == ' ')
                        continue;
                    else if (str[i] == '+' || str[i] == '-')
                    {
                        isNumStart = true;
                        isNegative = str[i] == '+' ? false : true;
                    }
                    else if (str[i] >= '0' && str[i] <= '9')
                    {
                        isNumStart = true;
                        if (str[i] != '0')
                        {
                            sb.Append(str[i]);
                            zeroSkipped = true;
                        }
                    }
                    else
                        return 0;
                }
                else
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        if (zeroSkipped)
                            sb.Append(str[i]);
                        else if (str[i] != '0')
                        {
                            sb.Append(str[i]);
                            zeroSkipped = true;
                        }
                    }
                    else
                        break;
                }
            }
            if (sb.Length > 10)
                return isNegative ? int.MinValue : int.MaxValue;
            else if (!zeroSkipped)
                return 0;
            else
            {
                Int64 num = isNegative ? -Convert.ToInt64(sb.ToString()) : Convert.ToInt64(sb.ToString());
                return (num > int.MaxValue || num < int.MinValue) ? (isNegative ? int.MinValue : int.MaxValue) : (int)num;
            }
        }
    }
}
