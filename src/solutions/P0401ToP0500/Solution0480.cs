namespace P0401ToP0500
{
    /// <summary>
    /// 480. 滑动窗口中位数
    /// <para>中位数是有序序列最中间的那个数。如果序列的长度是偶数，则没有最中间的数；此时中位数是最中间的两个数的平均数。</para>
    /// <para>例如：</para>
    /// <para>[2,3,4]，中位数是 3</para>
    /// <para>[2,3]，中位数是(2 + 3) / 2 = 2.5</para>
    /// <para>给你一个数组 nums，有一个长度为 k 的窗口从最左端滑动到最右端。窗口中有 k 个数，每次窗口向右移动 1 位。你的任务是找出每次窗口移动后得到的新窗口中元素的中位数，并输出由它们组成的数组。</para>
    /// </summary>
    public class Solution0480
    {
        public Solution0480()
        {
            var nums = "[1,3,-1,-3,5,3,6,7]".ToArray<int>();
            var k = 3;
            WriteLine(MedianSlidingWindow(nums, k));
        }

        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            var result = new double[nums.Length - k + 1];
            var arr = nums[..k];
            Array.Sort(arr);
            result[0] = GetMdian(arr);

            for (int i = 0; i < nums.Length - k; i++)
            {
                ReplaceItemOfSortedArray(arr, nums[i], nums[i + k]);
                result[i + 1] = GetMdian(arr);
            }

            return result;
        }

        public void ReplaceItemOfSortedArray(int[] arr, int toRemove, int toAdd)
        {
            int indexToRemove = -1, indexToInsertBefore = -1;
            int left = 0, right = arr.Length - 1, mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (toRemove == arr[mid])
                {
                    indexToRemove = mid;
                    break;
                }
                else if (toRemove < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (toAdd <= arr[0])
            {
                indexToInsertBefore = 0;
            }
            else if (toAdd >= arr[^1])
            {
                indexToInsertBefore = -1;
            }
            else
            {
                left = 0;
                right = arr.Length - 1;
                while (left < right)
                {
                    if (left + 1 == right && arr[left] < toAdd && toAdd <= arr[right])
                    {
                        indexToInsertBefore = right;
                        break;
                    }
                    mid = (left + right) / 2;
                    if (toAdd == arr[mid])
                    {
                        indexToInsertBefore = mid;
                        break;
                    }
                    else if (toAdd < arr[mid])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid;
                    }
                }
            }

            if (indexToInsertBefore == -1)
            {
                if (indexToRemove < arr.Length - 1)
                    Buffer.BlockCopy(arr, (indexToRemove + 1) << 2, arr, indexToRemove << 2, (arr.Length - indexToRemove - 1) << 2);
                arr[^1] = toAdd;
                return;
            }
            if (indexToRemove == indexToInsertBefore)
            {
                arr[indexToRemove] = toAdd;
            }
            else if (indexToRemove < indexToInsertBefore)
            {
                Buffer.BlockCopy(arr, (indexToRemove + 1) << 2, arr, indexToRemove << 2, (indexToInsertBefore - indexToRemove - 1) << 2);
                arr[indexToInsertBefore - 1] = toAdd;
            }
            else
            {
                Buffer.BlockCopy(arr, indexToInsertBefore << 2, arr, (indexToInsertBefore + 1) << 2, (indexToRemove - indexToInsertBefore) << 2);
                arr[indexToInsertBefore] = toAdd;
            }
        }

        private double GetMdian(int[] arr)
        {
            return arr.Length % 2 == 0
                ? (arr[arr.Length / 2 - 1] + (double)arr[arr.Length / 2]) / 2
                : arr[arr.Length / 2];
        }
    }
}
