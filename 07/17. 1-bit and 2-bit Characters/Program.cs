using System;

namespace _17._1_bit_and_2_bit_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits.Length == 1)
                return true;
            int index = 0;
            while(index < bits.Length - 1)
            {
                if (bits[index] == 1)
                    index += 2;
                else
                    index++;
            }
            return index == bits.Length - 1;
        }
    }
}
