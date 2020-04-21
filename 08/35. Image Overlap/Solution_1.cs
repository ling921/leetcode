using System;

namespace _35._Image_Overlap
{
    public class Solution_1
    {
        public int LargestOverlap(int[][] A, int[][] B)
        {
            int len = A.GetLength(0), result = 0;
            int[] valueA = GetLineValues(A);
            int[] valueB = GetLineValues(B);
            for (int i = 1 - len; i < len; i++)
                for (int j = 1 - len; j < len; j++)
                    result = Math.Max(result, GetOverlapOfOne(valueA, valueB, len, i, j));
            return result;
        }
        public int[] GetLineValues(int[][] arr)
        {
            int len = arr.GetLength(0);
            int[] values = new int[len];
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    values[i] = values[i] << 1 | arr[i][j];
            return values;
        }
        //把a看作是固定的，b在水平和垂直在[1-len,len-1]区间内平移
        public int GetOverlapOfOne(int[] a, int[] b, int len, int slideRight, int slideDown)
        {
            int result = 0;
            for (int i = 0; i < len - Math.Abs(slideDown); i++)
            {
                int temp = 0;
                if (slideDown > 0)
                {
                    if (slideRight > 0)
                        temp = a[slideDown + i] % (1 << (len - slideRight + 1)) & b[i] >> slideRight;
                    else
                        temp = a[slideDown + i] >> -slideRight & b[i] % (1 << (len + slideRight + 1));
                }
                else
                {
                    if (slideRight > 0)
                        temp = a[i] % (1 << (len - slideRight + 1)) & b[-slideDown + i] >> slideRight;
                    else
                        temp = a[i] >> -slideRight & b[-slideDown + i] % (1 << (len + slideRight + 1));
                }

                while (temp > 0)
                {
                    if ((temp | 1) == temp)
                        result++;
                    temp >>= 1;
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
