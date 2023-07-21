namespace P1301ToP1400
{
    /// <summary>
    /// 1328. 破坏回文串
    /// </summary>
    public class Solution1328
    {
        public Solution1328()
        {
            var palindrome = "abccba";
            //var palindrome = "aba";
            //var palindrome = "bbb";
            //var palindrome = "abba";
            WriteLine(BreakPalindrome(palindrome));
        }

        public string BreakPalindrome(string palindrome)
        {
            if (palindrome.Length == 1)
                return "";
            for (int i = 0; i <= palindrome.Length / 2 - 1; i++)
            {
                if (palindrome[i] != 'a')
                    return $"{palindrome[..i]}a{palindrome[(i + 1)..]}";
            }
            return $"{palindrome[..^1]}b";
        }
    }
}
