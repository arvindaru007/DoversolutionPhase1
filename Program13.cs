using System;
using System.Threading;
namespace ConApp01
{
    class Program13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10 ; i++)
               Console.WriteLine($"{n} X {i} = {n*i}");
           
        }
    }
}
//Task: Generate mulitplication table