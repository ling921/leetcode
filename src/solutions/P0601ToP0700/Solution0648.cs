namespace P0601ToP0700
{
    /// <summary>
    /// 648. Replace Words
    /// </summary>
    public class Solution0648
    {
        public Solution0648()
        {
            Console.WriteLine();
        }

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
