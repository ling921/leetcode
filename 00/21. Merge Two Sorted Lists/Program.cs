using System;

namespace _21._Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

        }
    }
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode merge = new ListNode(0);
            while (l1.next != null && l2.next != null)
            {
                if (l1.val <= l2.val)
                {
                    merge.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    merge.next = l1;
                    l1 = l1.next;
                }
            }
            return merge;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
