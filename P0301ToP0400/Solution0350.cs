using System;
using System.Collections.Generic;

namespace P0301ToP0400
{
    /// <summary>
    /// 350. Intersection of Two Arrays II
    /// </summary>
    public class Solution0350
    {
        public Solution0350()
        {
        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> common = new List<int>();
            int i = 0, j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                    i++;
                else if (nums1[i] > nums2[j])
                    j++;
                else
                {
                    common.Add(nums1[i]);
                    i++;
                    j++;
                }
            }
            return common.ToArray();
        }
    }
}
