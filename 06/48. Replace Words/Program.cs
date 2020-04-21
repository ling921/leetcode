using System.Collections.Generic;

namespace _48._Replace_Words
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string ReplaceWords(IList<string> dict, string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
                foreach (var item in dict)
                    if (words[i].StartsWith(item))
                        words[i] = item;
            return string.Join(" ", words);
        }
    }
}
