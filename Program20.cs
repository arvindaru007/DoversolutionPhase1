using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program20
    {
        static void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 100;    int b = 200;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");            

            Swap(ref a,ref b);

            Console.WriteLine($"After swap: a = {a}, b = {b}");

        }
    }
}
/*A method is a function inside a class
A method is a self contained block of statement to perform a task
A method can return a value to the caller

Methdo can be be defined as 
a) static	:	These methods will be called directly
b) regular	:	These methods will be called using object

 
 static void Wishes(string name)
        {
            int hour = DateTime.Now.Hour;
            if ( hour<12 )           Console.WriteLine($"Hello {name}, Good Morning!");
            else if (hour < 16) Console.WriteLine($"Hello {name}, Good Afternoon!");
            else Console.WriteLine($"Hello {name}, Good Evening!");
        }
        static void Main(string[] args)
        {
            Wishes("Sangeetha!");
        }
*/

