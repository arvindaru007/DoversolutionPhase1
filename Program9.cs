using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    enum MartialStatus
    {
        Married, UnMarried, Divorce
    }
    class Program9
    {
        static void Main(string[] args)
        {
            MartialStatus p1 = MartialStatus.Married;
            if ( p1==MartialStatus.Married)
                Console.WriteLine("You can leave office at 7pm");
            else if ( p1==MartialStatus.UnMarried)
                Console.WriteLine("You have to staty till 8pm");
            else
                Console.WriteLine("You can leave any time");
        }
    }
}
/*
    enum: enumerated type, used to have set of constants
    Example:    Gender, MartialStatus, Color, Direction
 
  const used to have constatnt variable, which cannot be changed
   const string directorName= "Raj";
    Console.WriteLine(directorName);
 */