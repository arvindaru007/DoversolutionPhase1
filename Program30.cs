using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Numbers
    {
        //data members section
        private int num1,num2;       

        //member functions section
        public void SetNumbers(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void GetNumbers()
        {
            Console.WriteLine($"num1 = {this.num1}, num2 = {this.num2}");
        }
    }
    class Program30
    {
        static void Main(string[] args)
        {
            Numbers n1 = new Numbers();
            n1.SetNumbers(100,2500);            
            n1.GetNumbers();
        }
    }
}
/*
Class:	It is a user defined data type
Object:	Instance of a class

Date member:	Refers to variable inside a class
Member function:	Refers to function inside a class

private:	Access modifier restrict access of member to outside
public:		Acess modifier allow access of member to outside

 */