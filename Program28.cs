using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program28
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter no's : ");
                int[] a = new int[5];
                for (int i = 0; i < 6; i++)
                    a[i] = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }


        }
    }
}
