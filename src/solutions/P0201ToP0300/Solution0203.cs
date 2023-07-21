namespace P0201ToP0300
{
    public class Solution0203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode first = null, pre = null;
            while (head != null)
            {
                if (head.val == val)
                {
                    if (pre != null)
                        pre.next = head.next;
                }
                else
                {
                    if (first == null)
                        first = head;
                    pre = head;
                }
                head = head.next;
            }
            return first;
        }
    }
}
