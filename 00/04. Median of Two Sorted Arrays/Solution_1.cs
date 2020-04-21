namespace _04._Median_of_Two_Sorted_Arrays
{
    public class Solution_1
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] merge = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;
            while (i < nums1.Length || j < nums2.Length)
            {
                if (i < nums1.Length && j < nums2.Length)
                    merge[k++] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
                else if (i == nums1.Length)
                    merge[k++] = nums2[j++];
                else if (j == nums2.Length)
                    merge[k++] = nums1[i++];
            }
            if (merge.Length % 2 != 0)
                return merge[merge.Length / 2];
            else
                return (merge[merge.Length / 2 - 1] + merge[(merge.Length / 2)]) / 2.0;
        }
    }
}
