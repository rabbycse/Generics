using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> aHashSet = new HashSet<int>();
            aHashSet.Add(1);
            aHashSet.Add(2);
            aHashSet.Add(3);

            foreach (var data in aHashSet)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            if (aHashSet.Contains(4))
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }

            Console.WriteLine();

            //######//
            HashSet<int> EvenNumber = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                EvenNumber.Add(i * 2);
            }
            Console.Write("Even Numbers contains {0} elements: ", EvenNumber.Count);
            display(EvenNumber);

            Console.WriteLine();
            HashSet<int> OddNumber = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                OddNumber.Add((i * 2) + 1);
            }
            Console.Write("Odd Numbers contains {0} elements: ", OddNumber.Count);
            display(OddNumber);
            Console.ReadLine();
        }

        public static void display(HashSet<int> set)
        {
            Console.Write("{");
            foreach (var i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
    }
}