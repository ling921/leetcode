namespace P0101ToP0200
{
    /// <summary>
    /// 171. Excel Sheet Column Number
    /// </summary>
    public class Solution0171
    {
        /// <summary>
        /// 171. Excel Sheet Column Number
        /// </summary>
        public Solution0171()
        {
            Console.WriteLine(TitleToNumber("A"));
            Console.WriteLine(TitleToNumber("Z"));
            Console.WriteLine(TitleToNumber("AA"));
            Console.WriteLine(TitleToNumber("ZZ"));
            Console.WriteLine(TitleToNumber("XFD"));

            Console.Read();
        }

        public int TitleToNumber(string s)
        {
            int num = 0, len = s.Length;
            for (int i = 0; i < len; i++)
                num += (s[len - i - 1] - 'A' + 1) * (int)Math.Pow(26, i);
            return num;
        }
    }
}
