using System.Collections.Generic;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Question5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // Default data
        private static List<Employee1> employees = new List<Employee1>
        {
            new Employee1 { Id = 1, Name = "Mahi" },
            new Employee1 { Id = 2, Name = "Rahul" }
        };

        // GET: api/employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // POST: api/employee
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee1 emp)
        {
            if (emp == null || string.IsNullOrEmpty(emp.Name))
            {
                return BadRequest("Invalid data");
            }

            employees.Add(emp);

            return Ok(new
            {
                message = "Employee added successfully",
                data = emp
            });
        }
    }
}