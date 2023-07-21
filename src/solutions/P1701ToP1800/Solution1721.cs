namespace P1701ToP1800
{
    public class Solution1721
    {
        public Solution1721()
        {
            var head = "[91,56,48,77,91,96,55,53,68]".ToListNode();
            WriteLine(SwapNodes(head, 7));
        }

        public ListNode SwapNodes(ListNode head, int k)
        {
            int count = 1;
            ListNode current = head, first = head, last = head;
            while (current.next != null)
            {
                if (count < k)
                {
                    first = first.next;
                }
                else
                {
                    last = last.next;
                }
                count++;
                current = current.next;
            }

            var temp = first.val;
            first.val = last.val;
            last.val = temp;
            return head;
        }

        public ListNode SwapNodes1(ListNode head, int k)
        {
            int count = 0;
            ListNode node = head, first = null;
            do
            {
                if (++count == k)
                {
                    first = node;
                }
                node = node.next;
            } while (node != null);

            var j = count - k;

            if (j == k - 1)
            {
                return head;
            }

            if (j > k - 1)
            {
                node = first;
                do
                {
                    k++;
                    node = node.next;
                } while (j > k - 1);
            }
            else
            {
                node = head;
                for (k = 0; k < j; k++)
                {
                    node = node.next;
                }
            }

            var temp = first.val;
            first.val = node.val;
            node.val = temp;
            return head;
        }
    }
}
