using System;
using System.IO;

namespace ConApp01
{
    class Program42
    {
        static void Main(string[] args)
        {
            string fpath = @"e:\myfile1.txt";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fpath);

                string fileContent = sr.ReadToEnd();
                Console.WriteLine(fileContent);
            }
            catch ( FileNotFoundException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                Console.WriteLine($"{fpath} not exist...");
            }
            sr.Close();
        }
    }
}
/*
StreamReader object, contains methods usedto read content from the existing file
 */