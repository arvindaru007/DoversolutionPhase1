using System.Collections.Generic;
using System.Linq;
namespace ConApp01
{
    class EmployeeBO
    {
        public List<EmpModel>employees  { get; set; }
        public EmployeeBO()
        {
            employees = new List<EmpModel>()
            {
                new EmpModel { Id = 1001, EName = "Bhardwaj", Job = "Trainer", Salary = 30000 },
                new EmpModel { Id = 1002, EName = "Bhaskar", Job = "Developer", Salary = 32000 },
                new EmpModel { Id = 1003, EName = "Poornima", Job = "Programmer", Salary = 35000 },
                new EmpModel { Id = 1004, EName = "Kiran", Job = "Trainer", Salary = 30000 },
                new EmpModel { Id = 1005, EName = "Nishit", Job = "Developer", Salary = 25000 },
                new EmpModel { Id = 1006, EName = "Arana", Job = "Trainer", Salary = 30000 },
                new EmpModel { Id = 1007, EName = "Yadav", Job = "Developer", Salary = 32000 },
                new EmpModel { Id = 1008, EName = "Rahul", Job = "Programmer", Salary = 35000 },
                new EmpModel { Id = 1009, EName = "Chetana", Job = "Trainer", Salary = 30000 },
                new EmpModel { Id = 1010, EName = "Vamshika", Job = "Developer", Salary = 25000 }
            };
        }
        //expression body method
        public List<EmpModel> GetAllEmployees() => employees;
        public EmpModel GetEmployeeById(int id)
        {
            return employees.Single(x => x.Id == id);
        }
        public void AddEmployee(EmpModel e)
        {
            employees.Add(e);
        }
        public void EditEmployee( EmpModel e)
        {
            int index = employees.FindIndex(x => x.Id == e.Id);
            employees[index] = e;
        }
        public void DeleteEmployee(EmpModel e)
        {
            int index = employees.FindIndex(x => x.Id == e.Id);
            employees.RemoveAt(index);
        }
    }
}
