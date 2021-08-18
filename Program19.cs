using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program19
    {
        static void Main(string[] args)
        {
            string[][] batches; //jagged array declaration
            batches = new string[4][];   //instantiate with four rows

            batches[0] = new string[] { "anil", "ashok", "arun" };
            batches[1] = new string[] { "bhanu", "bhrath", "bhaskar", "bhagvan" };
            batches[2] = new string[] { "chandu", "charan" };
            batches[3] = new string[] { "daniel", "david", "danny", "devender", "Daina" };

            for (int i = 0; i < batches.Length; i++) // refers to total rows
            {
                for (int j = 0; j < batches[i].Length; j++) // refers to columns in each row
                    Console.Write($"{batches[i][j]} ");

                Console.WriteLine();
            }

        }
    }
}