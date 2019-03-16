using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<string> aStack = new Stack<string>();
            aStack.Push("One");
            aStack.Push("Two");
            aStack.Push("Three");
            aStack.Push("Four");
            aStack.Push("Five");

            foreach (var data in aStack)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();

            if (aStack.Contains("Two"))
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }
            Console.ReadLine();
        }
    }
}