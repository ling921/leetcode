using System;

namespace _04._Median_of_Two_Sorted_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 3 };
            int[] nums2 = new int[] { -2, -1 };
            Solution solution = new Solution();
            Console.WriteLine(solution.FindMedianSortedArrays(nums1, nums2));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
                return nums2.Length % 2 == 0 ? (nums2[nums2.Length / 2] + nums2[nums2.Length / 2 - 1]) / 2.0 : nums2[nums2.Length / 2];
            if (nums2.Length == 0)
                return nums1.Length % 2 == 0 ? (nums1[nums1.Length / 2] + nums1[nums1.Length / 2 - 1]) / 2.0 : nums1[nums1.Length / 2];
            int i1 = 0, d1 = nums1.Length - 1;
            int i2 = 0, d2 = nums2.Length - 1;
            int m1 = 0, m2 = 0;
            while (i1 < d1 || i2 < d2)
            {
                if (i1 == d1 && i2 < d2)
                {
                    if (d2 - i2 == 1)
                    {
                        m1 = nums2[i2];
                        m2 = nums2[d2];
                        break;
                    }
                    else if (d2 - i2 == 2)
                    {
                        m1 = m2 = nums2[i2 + 1];
                        break;
                    }
                    i2++;
                    d2--;
                }
                else if (i1 < d1 && i2 == d2)
                {
                    if (d1 - i1 == 1)
                    {
                        m1 = nums1[i1];
                        m2 = nums1[d1];
                        break;
                    }
                    else if (d1 - i1 == 2)
                    {
                        m1 = m2 = nums1[i1 + 1];
                        break;
                    }
                    i1++;
                    d1--;
                }
                else
                {
                    if (nums1[i1] > nums2[i2])
                        i2++;
                    else
                        i1++;
                    if (nums1[d1] > nums2[d2])
                        d1--;
                    else
                        d2--;
                    if (d1 - i1 == 0 && d2 - i2 == 0)
                    {
                        m1 = nums1[i1];
                        m2 = nums2[i2];
                        break;
                    }
                }
            }
            return (m1 + m2) / 2.0;
        }
    }
}
