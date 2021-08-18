using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program60
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int> next = x => x + 1;
            Func<int, int> cube = x => x * x * x;

            Console.WriteLine(square(5));
            Console.WriteLine(next(7));
            Console.WriteLine(cube(7));

            Func<string, string> upper = x => x.ToUpper();
            Func<string, string> fname = x => x.Substring(0, x.IndexOf(" "));
            Func<string, string> lname = x => x.Substring(x.LastIndexOf(" ") + 1);

            Func<string, int> len = x => x.Length;

            Console.WriteLine(len("Kiran Kumar"));
            Console.WriteLine(upper("Kiran Kumar"));
            Console.WriteLine(fname("Kiran Kumar"));
            Console.WriteLine(lname("Kiran Kumar"));
        }
    }
}
