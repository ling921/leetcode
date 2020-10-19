namespace P0001ToP0100
{
    /// <summary>
    /// 28. Implement strStr()
    /// </summary>
    public class Solution0028
    {
        public Solution0028()
        {

        }

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            return -1;
        }
    }
}
