using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for lmr: ");
            int lmr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for pmr: ");
            int pmr = Convert.ToInt32(Console.ReadLine());

            int bu = pmr - lmr;
            Console.WriteLine($"Billed units: {bu}");

            double ur = 0;
            if (bu < 150) ur = 1.75;
            else if (bu < 375) ur = 3.25;
            else if (bu < 500) ur = 5;
            else ur = 6.5;

            Console.WriteLine($"Unit Rate is: {ur}");
            double amount = bu * ur;
            Console.WriteLine($"Amoutn is: {amount}");
        }
    }
}
/*
 Task: Generate electricity bill
    INPUT:  lmr, pmr
    Calculate:  bu = pmr-lmr
    calculate UR
    BU      UR      
    <150    1.75
    <375    3.25
    <500    5
    >=500   6.5
    Calculate amount and display
 */