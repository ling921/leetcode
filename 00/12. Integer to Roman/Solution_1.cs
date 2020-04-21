namespace _12._Integer_to_Roman
{
    class Solution_1
    {
        public string IntToRoman(int num)
        {
            string[] roman = { "I", "V", "X", "L", "C", "D", "M" };
            int count = 0;
            string result = default(string);
            while (num > 0)
            {
                switch (num % 10)
                {
                    case 1:
                        result = roman[count * 2] + result;
                        break;
                    case 2:
                        result = roman[count * 2] + roman[count * 2] + result;
                        break;
                    case 3:
                        result = roman[count * 2] + roman[count * 2] + roman[count * 2] + result;
                        break;
                    case 4:
                        result = roman[count * 2] + roman[count * 2 + 1] + result;
                        break;
                    case 5:
                        result = roman[count * 2 + 1] + result;
                        break;
                    case 6:
                        result = roman[count * 2 + 1] + roman[count * 2] + result;
                        break;
                    case 7:
                        result = roman[count * 2 + 1] + roman[count * 2] + roman[count * 2] + result;
                        break;
                    case 8:
                        result = roman[count * 2 + 1] + roman[count * 2] + roman[count * 2] + roman[count * 2] + result;
                        break;
                    case 9:
                        result = roman[count * 2] + roman[count * 2 + 2] + result;
                        break;
                    default:
                        break;
                }
                count++;
                num /= 10;
            }
            return result;
        }
    }
}
