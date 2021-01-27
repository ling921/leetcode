namespace P0101ToP0200
{
    /// <summary>
    /// 136. Single Number
    /// </summary>
    public class Solution0136
    {
        public Solution0136()
        {
        }

        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var n in nums)
                result ^= n;
            return result;
        }
    }
}
