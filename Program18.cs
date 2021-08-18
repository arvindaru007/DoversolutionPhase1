using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program18
    {
        static void Main(string[] args)
        {
            int[][] items; //Jagged array declaration
            items = new int[4][];   //instantiate with four rows


            items[0] = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            items[1] = new int[] { 2, 4 };
            items[2] = new int[] { 1, 2, 3, 4, 5, 6 };
            items[3] = new int[] { 2, 4, 5, 6 };

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items[i].Length; j++)
                    Console.Write($"{items[i][j]} ");

                Console.WriteLine();
            }
        }
    }
}
/*
 Jagged Array is used to declare an Array of Array
Jagged Array can contain different number of columns in every row.

Days in a year:
int[][] months;
months = new int[4][];

months[0] = new int[31];
months[1] = new int[29];
months[2] = new int[31];
months[3] = new int[30];

Scenario: 	Students in multiple class rooms

Points to note:
	This feature is available on .NET only (No other programming languages support this feature).
	This is array will have different number of columns in each rows
*/