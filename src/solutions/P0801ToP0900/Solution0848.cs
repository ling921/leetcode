namespace P0801ToP0900
{
    /// <summary>
    /// 848. 字母移位
    /// </summary>
    public class Solution0848
    {
        public Solution0848()
        {
            var S = "abc";
            var shifts = "[3,5,9]".ToArray<int>();
            WriteLine(ShiftingLetters(S, shifts));
        }

        public string ShiftingLetters(string S, int[] shifts)
        {
            var newChars = new char[S.Length];
            var times = 0;
            for (int i = shifts.Length - 1; i >= 0; i--)
            {
                times = (times + shifts[i]) % 26;
                newChars[i] = S[i] + times > 'z' ? (char)(S[i] + times - 26) : (char)(S[i] + times);
            }
            return new string(newChars);
        }
    }
}
