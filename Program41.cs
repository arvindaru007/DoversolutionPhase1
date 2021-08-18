using System;
using System.IO;
namespace ConApp01
{
    class Program41
    {
        static void Main(string[] args)
        {
            string fpath = @"e:\myfile1.txt";
            StreamWriter fname = new StreamWriter(fpath);

            fname.WriteLine("Welcome to File Handling");
            fname.WriteLine("File create from C#");
            fname.WriteLine("Create by kiran at " + DateTime.Now);

            Console.WriteLine("File created successfully...");
            fname.Close();
        }
    }
}
/*
 IO stands for Input and Output
.NET provided an API containing built in classes to handle a files,  namespace is System.IO
File Handling:	This is the feature used to handle files like
	Write data, read data, delete file, etc.,


To create Object:
StreamWriter obj = new StreamWrite("filename");
Note: The above system will create a new file, overwrite if file already exist

StreamWriter obj = new StreamWrite("filename",true);
By providing true as second parameter, the data will into the content


 */