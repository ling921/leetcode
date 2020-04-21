using System;
using System.Collections.Generic;

namespace _89._Gray_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int v in new Solution().GrayCode(11))
            {
                Console.WriteLine(v);
            }

            Console.Read();
        }
    }
    public class Solution
    {
        public IList<int> GrayCode(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 1 << n; i++)
                result.Add(i ^ i >> 1);
            return result;
        }
    }
}
