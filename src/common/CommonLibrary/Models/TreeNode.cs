using System;
using System.Collections.Generic;

namespace CommonLibrary.Models
{
    public class TreeNode
    {
        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }

        public static implicit operator string(TreeNode node) => node.ToString();

        public override string ToString()
        {
            return string.Join(Environment.NewLine, PrintTree(this, true));
        }

        protected IEnumerable<string> PrintTree(string indent, bool last)
        {
            var strs = new List<string> { $"{indent}+- {val}" };
            indent += last ? "   " : "|  ";
            strs.AddRange(left.PrintTree(indent, false));
            strs.AddRange(right.PrintTree(indent, true));
            return strs;
        }
    }
}