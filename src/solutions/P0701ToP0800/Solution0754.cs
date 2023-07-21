namespace P0701ToP0800
{
    /// <summary>
    /// 754. 到达终点数字
    /// </summary>
    public class Solution0754
    {
        public Solution0754()
        {
            var target = 5;
            WriteLine(ReachNumber(target));
        }

        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            int i = 0, sum = 0;
            while (sum < target)
                sum += ++i;
            return sum == target || ((sum - target) & 1) == 0 ? i : ((i + 1) >> 1 << 1) + 1;
        }
    }
}
