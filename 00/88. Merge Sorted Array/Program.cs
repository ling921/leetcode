using System;

namespace _88._Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums1 = { 0, 0, 0, 0, 0 };
            int[] nums2 = { 1, 2, 3, 4, 5 };
            int m = 0, n = 5;
            solution.Merge(ref nums1, m, nums2, n);
            foreach (int item in nums1)
                Console.WriteLine(item);
            Console.Read();
        }
    }
    public class Solution
    {
        public void Merge(ref int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= 0; i--)
            {
                if (m > 0 && n > 0)
                    nums1[i] = nums2[n - 1] >= nums1[m - 1] ? nums2[n-- - 1] : nums1[m-- - 1];
                else if (m == 0)
                    nums1[i] = nums2[n-- - 1];
                else if (n == 0)
                    return;
            }
        }
    }
}
