using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class ParentClass
    {
        protected string name;
        protected int age;
        public ParentClass(string name,int age)        {
            this.name = name;   this.age = age;
        }
        public virtual void Display()        {
            Console.WriteLine($"Parent Name: {name}, Age: {age}");
        }
    }
    class ChildClass :ParentClass
    {
        public ChildClass(string name, int age)        : base(name,age)
        {                   }
        public override void Display()
        {
            Console.WriteLine($"Child Name: {name}, Age: {age}");
        }
    }
    class Program37
    {
        static void Main(string[] args)
        {
            ParentClass o1;
            o1 = new ParentClass("Amitabh",70);
            o1.Display();

            o1 = new ChildClass("Abhishek",35);
            o1.Display();
        }
    }
}
/*
 * Virtual method
 * 
 * When the object declared for base class and memory allocated to derived , 
 * the base class method override even memory refers to child class
 * 
 * to overcome prefix virtual to the base class method and override in child class
 */