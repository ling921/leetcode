using System;

namespace _07._Reverse_Integer
{
    class Solution_1
    {
        public int Reverse(int x)
        {
            bool negative = x < 0;
            string numStr = negative ? x.ToString().Substring(1) : x.ToString();
            double reverseNum = 0;
            for (int i = 0; i < numStr.Length; i++)
                reverseNum += int.Parse(numStr.Substring(i, 1)) * Math.Pow(10, i);
            reverseNum = negative ? -reverseNum : reverseNum;
            return reverseNum < int.MinValue || reverseNum > int.MaxValue ? 0 : (int)reverseNum;
        }
    }
}
