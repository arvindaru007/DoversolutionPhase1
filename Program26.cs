using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program26
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int ?n=null;
            try
            {
                //This block used to place statements which may provide exception
                 n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                //This block used to handle exception
                Console.WriteLine("Input type not valid "+ex.Message);
                n = 0;
            }
            catch(Exception ex)
            {
                //This block used to handle exception
                Console.WriteLine("Error: "+ex.Message);
                n = 0;
            }
            finally
            {
                //This block process statement even error raised or not
                Console.WriteLine($"Square of {n} is {n * n}");
            }
            
        }
    }
}
/*
    An exception is a runtime error; 
    A statement which cannot be understandable or which cannot be handled by the program execution will be treated 
    as runtime error or an Exception.
Like: number divide by zero
    variable content value out of range
    data type mismatch
    array index out of range,etc.,
 */