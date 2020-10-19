using System;
using System.Text;

namespace P0701ToP0800
{
    /// <summary>
    /// 709. To Lower Case
    /// </summary>
    public class Solution0709
    {
        public Solution0709()
        {
            Console.WriteLine(ToLowerCase("Hello"));
        }

        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in str)
            {
                sb.Append((c >= 'A' && c <= 'Z')
                    ? (char)(c - 'A' + 'a')
                    : c);
            }
            return sb.ToString();
        }
    }
}
