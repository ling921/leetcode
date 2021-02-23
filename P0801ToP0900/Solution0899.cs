using System.Linq;

namespace P0801ToP0900
{
    /// <summary>
    /// 899. 有序队列
    /// </summary>
    public class Solution0899
    {
        public Solution0899()
        {
        }

        public string OrderlyQueue(string S, int K)
        {
            if (K > 1)
                return string.Concat(S.ToCharArray().OrderBy(i => i));
            var res = S;
            for (int i = 1; i < S.Length; i++)
            {
                var temp = S[i..] + S[..i];
                if (res.CompareTo(temp) > 0)
                    res = temp;
            }
            return res;
        }
    }
}