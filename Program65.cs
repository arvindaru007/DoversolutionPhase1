using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    //With Single Responsible Principle (Decoupling)
    interface IUser
    {
        void SignUp();  //User Registration
        void SignIn();  //User Login
    }
    interface IEmail
    {
        void Compose();     //To send an email
        void ChekEmails();  //To receive an email
    }
    interface ILogger
    {
        void LogErrors();   //To log error
    }

    class Email : IUser, IEmail, ILogger
    {
        public void ChekEmails()
        {
            Console.WriteLine("Check Email: Code for Email Inbox");
        }

        public void Compose()
        {
            Console.WriteLine("Compose: Code to send an email");
        }


        public void LogErrors()
        {
            Console.WriteLine("Log errors: Code to log the erros");
        }

        public void SignIn()
        {
            Console.WriteLine("Sign In: Code to login to a user account");
        }

        public void SignUp()
        {
            Console.WriteLine("Sign Up: Code to register user");
        }
    }
    class Program65
    {
        static void Main(string[] args)
        {
            Email o = new Email();
            o.SignUp();
            o.SignIn();
            o.ChekEmails();
            o.Compose();
            o.LogErrors();
        }
    }
}
/*
 Single Responsibility Principle (SRP)
A class should take one responsibility and there should be one reason to change that class.
Every class or a module should have responsibility over a single part of the functionality provided by the software that responsibility should entirely encapsulate by that class.
Motivations:
	Maintainability
	Testability
	Flexibility and extensibility
	Parallel Development
	Loosely Coupling
	SOLID principals and Design Pattern play key role in the above motivations

 */