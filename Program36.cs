using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class BaseClass
    {
        private int dm1=100;    //This is accessible within the class only
        protected int dm2 = 200;    //This is accessible within and derived classes
        public int dm3 = 300;   //this is accessible everywhere
        public void DisplayBase()
        {
            Console.WriteLine($"dm1 = {dm1}, dm2 = {dm2}, dm3 = {dm3}");
        }
    }
    class DerviedClass:BaseClass
    {
        public void DisplayDerived()
        {   //dm1 is inaccessible due to its protection level
            Console.WriteLine($" dm2 = {dm2}, dm3 = {dm3}");
        }
    }
    class Program36
    {
        static void Main(string[] args)
        {
            DerviedClass o1 = new DerviedClass();
            o1.DisplayBase();
            o1.DisplayDerived();
            Console.WriteLine(o1.dm3);
        }
    }
}
/*
 Inheritance is the process of extending classes.
Inheritance is used acquire properties of base class to derived class

Advantage:  Inheritance provides facility reusability with extendibility.
Real time Example:	Windows 8 operating system is an inheritance of Windows 7					MyBook Version2 is an inheritance of Version1
*/