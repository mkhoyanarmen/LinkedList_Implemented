using System;

namespace LinkedList_Implemented
{
    internal class DoublyLinkedList<T>
    {
        private Node<T> Head { get; set; }
        public DoublyLinkedList(){}
        public DoublyLinkedList(T data)
        {
            Head = new Node<T>(data);
        }
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Previous = current;
            }
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Head.Previous = newNode;
                newNode.Next = Head;
            }
            Head = newNode;
        }
        public void RemoveAtStart()
        {
            if (Head == null)
            {
                throw new Exception("List is Empty");
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }
        }
        public void RemoveAtEnd()
        {
            if (Head == null)
            {
                throw new Exception("List is Empty");
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Previous.Next = null;
                current.Previous = null;
            }
        }
        public void PrintList()
        {
            if (Head == null)
            {
                throw new Exception("List is Empty");
            }
            else
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }
    }
}
