namespace P0901ToP1000
{
    /// <summary>
    /// 949. 给定数字能组成的最大时间
    /// </summary>
    public class Solution0949
    {
        public Solution0949()
        {
            var arr = "[1,2,3,4]".ToArray<int>();
            //var arr = "[2,0,6,6]".ToArray<int>();
            WriteLine(LargestTimeFromDigits(arr));
        }

        public string LargestTimeFromDigits(int[] arr)
        {
            var (hh, mm) = (-1, -1);
            for (int h1 = 0; h1 < 4; h1++)
            {
                for (int h2 = 0; h2 < 4; h2++)
                {
                    if (h2 == h1)
                        continue;
                    for (int m1 = 0; m1 < 4; m1++)
                    {
                        if (m1 == h1 || m1 == h2)
                            continue;
                        var hour = arr[h1] * 10 + arr[h2];
                        var min = arr[m1] * 10 + arr[6 - h1 - h2 - m1];
                        if (hour < 24 && min < 60 && (hh < hour || (hh == hour && mm < min)))
                            (hh, mm) = (hour, min);
                    }
                }
            }
            return (hh, mm) == (-1, -1) ? "" : $"{hh:D2}:{mm:D2}";
        }
    }
}
