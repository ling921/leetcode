using static CommonLibrary.Extensions.ConsoleExtension;
using System.Linq;
using CommonLibrary.Extensions;

namespace P0001ToP0100
{
    /// <summary>
    /// 27. 移除元素
    /// <para>给你一个数组 nums 和一个值 val，你需要 原地 移除所有数值等于 val 的元素，并返回移除后数组的新长度。</para>
    /// <para>不要使用额外的数组空间，你必须仅使用 O(1) 额外空间并原地 修改输入数组。</para>
    /// <para>元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。</para>
    /// </summary>
    public class Solution0027
    {
        public Solution0027()
        {
            WriteLine(@"示例 1:
给定 nums = [3,2,2,3], val = 3,
函数应该返回新的长度 2, 并且 nums 中的前两个元素均为 2。
你不需要考虑数组中超出新长度后面的元素。");
            WriteLine(separator);

            Write("输入：nums = [3,2,2,3]\r\n输出：");
            var nums = "[3,2,2,3]".ToArray<int>();
            WriteLine(RemoveElement(nums, 3));
        }

        public int RemoveElement(int[] nums, int val)
        {
            int notValCount = 0;
            foreach (int num in nums)
            {
                if (num != val)
                    nums[notValCount++] = num;
            }
            return notValCount;
        }
    }
}
