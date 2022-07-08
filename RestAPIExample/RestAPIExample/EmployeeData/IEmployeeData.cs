using RestAPIExample.Models;
using System;
using System.Collections.Generic;


namespace RestAPIExample.EmpData



{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        void AddEmployee(Employee employee);
        Employee DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
        Employee GetHighestSalaryEmployee(string city);

        Employee GetEmployeeId(string EmployeeName);
    }
}
