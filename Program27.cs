﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program27
    {
        //Read 2 numbers into 2 variables and display division
        //Handle Overflow, divide by zero exceptions

        static void Main(string[] args)
        {
            int? a = null;   int ?b = null;  int? c = null;
            top:
            try
            {
                Console.Write("Enter value for a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value for b: ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Number cannot divisible by zero "+ex.Message);
                Console.WriteLine("b value changed to 1");
                goto top;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                c = a / 1;
            }
            finally
            {
                Console.WriteLine($"Divisoin is : {c}");
            }
        }
    }
}
