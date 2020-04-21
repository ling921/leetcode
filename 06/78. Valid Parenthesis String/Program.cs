using System;

namespace _78._Valid_Parenthesis_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "(*(()))((())())*(**(()))((*)()(()))*(())()(())(()";
            //string s = "*(**(";
            Console.WriteLine(solution.CheckValidString(s));
            Console.Read();
        }
    }
    public class Solution
    {
        public bool CheckValidString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            if (s[0] == ')' || s[s.Length - 1] == '(')
                return false;
            if (s.Length == 1)
                return s == "*";
            int i, j = s.IndexOf(')');
            if (j == -1)
            {
                i = s.IndexOf('(');
                if (i == -1)
                    return true;
                int count = 0;
                for (; i < s.Length; i++)
                    count += s[i] == '(' ? 1 : count > 1 ? count - 1 : 0;
                if (count > 0)
                    return false;
                return true;
            }
            else
            {
                i = s.Remove(j).LastIndexOf('(');
                if (i == -1 || j - i == 1)
                    return CheckValidString(s.Remove(j - 1) + s.Substring(j + 1));
                else
                    return CheckValidString(s.Remove(j - 1) + s.Substring(j + 1)) ||
                        CheckValidString(s.Remove(i) + s.Substring(j + 1)) ||
                        CheckValidString(s.Remove(i) + s.Substring(i + 2));
            }
        }
    }
}
