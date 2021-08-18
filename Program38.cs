using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    abstract class OpenUniversity
    {
        public void Courses()
        {
            Console.WriteLine("Courses are designed by the university");
        }
        public void Exams()
        {
            Console.WriteLine("Exams conducted by university");
        }
        public abstract void Enrollments();
        public abstract void Training();
    }
    class StudyCenter :OpenUniversity
    {
        public override void Enrollments()
        {
            Console.WriteLine("Advertiment and enrollments at study center");
        }
        public override void Training()
        {
            Console.WriteLine("Training at study center");
        }
    }
    class Program38
    {
        static void Main(string[] args)
        {
            OpenUniversity o1;
            o1 = new StudyCenter();

            o1.Courses();
            o1.Enrollments();
            o1.Training();
            o1.Exams();
        }
    }
}
/*
 * An abstract class is a partially implemented class.
An abstract class is a class contains both abstract (unimplemented) methods and concrete (implemented) methods, Abstract classes cannot be instantiated.

Why do we need?
It is used in the scenarios like part of the implementation to be done in derived (child) class.
Points to note:
	Abstract class contains abstract methods and concrete methods.
	An abstract class may or may not contain abstract method.
	An abstract class may or may not contain concrete method.
	Any class want to treat must inherit should be abstract (Abstract class must inherit)
	Abstract method should be in public modifier.

What is an abstract method?
This is an unimplemented method, Abstract methods must override in child class.

What are concrete methods?
Concreted methods are the methods which are implemented (also called as non abstract methods).
These are the implemented methods in abstract class.

Real time example:
Array is an abstract class in collection API
Array o = new int[5];

Scenario: University and study center
	university staff and study center staff will be there

university staff will do office works (implemented)
study center staff will do the business (unimplemented)

 */