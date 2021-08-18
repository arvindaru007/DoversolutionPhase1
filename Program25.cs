using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program25
    {
        static void Main(string[] args)
        {
            int ?a = null;
            if( a is null)
                Console.WriteLine("No value into the variable");
            else
                Console.WriteLine($"Value is {a}");

            string name = string.Empty;
            if( string.IsNullOrEmpty(name))
                Console.WriteLine("name is empty");
            else
                Console.WriteLine($"{name} is the value");
        }
    }
}
/*
 * nullbale types: used to have empty value into a variable
 * by prefix ? to the variable
 * int ?n=null;
 * 
 * To compare
 * if( n is null)
 *  statement
 */