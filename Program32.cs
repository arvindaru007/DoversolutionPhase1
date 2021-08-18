using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("Object instantiation...");
        }
    }
    class Program32
    {
        static void Main(string[] args)
        {
            ConstructorDemo o1 = new ConstructorDemo();
            ConstructorDemo o2 = new ConstructorDemo();
        }
    }
}
/*
 constructor:	This method is used to instantiate data members
This is a special method
a) Exist with same name of the class
b) Invoke implcitly

Scenario:   The initial formalities while joining in company will be done using constructor
*/