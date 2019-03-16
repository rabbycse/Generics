using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> aList = new List<string>();
            aList.Add("Rabbi");
            aList.Add("Mosiur");
            aList.Add("Mahmud");

            aList.Insert(2, "Robin"); // Insert data

            foreach (var data in aList)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            if (aList.Contains("Rabbi")) // Findout data
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