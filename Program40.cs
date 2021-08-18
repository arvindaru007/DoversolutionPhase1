using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    partial class MyClass
    {
        public void Display1()
        {
            Console.WriteLine("Hello from dispaly1");
        }
    }
    partial class MyClass
    {
        public void Display2()
        {
            Console.WriteLine("Hello from dispaly2");
        }
    }
    class Program40
    {
        static void Main()
        {
            MyClass o1 = new MyClass();
            o1.Display1();
            o1.Display2();
        }
    }
}
