using System;
using System.Collections.Generic;
using System.Linq;
namespace ConApp01
{
    class Program64
    {
        static void Main(string[] args)
        {
            EmployeeBO context = new EmployeeBO();
            List<EmpModel> employees;

            //employee= context.GetAllEmployees().Take(3).ToList();
            //employees = context.GetAllEmployees().Skip(3).ToList();
            employees = context.GetAllEmployees().Where(x => x.Job == "Developer").ToList();

            foreach (EmpModel e in employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
