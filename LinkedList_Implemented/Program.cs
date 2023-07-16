using System;
using System.Collections.Generic;

namespace LinkedList_Implemented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SinglyLinkedList<string> list = new SinglyLinkedList<string>("1");
            //list.AddLast("2");
            //list.AddLast("3");
            //list.AddLast("4");
            //list.AddLast("1");

            //list.PrintList();
            //Console.WriteLine("-------");

            //list.Remove("3");
            //list.PrintList();

            DoublyLinkedList<string> list2 = new DoublyLinkedList<string>("1");
            list2.AddFirst("2");
            list2.AddLast("3");

            list2.PrintList();
            Console.WriteLine("---------");

            list2.RemoveAtEnd();
            list2.PrintList();
            Console.WriteLine("---------");

            list2.RemoveAtStart();
            list2.PrintList();
        }
    }
}
