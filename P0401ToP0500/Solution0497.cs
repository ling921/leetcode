using static CommonLibrary.Extensions.ConsoleExtension;
using System;

namespace P0401ToP0500
{
    /// <summary>
    /// 497. Random Point in Non-overlapping Rectangles
    /// </summary>
    public class Solution0497
    {
        public Solution0497()
        {
            int[][] rects = new int[2][];
            rects[0] = new int[] { -2, -2, -1, -1 };
            rects[1] = new int[] { 1, 0, 3, 0 };

            Solution s = new Solution(rects);

            for (int i = 0; i < 100; i++)
            {
                int[] arr = s.Pick();
                WriteLine(arr);
            }
        }

        private class Solution
        {
            private Random rnd;
            private int[][] rects;
            private int[] pointCount;
            private int sum;
            private int len;

            public Solution(int[][] rects)
            {
                rnd = new Random();
                this.rects = rects;
                len = rects.Length;
                pointCount = new int[len];
                for (int i = 0; i < len; i++)
                {
                    sum += (rects[i][2] - rects[i][0] + 1) * (rects[i][3] - rects[i][1] + 1);
                    Console.WriteLine(sum);
                    pointCount[i] = sum;
                }
            }

            public int[] Pick()
            {
                int i;
                if (len == 1)
                    i = 0;
                else
                {
                    int l = 0, r = len - 1, mid = r / 2;
                    int area = rnd.Next(0, sum);
                    Console.WriteLine(area);
                    while (l < r)
                    {
                        if (area >= pointCount[mid])
                            l = mid + 1;
                        else if (area >= (mid == 0 ? 0 : pointCount[mid - 1]) && area < pointCount[mid])
                            break;
                        else if (area < pointCount[mid])
                            r = mid;
                        mid = (l + r) / 2;
                    }
                    i = mid;
                }

                int x = rnd.Next(rects[i][0], rects[i][2] + 1);
                int y = rnd.Next(rects[i][1], rects[i][3] + 1);
                return new int[] { x, y };
            }
        }
    }
}
