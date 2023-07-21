namespace P0901ToP1000
{
    public class Solution0978
    {
        public Solution0978()
        {
            //var arr = "[9,4,2,10,7,8,8,1,9]".ToArray<int>();
            //var arr = "[4,8,12,16]".ToArray<int>();
            //var arr = "[100]".ToArray<int>();
            //var arr = "[0,1,1,0,1,0,1,1,0,0]".ToArray<int>();
            var arr = "[0,8,45,88,48,68,28,55,17,24]".ToArray<int>();
            WriteLine(MaxTurbulenceSize(arr));
        }

        public int MaxTurbulenceSize(int[] arr)
        {
            int max = 1, up = 1, down = 1;
            for (int k = 1; k < arr.Length; k++)
            {
                if (arr[k - 1] < arr[k])
                {
                    up = down + 1;
                    down = 1;
                }
                else if (arr[k - 1] > arr[k + 1])
                {
                    down = up + 1;
                    up = 1;
                }
                else
                {
                    up = down = 1;
                }
                max = Math.Max(max, Math.Max(up, down));
            }
            return max;
        }

        public int MaxTurbulenceSize2(int[] arr)
        {
            if (arr.Length == 1)
                return 1;
            int max = 0, start1 = 0, start2 = 0;
            for (int k = 0; k < arr.Length - 1; k++)
            {
                if (!((k & 1) == 0 && arr[k] < arr[k + 1]) && !((k & 1) == 1 && arr[k] > arr[k + 1]))
                {
                    max = Math.Max(max, k - start1 + 1);
                    start1 = k + 1;
                }
                if (!((k & 1) == 0 && arr[k] > arr[k + 1]) && !((k & 1) == 1 && arr[k] < arr[k + 1]))
                {
                    max = Math.Max(max, k - start2 + 1);
                    start2 = k + 1;
                }
            }
            return Math.Max(max, arr.Length - Math.Min(start1, start2));
        }
    }
}
