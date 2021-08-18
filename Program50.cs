using System;
using System.Collections.Generic;

namespace ConApp01
{
    class Program50
    {
        static void Main(string[] args)
        {
            /*List<string> fruits = new List<string> { "Banana", "Cherry", "Mango", "Grapes", "Papaya", "Apple" };
            foreach( string fruit in fruits)
                Console.WriteLine(fruit); */

            List<int> items = new List<int> { 10, 20, 30 };
            items.Insert(0, 5);
            items.Add(40);
            foreach( int item in items)
                Console.WriteLine(item);
        }
    }
}
/*
 * Generic used to restrict datatype in the collection 
 */