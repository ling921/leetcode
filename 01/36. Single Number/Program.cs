using System;

namespace _36._Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var n in nums)
                result ^= n;
            return result;
        }
    }
}
