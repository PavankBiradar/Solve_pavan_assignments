using RestAPIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIExample.EmpData
{
    public class EmployeeDataImplimentation : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>() {
            new Employee(){Id = 1,EmployeeName= "Pavankumar",Salary= 1200,City="Pune"},
            new Employee(){Id = 2,EmployeeName ="Rohan",Salary= 1500,City="Udgir"},
            new Employee(){Id = 3,EmployeeName= "Ram",Salary= 1700,City="Pune"},
            new Employee(){Id = 4,EmployeeName ="Shyam",Salary= 1100,City="Latur"},
            new Employee(){Id = 5,EmployeeName= "Ravan",Salary= 1900,City="Udgir"},
            new Employee(){Id = 6,EmployeeName ="Mohan",Salary= 800,City="Pune"},
            new Employee(){Id = 7,EmployeeName= "Pavan",Salary= 700,City="Latur"},
            new Employee(){Id = 8,EmployeeName ="Daman",Salary= 1300,City="Pune"},
        };

        public string EmployeeName { get; private set; }

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

        public Employee GetHighestSalaryEmployee(string city)
        {
            var HighestSalaryEmployee = employees.Where(emp => emp.City == city).OrderByDescending(e => e.Salary).First();
            return HighestSalaryEmployee;

        }
        public Employee GetEmployeeId(string Empname)
        {
            return employees.FirstOrDefault(emp => emp.EmployeeName == EmployeeName);
           

        }

    }
}
