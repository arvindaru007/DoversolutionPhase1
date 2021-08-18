using System;
using System.Collections;
namespace ConApp01
{
    class Program49
    {
        static void Main(string[] args)
        {
            // Hashtable employees = new Hashtable();
            SortedList employees = new SortedList();
            employees.Add("emp1", "eashwar");
            employees.Add("emp2", "eman");
            employees.Add("emp3", "eashwar");
            employees.Add("programmer1", "Pavan");
            employees.Add("hr1", "Harish");
            employees.Add("hr2", "hemanth");

            foreach( DictionaryEntry e in employees)
                Console.WriteLine($"key = {e.Key}, Value = {e.Value}");
        }
    }
}

/*SortedList:    It is a key and value paired collection, which store data in insertion sort logic
 * DictionaryEntry type contains Key and Value as properties
 * Using DictionaryEntry we can iterate in the Hashtable
 */