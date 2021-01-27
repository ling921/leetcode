using CommonLibrary;
using System;

namespace P0001ToP0100
{
    /// <summary>
    /// 2. Add Two Numbers
    /// </summary>
    public class Solution0002
    {
        public Solution0002()
        {
            var l1 = "[2,4,3]".LoadAsListNode();
            var l2 = "[5,6,4]".LoadAsListNode();
            var result = AddTwoNumbers(l1, l2);
            Console.WriteLine(result);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode curr = head;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return head.next;
        }
    }
}
