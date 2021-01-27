using System;

namespace P1101ToP1200
{
    public class Solution1128
    {
        public Solution1128()
        {
            var dominoes = new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 3, 4 }, new[] { 5, 6 } };
            Console.WriteLine(NumEquivDominoPairs(dominoes));
        }

        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var temp = new int[100];
            int count = 0, positon = 0;
            for (int i = 0; i < dominoes.Length; i++)
            {
                positon = Math.Min(dominoes[i][0], dominoes[i][1]) * 10 + Math.Max(dominoes[i][0], dominoes[i][1]);
                count += temp[positon]++;
            }
            return count;
        }
    }
}
