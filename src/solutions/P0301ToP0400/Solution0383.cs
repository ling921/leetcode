namespace P0301ToP0400
{
    /// <summary>
    /// 383. Ransom Note
    /// </summary>
    public class Solution0383
    {
        public Solution0383()
        {
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in magazine)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic[c] = 1;
            }
            foreach (var c in ransomNote)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]--;
                    if (dic[c] < 0)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
