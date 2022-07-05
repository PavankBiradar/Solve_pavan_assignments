using RestAPIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIExample.EmpData
{
    public class EmpDataImpl : IEmpData
    {
        private List<Employee> employees = new List<Employee>() {
            new Employee(){Id = 1,EmpName= "Pavankumar",Salary= 1200,City="Pune"},
            new Employee(){Id = 2,EmpName ="Rohan",Salary= 1500,City="Udgir"},
            new Employee(){Id = 3,EmpName= "Ram",Salary= 1700,City="Pune"},
            new Employee(){Id = 4,EmpName ="Shyam",Salary= 1100,City="Latur"},
            new Employee(){Id = 5,EmpName= "Ravan",Salary= 1900,City="Udgir"},
            new Employee(){Id = 6,EmpName ="Mohan",Salary= 800,City="Pune"},
            new Employee(){Id = 7,EmpName= "Pavan",Salary= 700,City="Latur"},
            new Employee(){Id = 8,EmpName ="Daman",Salary= 1300,City="Pune"},
        };
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee DeleteEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

         public Employee GetEmployee(int id)
         {
            var GetEmployeebyId = employees.FirstOrDefault(e => e.Id == id);
            return GetEmployeebyId;
             
         }

        public Employee GetHighestSalEmp(string city)
        {
            var HighestSalEmp = employees.Where(emp => emp.City == city).OrderByDescending(e => e.Salary).First();
            return HighestSalEmp;

        }
        public Employee GetEmpId(string Empname)
        {
            return employees.FirstOrDefault(emp => emp.EmpName == Empname);
           

        }

    }
}
