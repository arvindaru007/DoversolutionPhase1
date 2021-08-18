using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program17
    {
        static void Main(string[] args)
        {
            int[,] items = new int[, ] { { 100, 200,300 }, { 200, 300,400 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($"{items[i, j]} ");

                Console.WriteLine();
            }
            

        }
    }
}