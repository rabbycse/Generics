using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> aQueue = new Queue<string>();
            aQueue.Enqueue("One");
            aQueue.Enqueue("Two");
            aQueue.Enqueue("Three");
            aQueue.Enqueue("Four");
            aQueue.Enqueue("Five");

            foreach (var data in aQueue)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            if (aQueue.Contains("Two")) // Find data
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }

            Console.WriteLine();
            Console.WriteLine("Dequeuing '{0}'", aQueue.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", aQueue.Peek());
            Console.WriteLine("Dequeuing '{0}'", aQueue.Dequeue());

            Queue<string> queueCopy = new Queue<string>(aQueue.ToArray());
            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)    // data copy
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}