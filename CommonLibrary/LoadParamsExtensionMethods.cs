using System;
using System.Linq;

namespace CommonLibrary
{
    public static class LoadParamsExtensionMethods
    {
        private static readonly char[] splitChars = new[] { '[', ']', '(', ')', '{', '}', ',' };

        public static T[] LoadAsArray<T>(this string text) where T : IConvertible =>
            text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
                .Select(str => (T)Convert.ChangeType(str, default(T).GetTypeCode()))
                .ToArray();

        public static ListNode LoadAsListNode(this string text)
        {
            var nums = text.LoadAsArray<int>();
            if (nums.Length == 0)
                return null;
            var head = new ListNode(nums[0]);
            var curr = head;
            for (int i = 1; i < nums.Length; i++)
            {
                curr.next = new ListNode(nums[i]);
                curr = curr.next;
            }
            return head;
        }
    }
}
