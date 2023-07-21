namespace P0301ToP0400
{
    /// <summary>
    /// 338. 比特位计数
    /// </summary>
    public class Solution0338
    {
        public Solution0338()
        {
            WriteLine(CountBits(2));
            WriteLine(CountBits(5));
            WriteLine(CountBits(10));
            WriteLine(CountBits(45));
            WriteLine(CountBits(51));
            WriteLine(CountBits(63));
        }

        public int[] CountBits(int num)
        {
            var res = new int[num + 1];
            for (int i = 0; i < num; i++)
            {
                res[i + 1] = (i & 1) == 1 ? res[(i + 1) >> 1] : res[i] + 1;
            }
            return res;
        }
    }
}
