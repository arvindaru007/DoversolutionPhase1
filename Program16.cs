﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program16
    {
        static void Main(string[] args)
        {
            string[] names = { "raj", "ram", "ganesh", "ashok", "chowdary", "kiran" };
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);


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