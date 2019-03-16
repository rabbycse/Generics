using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> aDictionary = new Dictionary<int, string>();
            aDictionary.Add(1, "Rabbi");
            aDictionary.Add(2, "Robin");
            aDictionary.Add(3, "Rakib");

            aDictionary[4] = "Rafi";

            foreach (var data in aDictionary)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            foreach (KeyValuePair<int, string> keyValuePair in aDictionary)
            {
                Console.WriteLine(keyValuePair.Key);
            }

            Console.WriteLine();
            foreach (var data in aDictionary)
            {
                Console.WriteLine("For key = " + data.Key + "; Value = " + data.Value);
            }

            Console.WriteLine();
            string output;
            if (aDictionary.TryGetValue(2, out output))
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }

            Console.WriteLine();




            // key:string; value:string
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            foreach (var data in openWith)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            foreach (var data in openWith)
            {
                Console.WriteLine("For key = " + data.Key + "; Value = " + data.Value);
            }

            Console.WriteLine();
            string value = "";
            if (openWith.TryGetValue("txt", out value))
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
