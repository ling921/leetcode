using CommonLibrary.DataStructures;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommonLibrary
{
    public static class DataLoadExtension
    {
        public static T[] ToArray<T>(this string text) where T : IConvertible
        {
            if (text.StartsWith("[["))
            {
                throw new ArgumentException("Arguement format is wrong!");
            }
            var match = Regex.Matches(text, @"(\-?\d+)");
            return match.Select(g => (T)Convert.ChangeType(g.Value, default(T).GetTypeCode())).ToArray();
        }

        public static T[,] To2DArray<T>(this string text) where T : IConvertible
        {
            var rows = text.ToArrayArray<T>();
            var col = rows.Min(r => r.Length);
            if (col != rows.Max(r => r.Length))
            {
                throw new ArgumentException("Number of each column are different!");
            }
            var result = new T[rows.Length, col];
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = rows[i][j];
                }
            }
            return result;
        }

        public static T[][] ToArrayArray<T>(this string text) where T : IConvertible
        {
            if (!text.StartsWith("[["))
            {
                throw new ArgumentException("Arguement format is wrong!");
            }
            var match = Regex.Matches(text, @"\[[\d\,\s]*\]");
            var row = match.Count;
            return match.Select(g => g.Value.ToArray<T>()).ToArray();
        }

        public static ListNode ToListNode(this string text)
        {
            var nums = text.ToArray<int>();
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
