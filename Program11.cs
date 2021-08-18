using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program11
    {
        //Display wishes based on time
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12) Console.WriteLine("Good Morning!");
            else if (hour < 16) Console.WriteLine("Good Afternoon!");
            else Console.WriteLine("Good Evening!");

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0,3).ToLower();
            if ( day=="sat" ||day=="sun")
                Console.WriteLine("Today is weekend and busy with family");
            else
                Console.WriteLine("Today is weekday and enjoying office works");
        }
    }
}