using CommonLibrary.DataStructures;
using CommonLibrary.Extensions;
using System;

namespace P0001ToP0100
{
    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// </summary>
    public class Solution0021
    {
        public Solution0021()
        {
            var l1 = "[1,2,4]".ToListNode();
            var l2 = "[1,3,4]".ToListNode();
            Console.WriteLine(MergeTwoLists(l1, l2));
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode merge = new ListNode(0);
            var temp = merge;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    l2 = l2.next;
                }
                temp = temp.next;
            }
            if (l1 != null)
                temp.next = l1;
            if (l2 != null)
                temp.next = l2;
            return merge.next;
        }
    }
}
