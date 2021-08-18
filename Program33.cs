using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Student
    {
        private int id, fee;
        private string sname, course;
        public Student(int id=-1, string sname="Not Provided", string course=".NET", int fee=10000)
        {
            this.id = id;   this.sname = sname; this.course = course;   this.fee = fee;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{this.id} {this.sname} {this.course} {this.fee}");
        }
    }
    class Program33
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1001, "Kiran", "MVC.NET", 50000);
            Student s2 = new Student(1002, "Raj", "Angular", 15000);
            Student s3 = new Student();
            s1.GetDetails();
            s2.GetDetails();
            s3.GetDetails();
        }
    }
}
/*
 Paramameterized constructor: Used to pass arguments while object creation
Note:   Constructor method can be overloaded
        Constructor method can have default parameter
    
 */