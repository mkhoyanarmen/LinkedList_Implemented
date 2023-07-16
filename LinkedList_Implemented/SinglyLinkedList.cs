using System;

namespace LinkedList_Implemented
{
    internal class SinglyLinkedList<T>
    {
        public SinglyLinkedList() { }
        public SinglyLinkedList(T headData)
        {
            Head = new Node<T>(headData);
        }
        private Node<T> Head { get; set; }
        public void AddLast(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data);
            }
        }
        public void Remove(T data)
        {
            if (Head == null)
                throw new Exception("List is Empty");
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    if ((object)Head.Data == (object)data)
                    {
                        Head = Head.Next;
                        break;
                    }
                    else if ((object)current.Next.Data == (object)data)
                    {
                        if (current.Next.Next == null)
                        {
                            current.Next = null;
                            break;
                        }
                        else
                            current.Next = current.Next.Next;
                    }
                    current = current.Next;
                }
            }
        }
        public void PrintList()
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
