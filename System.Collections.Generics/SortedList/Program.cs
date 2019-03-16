using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            SortedList<string, string> aSortedList = new SortedList<string, string>();
            aSortedList.Add("1", "Rabbi");
            aSortedList.Add("2", "Rakib");
            aSortedList.Add("3", "Robin");
            aSortedList.Add("4", "Mosiur");
            aSortedList.Add("5", "Rafiur");

            foreach (var data in aSortedList)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            foreach (var data in aSortedList.Keys)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            foreach (var data in aSortedList.Values)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            string output;
            if (aSortedList.TryGetValue("3", out output))
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