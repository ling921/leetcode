using System.Collections.Generic;

namespace _87._First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (dic.ContainsKey(c))
                    dic[c] = -1;
                else
                    dic[c] = i;
            }
            foreach (var pair in dic)
            {
                if (pair.Value != -1)
                    return pair.Value;
            }
            return -1;
        }
    }
}
