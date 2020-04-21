namespace _18._Maximum_product_of_word_lengths
{
    public class Solution_v1
    {
        public int MaxProduct(string[] words)
        {
            if (words.Length == 0)
                return 0;
            int[,] wordInfo = new int[words.Length, 26];
            foreach (var c in words[0])
                wordInfo[0, c - 'a']++;

            int result = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    int temp = words[i].Length * words[j].Length;
                    bool HasSameLetters = false;
                    foreach (var c in words[j])
                    {
                        wordInfo[j, c - 'a']++;
                        if (wordInfo[i, c - 'a'] > 0)
                            HasSameLetters = true;
                    }
                    if (!HasSameLetters)
                        result = temp > result ? temp : result;
                }
            }
            return result;
        }
    }
}
