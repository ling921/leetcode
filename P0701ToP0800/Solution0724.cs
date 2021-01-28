using static CommonLibrary.ConsoleExtension;
using System;
using CommonLibrary;

namespace P0701ToP0800
{
    public class Solution0724
    {
        public Solution0724()
        {
            WriteLine(@"示例 1：
输入：
nums = [1, 7, 3, 6, 5, 6]
输出：3
解释：
索引 3 (nums[3] = 6) 的左侧数之和 (1 + 7 + 3 = 11)，与右侧数之和 (5 + 6 = 11) 相等。
同时, 3 也是第一个符合要求的中心索引。");
            WriteSeparator();

            Console.Write("输入：nums = [1, 7, 3, 6, 5, 6]\r\n输出：");
            var nums1 = "[1, 7, 3, 6, 5, 6]".ToArray<int>();
            WriteLine(PivotIndex(nums1));

            WriteSeparator();

            WriteLine(@"示例 2：
输入：
nums = [1, 2, 3]
输出：-1
解释：
数组中不存在满足此条件的中心索引。");
            WriteLine(separator);
            Console.Write("输入：nums = [1, 2, 3]\r\n输出：");
            var nums2 = "[1, 2, 3]".ToArray<int>();
            Console.WriteLine(PivotIndex(nums2));
        }

        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (left == sum - left - nums[i])
                {
                    return i;
                }
                left += nums[i];
            }

            return -1;
        }
    }
}
