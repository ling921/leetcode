using static CommonLibrary.Extensions.ConsoleExtension;
using System;
using System.Collections.Generic;
using System.Text;

namespace P0401ToP0500
{
    public class Solution0424
    {
        public Solution0424()
        {
            //var s = "ABAB";var k = 2;
            //var s = "AAAB";　var k = 0;
            //var s = "ABAA"; var k = 0;
            var s = "ABBB";
            var k = 2;
            WriteLine(CharacterReplacement(s, k));
        }

        public int CharacterReplacement(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int max = 0, count = 0, nextStartIndex = 0, j = k;
            char c = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    count++;
                }
                else
                {
                    if (j == k)
                    {
                        nextStartIndex = i;
                    }
                    if (j == 0)
                    {
                        c = s[nextStartIndex];
                        i = nextStartIndex;
                        max = Math.Max(max, count);
                        count = 1;
                        j = k;
                        continue;
                    }
                    count++;
                    j--;
                }
            }

            if (j > 0)
            {
                count = Math.Min(count + j, s.Length);
            }

            return Math.Max(max, count);
        }
    }
}