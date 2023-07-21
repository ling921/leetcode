using CommonLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommonLibrary.Extensions
{
    public static class DataLoadExtension
    {
        public static T[] ToArray<T>(this string text) where T : IConvertible
        {
            if (text.StartsWith("[["))
            {
                throw new ArgumentException("Arguement format is wrong!");
            }
            var match = Regex.Matches(text, @"[^,;\[\]]+");
            return match.Select(g => (T)Convert.ChangeType(g.Value, Type.GetTypeCode(typeof(T)))).ToArray();
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
            return match.Select(g => g.Value.ToArray<T>()).ToArray();
        }

        public static IList<IList<T>> ToJaggedList<T>(this string text) where T : IConvertible
        {
            if (!text.StartsWith("[["))
            {
                throw new ArgumentException("Arguement format is wrong!");
            }
            var match = Regex.Matches(text, @"\[[\d\,\s]*\]");
            return match.Select(g =>
            {
                var arr = g.Value.ToArray<T>();
                IList<T> list = new List<T>();
                foreach (var item in arr)
                {
                    list.Add(item);
                }
                return list;
            }).ToList();
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

        public static TreeNode ToTreeNode(this string text)
        {
            var nums = text
                .Split(new[] { '[', ']', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => i.Trim().Equals("null", StringComparison.OrdinalIgnoreCase) ? null : (int?)int.Parse(i.Trim()))
                .ToArray();
            if (nums.Length == 0 || nums[0] == null)
            {
                return null;
            }
            var root = new TreeNode(nums[0] ?? 0);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var deep = Math.Log(nums.Length + 1, 2);
            int level = 1;
            //while (queue.Count > 0)
            //{
            //    var values = nums
            //}

            //for (int i = 1; i < Math.Log(nums.Length + 1, 2); i++)
            //{
            //    root.left = new TreeNode()
            //}

            return root;
        }
    }
}