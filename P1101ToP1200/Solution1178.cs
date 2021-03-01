using static CommonLibrary.Extensions.ConsoleExtension;
using CommonLibrary.Extensions;
using System.Collections.Generic;

namespace P1101ToP1200
{
    /// <summary>
    /// 1178. 猜字谜
    /// </summary>
    public class Solution1178
    {
        public Solution1178()
        {
            //var words = "[\"aaaa\",\"asas\",\"able\",\"ability\",\"actt\",\"actor\",\"access\"]".ToArray<string>();
            //var puzzles = "[\"aboveyz\",\"abrodyz\",\"abslute\",\"absoryz\",\"actresz\",\"gaswxyz\"]".ToArray<string>();
            var words = "[\"apple\", \"pleas\", \"please\"]".ToArray<string>();
            var puzzles = "[\"aelwxyz\", \"aelpxyz\", \"aelpsxy\", \"saelpxy\", \"xaelpsy\"]".ToArray<string>();
            WriteLine(FindNumOfValidWords(words, puzzles));
        }

        public IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {
            var res = new List<int>();
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var wordSummary = 0;
                // 用int中的26位标记谜底a-z是否出现过, 并记录于字典
                foreach (var c in words[i])
                    wordSummary |= 1 << (c - 'a');

                if (dict.ContainsKey(wordSummary))
                    dict[wordSummary]++;
                else
                    dict[wordSummary] = 1;
            }

            for (int i = 0; i < puzzles.Length; i++)
            {
                int puzzleSummary = 0, count = 0;
                // 用同上方法计算谜面
                foreach (var c in puzzles[i])
                    puzzleSummary |= 1 << (c - 'a');

                foreach (var (k, v) in dict)
                {
                    if ((puzzleSummary | k) == puzzleSummary && ((1 << (puzzles[i][0] - 'a')) | k) == k)
                        count += v;
                }
                res.Add(count);
            }

            return res;
        }

        public IList<int> FindNumOfValidWords1(string[] words, string[] puzzles)
        {
            var res = new List<int>();
            var wordsSummary = new int[words.Length];

            // 用int中的26位标记谜底a-z是否出现过
            for (int i = 0; i < words.Length; i++)
            {
                foreach (var c in words[i])
                {
                    wordsSummary[i] |= 1 << (c - 'a');
                }
            }

            for (int i = 0; i < puzzles.Length; i++)
            {
                int puzzleSummary = 0, count = 0;
                // 用同上方法计算谜面
                foreach (var c in puzzles[i])
                {
                    puzzleSummary |= 1 << (c - 'a');
                }

                for (int j = 0; j < words.Length; j++)
                {
                    if ((puzzleSummary | wordsSummary[j]) == puzzleSummary && ((1 << (puzzles[i][0] - 'a')) | wordsSummary[j]) == wordsSummary[j])
                        count++;
                }
                res.Add(count);
            }

            return res;
        }
    }
}