using System;
using System.Collections.Generic;

namespace _84._Shuffle_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        private int[] defaultArray;
        private int len;

        public Solution(int[] nums)
        {
            defaultArray = nums;
            len = nums.Length;
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return defaultArray;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            int[] newNums = new int[len];
            List<int> list = new List<int>(defaultArray);
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                int temp = rand.Next(0, len - i);
                newNums[i] = list[temp];
                list.RemoveAt(temp);
            }
            return newNums;
        }
    }
}
