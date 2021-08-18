using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{

    interface IDal
    {
        void ConnectToDB();
        void AccessData();
    }
    class SqlDal : IDal
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Connected to MS Sql Server");
        }
        public void AccessData()
        {
            Console.WriteLine("Customer data bougth fromSql server");
        }
    }
    class OraDal : IDal
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Connected to Oracle DB Server");
        }
        public void AccessData()
        {
            Console.WriteLine("Customer data bougth from Oracle DB");
        }
    }

    class Customer
    {
        IDal dal;
        public Customer(IDal dal)
        {
            this.dal = dal;
        }
        public void GetData()
        {
            dal.ConnectToDB();
            dal.AccessData();
        }
    }

    class Program70
    {
        static void Main(string[] args)
        {
            Customer o1 = new Customer(new SqlDal());
            o1.GetData();

            Customer o2 = new Customer(new OraDal());
            o2.GetData();



        }
    }
}
/*
  DI (Dependency Injection) is a technique whereby one object supplies the dependencies of another object. A dependency is an object that can be used (a service). An injection is the passing of a dependency to a dependent object (a client) that would use it.

In real time the services are injected to a class using DI mechanism

 */