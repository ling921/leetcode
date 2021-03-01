using System;

namespace P0601ToP0700
{
    /// <summary>
    /// 693. Binary Number with Alternating Bits
    /// </summary>
    public class Solution0693
    {
        public Solution0693()
        {
            int n = 5;
            Console.WriteLine(HasAlternatingBits(n));
        }

        public bool HasAlternatingBits(int n)
        {
            if (n % 2 == (n >> 1) % 2)
                return false;
            if (n == 1)
                return true;
            return HasAlternatingBits((int)n >> 1);
            //return ((n ^ (n >> 1)) & ((n ^ (n >> 1)) + 1)) == 0;
        }

        public bool A(int n)
        {
            foreach (var item in new int[] { 1, 2, 5, 10, 21, 42, 85, 170, 341, 682, 1365, 2730, 5461, 10922, 21845, 43690, 87381, 174762, 349525, 699050, 1398101, 2796202, 5592405, 11184810, 22369621, 44739242, 89478485, 178956970, 357913941, 715827882, 1431655765 })
            {
                if (n == item)
                    return true;
            }
            return false;
        }
    }
}