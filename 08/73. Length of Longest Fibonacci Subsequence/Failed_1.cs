using System.Collections.Generic;

namespace _73._Length_of_Longest_Fibonacci_Subsequence
{
    /*
     * 测试用例，15.127秒
     * int[] A = { 12, 13, 15, 18, 26, 31, 34, 35, 37, 39, 41, 42, 45, 47, 49, 50, 52, 56, 57, 60, 61, 63, 69, 72, 78, 81, 83, 91, 97, 102, 107, 110, 113, 117, 126, 128, 140, 143, 153, 162, 171, 176, 179, 195, 209, 223, 234, 250, 264, 281, 286, 289, 312, 321, 337, 363, 377, 403, 426, 452, 465, 507, 516, 546, 586, 653, 690, 733, 751, 754, 819, 837, 883, 949, 1056, 1116, 1185, 1216, 1219, 1326, 1353, 1429, 1535, 1709, 1806, 1967, 1973, 2145, 2190, 2312, 2922, 3183, 3192, 3471, 3543, 3741, 4728, 5150, 5165, 5616, 5733, 6053, 7650, 8333, 8357, 9087, 9276, 13483, 13522, 14703, 15009, 21816, 21879, 23790, 24285, 35299, 35401, 38493, 39294, 63579 };
     */
    class Failed_1
    {
        public int LenLongestFibSubseq(int[] A)
        {
            List<List<int>> temp = new List<List<int>>();
            int maxLen = 0;
            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    temp.Add(new List<int>() { A[i], A[j], A[i] + A[j] });
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        foreach (var list in temp)
                        {
                            int len = list.Count - 1;
                            if (A[k] == list[len])
                                list.Add(A[k] + list[len - 1]);
                            if (A[k] > list[len] || k == A.Length - 1)
                            {
                                maxLen = list.Count > 3 && list.Count > maxLen ? list.Count - 1 : maxLen;
                            }
                        }
                    }
                }
            }
            return maxLen;
        }
    }
}