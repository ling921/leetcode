namespace P0401ToP0500
{
    /// <summary>
    /// 405. Convert a Number to Hexadecimal
    /// </summary>
    public class Solution0405
    {
        public Solution0405()
        {
            int num = 1;
            //int num = -1;
            //int num = -2147483648;
            Console.WriteLine(ToHex(num));
            Console.WriteLine(Convert.ToString(num, 16));
        }

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
