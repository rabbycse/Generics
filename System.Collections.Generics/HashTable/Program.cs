using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Program
    {
        public static void Main()
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("1", "One");
            aHashtable.Add(2, "Two");
            aHashtable.Add(3, 3);
            aHashtable.Add(4.3, 44.6);

            foreach (var data in aHashtable.Keys)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            foreach (var data in aHashtable.Values)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            if (aHashtable.Contains("One"))
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }


            Console.WriteLine();
            Hashtable openWith = new Hashtable
            {
                { "1", "One" },
                { 2, "Two" },
                { 3, 3 },
                { 3.3, 44.9 }
            };

            foreach (var data in openWith.Keys)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            foreach (var data in openWith.Values)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            if (openWith.Contains("1"))
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