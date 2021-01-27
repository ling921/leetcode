using System;
using System.Collections.Generic;
using System.Linq;

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
            var count = 0;
            var dict = new Dictionary<(int, int), int>();
            foreach (var item in dominoes)
            {
                var key = item[0] > item[1] ? (item[1], item[0]) : (item[0], item[1]);
                if (dict.ContainsKey(key))
                    count += dict[key]++;
                else
                    dict[key] = 1;
            }

            return count;

            var temp = new int[10, 10];
            foreach (var item in dominoes)
            {
                count += temp[item.Min(), item.Max()]++;
            }

            //return dominoes
            //    .Select(i => i[0] > i[1] ? (i[1], i[0]) : (i[0], i[1]))
            //    .GroupBy(i => i)
            //    .Select(g => g.Count() * (g.Count() - 1) / 2)
            //    .Sum();
        }
    }
}
