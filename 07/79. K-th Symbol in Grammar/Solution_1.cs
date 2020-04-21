using System;

namespace _79._K_th_Symbol_in_Grammar
{
    public class Solution_1
    {
        public int KthGrammar(int N, int K)
        {
            MyLinkedList value = new MyLinkedList(0);
            //value.Print();
            for (int i = 2; i <= N; i++)
            {
                Node<int> node = value.First;
                while (node != null)
                {
                    value.Replace(node);
                    node = node.Next.Next;
                }
                //value.Print();
            }
            return value.FindValue(K);
        }
    }

    public class MyLinkedList
    {
        public MyLinkedList(int value)
        {
            First = new Node<int>(value);
            First.Next = null;
        }

        public Node<int> First { get; }

        public void Replace(Node<int> node)
        {
            if (node.Value == 0)
            {
                Node<int> newNode = new Node<int>(1);
                newNode.Next = node.Next;
                node.Next = newNode;
            }
            else
            {
                Node<int> newNode = new Node<int>(0);
                newNode.Next = node.Next;
                node.Next = newNode;
            }
        }

        public int FindValue(int index)
        {
            if (index == 0)
                return First.Value;
            Node<int> node = First;
            for (int i = 1; i < index; i++)
                node = node.Next;
            return node.Value;
        }

        public void Print()
        {
            Node<int> node = First;
            while (node != null)
            {
                Console.Write(node.Value);
                node = node.Next;
            }
            Console.WriteLine();
        }
    }


    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public Node<T> Next;
    }
}
