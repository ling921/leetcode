using static CommonLibrary.Extensions.ConsoleExtension;

namespace P0701ToP0800
{
    /// <summary>
    /// 738. 单调递增的数字 <para>给定一个非负整数 N，找出小于或等于 N 的最大的整数，同时这个整数需要满足其各个位数上的数字是单调递增。</para> <para>（当且仅当每个相邻位数上的数字 x 和 y 满足 x
    /// <= y 时，我们称这个整数是单调递增的。）</para> </summary>
    public class Solution0738
    {
        public Solution0738()
        {
            var n = 10;
            WriteLine(MonotoneIncreasingDigits(n));
        }

        public int MonotoneIncreasingDigits(int N)
        {
            if (N < 10)
                return N;
            var str = N.ToString();
            var flag = false;
            var res = str[0] - '0';
            for (int i = 1; i < str.Length; i++)
            {
                if (flag)
                {
                    res = res * 10 + 9;
                }
                else if (str[i] < str[i - 1])
                {
                    res = MonotoneIncreasingDigits(res - 1) * 10 + 9;
                    flag = true;
                }
                else
                {
                    res = res * 10 + str[i] - '0';
                }
            }
            return res;
        }
    }
}