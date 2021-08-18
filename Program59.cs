using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program59
    {
        static void Main(string[] args)
        {
            Action display = () => Console.WriteLine("Hello, Good Morning!");
            display();

            Action<string> wishes = x => Console.WriteLine($"Hello {x}, welcome");
            wishes("Kiran");
            wishes("Harsha");
        }
    }
}
/*
 Lambda expression: It is a simple and a short function definition
Which can be provided definition as an argument
    Advantages:  Instant implementation

Will us inbuilt delegates (Action, Func, Predicate)  for demo purpose
These lambda expression called as arrow functions in javascript
 */