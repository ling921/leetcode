using System;
/*
给定一个正整数，检查他是否为交替位二进制数：换句话说，就是他的二进制数相邻的两个位数永不相等。

示例 1:

输入: 5
输出: True
解释:
5的二进制数是: 101
示例 2:

输入: 7
输出: False
解释:
7的二进制数是: 111
示例 3:

输入: 11
输出: False
解释:
11的二进制数是: 1011
 示例 4:

输入: 10
输出: True
解释:
10的二进制数是: 1010

*/
namespace _93._Binary_Number_with_Alternating_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 5;
            Console.WriteLine(solution.HasAlternatingBits(n));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool HasAlternatingBits(int n)
        {
            if (n % 2 == (n >> 1) % 2)
                return false;
            if (n == 1)
                return true;
            return HasAlternatingBits((int)n >> 1);
            //return ((n ^ (n >> 1)) & ((n ^ (n >> 1)) + 1)) == 0;
        }
    }
}