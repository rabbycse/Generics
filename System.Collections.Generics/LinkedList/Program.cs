using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<string> aLinkedList = new LinkedList<string>();
            aLinkedList.AddFirst("Today");
            aLinkedList.AddLast(",I am going to Dhaka");

            foreach (var data in aLinkedList)
            {
                Console.Write(data);
            }

            Console.ReadLine();
        }
    }
}