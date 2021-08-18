using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program15
    {
        static void Main(string[] args)
        {
            int[] items  = new int[5] ; //Array instantiation            
            int sum = 0;    int count = items.Length;         double avg = 0;
            int big = 0;    int small = 0;

            Console.WriteLine("Array input ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"Enter value for items[{i}]: ");
                items[i] = Convert.ToInt32(Console.ReadLine());
                sum += items[i];

                if (i == 0) big = small = items[0];
                else if (items[i] > big) big = items[i];
                else if (items[i] < small) small = items[i];
            }

            avg =(double) sum / count;
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($"items[{i}] = {items[i]} ");

            Console.WriteLine($"Count of elements: {count}");
            Console.WriteLine($"Sum of elements: {sum}\n Avg of elements: {avg}");
            Console.WriteLine($"Biggest element: {big}\nSmallest element: {small}");
        }
    }
}
/*
 * Array is a Programming feature, allow to store more than one value within a single identification and programmable. All elements will store in homogeneous order. Arrays are the best place to handle limited number of elements.

Application of an Array:
	Days in a month, Hours in day, 	Students in a classroom,  Seats in  bus, etc.,

Points to note:
Array is Abstract class in .NET Collection API
Array declared at compiled time (Stored in Stack Memory)
Arrays are index based collection, accessible using [ ] notation.
First element is accessible using 0 index, last element is accessible using Length-1 as index
Dimensions are accessible using Rank property

Limitations:
               Array variable will store one type of data.	
	Array variable size fixed (cannot enhance).
	Insertion, deletion and sorting, searching of elements in array is big process.

 */