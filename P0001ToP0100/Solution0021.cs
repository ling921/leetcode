using CommonLibrary;

namespace P0001ToP0100
{
    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// </summary>
    public class Solution0021
    {
        public Solution0021()
        {
        }

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
}
