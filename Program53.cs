using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    public static class StringExtensionMethods
    {
        public static string Upper(this string name)
        {
            return name.ToUpper();
        }
        public static string FirstName(this string fullName)
        {
            return fullName.Substring(0,fullName.IndexOf(" "));
        }
        public static string LastName(this string fullName)
        {
            return fullName.Substring(fullName.LastIndexOf(" ")+1);
        }
    }
    class Program53
    {
        static void Main(string[] args)
        {
            string fullName = "Kiran Kumar";
            Console.WriteLine(fullName.Upper());
            Console.WriteLine(fullName.FirstName());
            Console.WriteLine(fullName.LastName());
        }
    }
}
