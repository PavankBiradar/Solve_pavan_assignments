using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIExample.EmpData;
using System;

namespace RestAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmpData _empData;

        public EmployeesController(IEmpData empData) { 
         
            _empData=empData;
        
        }
        [HttpGet]
        [Route("All")]
        public IActionResult GetEmployees() { 

            return Ok(_empData.GetEmployees());

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _empData.GetEmployee(id);
            return Ok(employee);

        }

        [HttpGet]
        [Route("{City}")]
        public IActionResult GetHighestSalEmployee(string City)
        {
            var employee = _empData.GetHighestSalEmployee(City);
            return Ok(employee);

        }


        /*
        [HttpPost]
        [Route("api/[controller]/{EmpName}")]
        public IActionResult GetEmployeeId(string Empname)
        {
            var employee = _empData.GetEmployeeId(City);
            return Ok(employee);

        }
        */

    }
}
