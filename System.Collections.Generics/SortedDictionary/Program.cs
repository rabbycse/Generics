using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> aSortedDictionary = new SortedDictionary<string, string>();
            aSortedDictionary.Add("1", "One");
            aSortedDictionary.Add("2", "Two");
            aSortedDictionary.Add("3", "Three");
            aSortedDictionary.Add("4", "Four");
            aSortedDictionary.Add("5", "Five");

            foreach (var data in aSortedDictionary)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            foreach (var data in aSortedDictionary.Keys)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            foreach (var data in aSortedDictionary.Values)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            string output;
            if (aSortedDictionary.TryGetValue(3, out output))
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