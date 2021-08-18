﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate 1 to 10 numbers using while loop...");
            int i = 1;
            while (i <= 10)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Generate 1 to 10 numbers using for loop...");
            for ( i = 1; i <=10 ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Generate 1 to 10 numbers using do..while loop...");
            i = 1;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 10);
            Console.WriteLine("\n=======================");
        }
    }
}
/*
 * Loop is an iteration control structure, used to repeat statement execution
 * C# support 3 loops
 * while loop:  entry control loop with infinite iterations
 * for loop: entry control loop, with finite iterations
 * do..while loop: exit control loop with infinite iterations
 */