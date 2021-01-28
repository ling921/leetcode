using CommonLibrary.DataStructures;
using System;

namespace P0001ToP0100
{
    /// <summary>
    /// 25. Reverse Nodes in k-Group
    /// </summary>
    public class Solution0025
    {
        public Solution0025()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            Console.WriteLine(ReverseKGroup(head, 1));
            Console.WriteLine(ReverseKGroup(head, 2));
            Console.WriteLine(ReverseKGroup(head, 3));
            Console.WriteLine(ReverseKGroup(head, 4));
            Console.WriteLine(ReverseKGroup(head, 5));
            Console.WriteLine(ReverseKGroup(head, 6));

            Console.Read();
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int count = 1;
            ListNode current = head;
            while (current.next != null)
            {
                count++;
                current = current.next;
            }

            if (count < k || k == 1)
                return head;

            current = head;
            int times = count / k;
            ListNode pHead = new ListNode(0), cHead = new ListNode(0), left, right = head.next;

            for (int i = 0; i < times; i++)
            {
                for (count = 1; count <= k; count++)
                {
                    if (count == k)
                    {
                        if (i == 0)
                        {
                            pHead = head;
                            head = current;
                        }
                        else
                        {
                            pHead.next = current;
                            pHead = cHead;
                        }
                        current = right;
                        if (right == null)
                            break;
                        right = right.next;
                    }
                    else
                    {
                        if (count == 1)
                            cHead = current;
                        left = current;
                        current = right;
                        right = right.next;
                        current.next = left;
                    }
                }
            }
            if (current != null)
                pHead.next = current;
            else
                pHead.next = null;

            return head;
        }
    }
}
