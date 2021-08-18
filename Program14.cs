using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate numbers using while loop: ");
            int i = 1100;
            while (i <= 10)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine("\n======================================");


            Console.WriteLine("Generate numbers using do..while loop: ");
            i = 1100;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 10);
            Console.WriteLine("\n======================================");
        }
    }
}
/*
 * while loop is an entry control (pre tested loop) and it is infinite
 * do..while is an exit control (post tested loop) and it is also infinite
 */