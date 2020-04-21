using System;
using System.Collections.Generic;

namespace _50._Intersection_of_Two_Arrays_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> common = new List<int>();
            int i = 0, j = 0;
            while(i<nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                    i++;
                else if (nums1[i] > nums2[j])
                    j++;
                else
                {
                    common.Add(nums1[i]);
                    i++;j++;
                }
            }
            return common.ToArray();
        }
    }
}
