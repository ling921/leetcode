using System;

namespace _47._Largest_Number_At_Least_Twice_of_Others
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Solution
    {
        public int DominantIndex(int[] nums)
        {
            bool isMoreThanTwice = false;
            int index = -1, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] >= 2 * max)
                {
                    max = nums[i];
                    index = i;
                    isMoreThanTwice = true;
                }
                else if(nums[i] >= max)
                {
                    max = nums[i];
                    index = i;
                    isMoreThanTwice = false;
                }
                else if(nums[i] * 2 > max)
                {
                    isMoreThanTwice = false;
                }
            }
            return isMoreThanTwice ? index : -1;
        }
    }
}
