namespace _91._Number_of_1_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
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
