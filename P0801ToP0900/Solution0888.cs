using static CommonLibrary.ConsoleExtension;
using CommonLibrary;
using System.Collections.Generic;
using System.Linq;

namespace P0801ToP0900
{
    /// <summary>
    /// 888. 公平的糖果棒交换
    /// <para>爱丽丝和鲍勃有不同大小的糖果棒：A[i] 是爱丽丝拥有的第 i 根糖果棒的大小，B[j] 是鲍勃拥有的第 j 根糖果棒的大小。</para>
    /// <para>因为他们是朋友，所以他们想交换一根糖果棒，这样交换后，他们都有相同的糖果总量。（一个人拥有的糖果总量是他们拥有的糖果棒大小的总和。）</para>
    /// <para>返回一个整数数组 ans，其中 ans[0] 是爱丽丝必须交换的糖果棒的大小，ans[1] 是 Bob 必须交换的糖果棒的大小。</para>
    /// <para>如果有多个答案，你可以返回其中任何一个。保证答案存在。</para>
    /// </summary>
    public class Solution0888
    {
        public Solution0888()
        {
            var A = "[1,1]".ToArray<int>();
            var B = "[2,2]".ToArray<int>();
            WriteLine(FairCandySwap(A, B));
        }

        public int[] FairCandySwap(int[] A, int[] B)
        {
            var temp = (A.Sum() - B.Sum()) / 2;
            var hashSet = new HashSet<int>();
            foreach (var item in A)
            {
                hashSet.Add(item);
            }
            foreach (var item in B)
            {
                if (hashSet.Contains(temp + item))
                {
                    return new[] { temp + item, item };
                }
            }
            return null;
        }

        public int[] FairCandySwap1(int[] A, int[] B)
        {
            var temp = (A.Sum() - B.Sum()) / 2;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] - B[j] == temp)
                        return new[] { A[i], B[j] };
                }
            }
            return null;
        }
    }
}