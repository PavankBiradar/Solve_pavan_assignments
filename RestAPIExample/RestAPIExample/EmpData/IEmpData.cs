using RestAPIExample.Models;
using System;
using System.Collections.Generic;


namespace RestAPIExample.EmpData



{
    public interface IEmpData
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
        Employee GetHighestSalEmployee(string City);
    }
}
