using Microsoft.AspNetCore.Mvc;
using Question7.Services;

namespace Question7.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeService;

        public EmployeeController(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            var info = _employeeService.GetEmployeeInfo();
            return Ok(info);
        }
    }
}