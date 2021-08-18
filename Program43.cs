using System;
using System.IO;

namespace ConApp01
{
    class Program43
    {
        static void Main(string[] args)
        {
            string fpath = @"e:\myfile1.txt";
            FileStream fname = new FileStream(fpath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine("Added at EOF at "+DateTime.Now);
            sw.Close();

        }
    }
}
/*
 FileStream:    the object of this class, used to read or write append the file content
*/