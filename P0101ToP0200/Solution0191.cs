namespace P0101ToP0200
{
    /// <summary>
    /// 191. Number of 1 Bits
    /// </summary>
    public class Solution0191
    {
        public Solution0191()
        {

        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                    count++;
                n >>= 1;
            }
            return count;
        }
    }
}
