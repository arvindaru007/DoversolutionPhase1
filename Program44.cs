using System;
using System.IO;
namespace ConApp01
{
    class Program44
    {
        static void Main(string[] args)
        {
            string fileName = @"e:\myfile1.txt";

            //Total File path
            Console.WriteLine("Path= " + Path.GetDirectoryName(fileName));

            //File path with FileName
            Console.WriteLine("Path= " + Path.GetFullPath(fileName));

            //Returns Extension of Path File
            Console.WriteLine("Extension of Path= " + Path.GetExtension(fileName));

            //Return FileName of Path
            Console.WriteLine("FileName of Path= " + Path.GetFileName(fileName));

        }
    }
}
