using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIExample.EmpData;
using RestAPIExample.Models;
using System;

namespace RestAPIExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData _employeeData;

        public EmployeeController(IEmployeeData employeeData) { 
         
            _employeeData=employeeData;
        
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetEmployees() { 

            return Ok(_employeeData.GetEmployees());

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            return Ok(_employeeData.GetEmployee(id));
        }

        [HttpGet]
        [Route("{City}")]
        public IActionResult GetHighestSalaryEmployee(string city)
        {
             
            return Ok(_employeeData.GetHighestSalaryEmployee(city));

        }

        [HttpPost]
        [Route("Add")]
        public void AddEmployee(Employee employee)
        {
            _employeeData.AddEmployee(employee);
        }


        [HttpPost]
        [Route("{EmployeeName}")]
        public IActionResult GetEmployeeId(string Employeename)
        {
            
            return Ok(_employeeData.GetEmployeeId(Employeename));

        }


    }
}
