using System.Collections.Generic;

namespace P0301ToP0400
{
    /// <summary>
    /// 387. First Unique Character in a String
    /// </summary>
    public class Solution0387
    {
        public Solution0387()
        {

        }

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
