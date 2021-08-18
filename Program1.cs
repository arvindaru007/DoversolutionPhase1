using System;

namespace ConApp01
{
    class Program1
    {
        //Templating literals:  Provide variable content within message
        static void Main(string[] args)
        {
            Console.Write("Enter no1: ");
            int a =Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter no2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b} ");
            Console.WriteLine($"Addition of {a} and {b} is {a+b}");
            Console.WriteLine($"Sub of {a} and {b} is {a - b}");
            Console.WriteLine($"Mult of {a} and {b} is {a * b}");
            Console.WriteLine($"Div of {a} and {b} is {a / b}");
        }
    }
}

//F5    =>  debug the project
//Ctrl+F5   =>To run the project
