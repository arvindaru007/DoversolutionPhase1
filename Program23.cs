using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program23
    {
        static void Display()
        {
            Console.WriteLine("Hello Good Morning!");
        }
        static void Display(string name)
        {
            Console.WriteLine($"Hello {name} Good Morning!");
        }
        static void Main(string[] args)
        {
            Display();
            Display("Kiran");
        }
    }
}
/*
 Method overloading:    Refers to define more than onemethod with same name
*/