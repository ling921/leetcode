using System;
using System.Text;

namespace _86._Partition_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(2)
                            }
                        }
                    }
                }
            };
            Console.WriteLine(head);
            Console.WriteLine(new Solution().Partition(head, 3));

            Console.ReadLine();
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var node = this;
            while (node != null)
            {
                sb.Append(node.val);
                node = node.next;
            }
            return sb.ToString();
        }
    }
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode node = head, list1 = null, list2 = null, head1 = null, head2 = null;
            while (node != null)
            {
                if (node.val < x)
                {
                    if (head1 == null)
                    {
                        head1 = new ListNode(node.val);
                        list1 = head1;
                    }
                    else
                    {
                        list1.next = new ListNode(node.val);
                        list1 = list1.next;
                    }
                }
                else
                {
                    if (head2 == null)
                    {
                        head2 = new ListNode(node.val);
                        list2 = head2;
                    }
                    else
                    {
                        list2.next = new ListNode(node.val);
                        list2 = list2.next;
                    }
                }
                node = node.next;
            }
            if (head1 == null || head2 == null)
                return head;
            list1.next = head2;
            return head1;
        }
    }
}
