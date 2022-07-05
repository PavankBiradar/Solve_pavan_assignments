using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIExample.EmpData;
using RestAPIExample.Models;
using System;

namespace RestAPIExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class EmployeesController : ControllerBase
    {
        private IEmpData _empData;

        public EmployeesController(IEmpData empData) { 
         
            _empData=empData;
        
        }
        [HttpGet]
        [Route("GetAllEmp")]
        public IActionResult GetEmployees() { 

            return Ok(_empData.GetEmployees());

        }

        [HttpGet]
        [Route("GetEmpbyId/{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _empData.GetEmployee(id);
            return Ok(employee);

        }

        [HttpGet]
        [Route("GetHigestSalEmpfromCity/{City}")]
        public IActionResult GetHighestSalEmp(string city)
        {
             
            return Ok(_empData.GetHighestSalEmp(city));

        }

        [HttpPost]
        [Route("AddEmp")]
        public void AddEmp(Employee employee)
        {
            _empData.AddEmployee(employee);
        }


        [HttpPost]
        [Route("{EmpName}")]
        public IActionResult GetEmpId(string Empname)
        {
            var employee = _empData.GetEmpId(Empname);
            return Ok(employee);

        }


    }
}
