namespace P0001ToP0100
{
    /// <summary>
    /// 4. Median of Two Sorted Arrays
    /// </summary>
    public class Solution0004
    {
        public Solution0004()
        {
            var nums1 = "[8,9]".ToArray<int>();
            var nums2 = "[3,4,5,6,7]".ToArray<int>();
            var result = FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(result);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length, len2 = nums2.Length;
            if (len1 == 0)
                return GetMiddleOfArray(nums2);
            if (len2 == 0)
                return GetMiddleOfArray(nums1);
            if (nums1[0] > nums2[^1])
            {
                if (len1 > len2)
                    return GetMiddleOfArray(nums1[len2..]);
                else if (len1 < len2)
                    return GetMiddleOfArray(nums2[..^len1]);
                else
                    return (nums1[0] + nums2[^1]) / 2D;
            }
            else if (nums2[0] > nums1[^1])
            {
                if (len1 > len2)
                    return GetMiddleOfArray(nums1[..^len2]);
                else if (len1 < len2)
                    return GetMiddleOfArray(nums2[len1..]);
                else
                    return (nums1[0] + nums2[^1]) / 2D;
            }

            int i1 = 0, d1 = len1 - 1;
            int i2 = 0, d2 = len2 - 1;
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

        private double GetMiddleOfArray(int[] array)
        {
            if (array.Length % 2 == 0)
                return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2D;
            else
                return array[array.Length / 2];
        }
    }
}
