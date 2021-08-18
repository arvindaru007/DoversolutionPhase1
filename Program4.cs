using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program4
    {
        //Read 3sub marks into m,p,c variables and display tot, avg, result and grade
        static void Main(string[] args)
        {
            Console.Write("Enter sub1(maths) marks: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub2(physics) marks: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub3(chemistry) marks: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int tot = m + p + c;        double avg = (double)tot / 3;
            Console.WriteLine($"Total marks: {tot},  Average marks: {avg}");

            string result = string.Empty;       string grade = string.Empty;
            if(m>=35 && p>=35 && c>=35)
            {
                result = "PASS";
                if (avg >= 75) grade = "A1";
                else if (avg >= 60) grade = "A";
                else if (avg >= 50) grade = "B";
                else grade = "C";
            }
            else
            {
                result = "FAIL";
                grade = "NA";
            }
            Console.WriteLine($"Result is: {result}, Grade is: {grade}");            
        }
    }
}

/*
 Control structure: Used to control statement execution
if:     used as branching
case:   used for constant expression in the condition
loop:   to iterate statements


relational operators:   >,>=,<,<=,==,!=
logical operators:      && (and),   || (or),    !(not)

 */