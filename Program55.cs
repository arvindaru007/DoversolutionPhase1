using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program55
    {
        static void Main(string[] args)
        {
            Func<int, int> square = delegate (int n)
               {
                   return n * n;
               };

            Func<int, int> Next= delegate (int n)
            {
                return n +1;
            };

            Console.WriteLine(square(5));
            Console.WriteLine(Next(8));
        }
    }
}
/*
 * Func<T,T>: REfers to a function take an argument and return value to the caller
 */