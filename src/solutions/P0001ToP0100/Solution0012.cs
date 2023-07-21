namespace P0001ToP0100
{
    /// <summary>
    /// 12. Integer to Roman
    /// </summary>
    public class Solution0012
    {
        public Solution0012()
        {
        }

        public string IntToRoman(int num)
        {
            string[][] roman = new string[4][];
            roman[0] = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            roman[1] = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            roman[2] = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            roman[3] = new string[] { "", "M", "MM", "MMM" };
            int count = 0, temp = 0;
            StringBuilder result = new StringBuilder();
            while (num > 0)
            {
                temp = num % 10;
                result.Insert(0, roman[count][temp]);
                num /= 10;
                count++;
            }
            return result.ToString();
        }
    }
}
