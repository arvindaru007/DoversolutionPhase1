using System;
using System.Collections;
namespace ConApp01
{
    class Program48
    {
        static void Main(string[] args)
        {
            Hashtable employees= new Hashtable();
            employees.Add("emp1","eashwar");
            employees.Add("emp2", "eman");
            employees.Add("emp3", "eashwar");
            employees.Add("programmer1", "Pavan");
            employees.Add("hr1", "Harish");
            employees.Add("hr2", "hemanth");

            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            if( employees.Contains(key))
                Console.WriteLine(employees[key].ToString());
            else
                Console.WriteLine($"{key} not exist...");
            Console.WriteLine();
        }
    }
}
/*Hashtable:    It is a key and value paired collection
 * DictionaryEntry type contains Key and Value as properties
 * Using DictionaryEntry we can iterate in the Hashtable
 */