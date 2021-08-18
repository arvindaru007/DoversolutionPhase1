using System;

namespace ConApp01
{
    interface IIEmail
    {
        void Compose();
        void Inbox();
    }
    class GEmail : IIEmail
    {
        public void Compose()
        {
            Console.WriteLine("Code to send email");
            Console.WriteLine("This featurehelps to write emails");
        }
        public void Inbox()
        {
            Console.WriteLine("Code to have inbox");
            Console.WriteLine("This feature help to read received email");
        }
    }
    class Program39
    {
        static void Main(string[] args)
        {
            IIEmail email;
            email = new GEmail();
            email.Compose();
            email.Inbox();

        }
    }
}
/*
 Interface is one of the type like class in oops programming.

Why do we need interface?
Interface is used as a contract, it contains only method specification (without implementation).
The methods in interface must implement in the derived classes

Points to note:	
	In C#.NET interface name should prefix with I (standard)
	The default access modifier in interface is public
	All the methods in interface are abstract
	Interface should not contains fields

C#.NET Collection API root type is IEnumerable is an Interface
IEnumerator if the return type of GetEnumerator in IEnumerable interface, which implement foreach loop
*/