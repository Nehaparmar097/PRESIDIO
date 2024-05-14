using Microsoft.AspNetCore.Mvc;
using RequestTrackerAPI.interfaces;
using RequestTrackerAPI.models;
using RequestTrackerAPI.repository;

namespace RequestTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IList<Employee>> Get()
        {
            var employees = await _employeeService.GetEmployees();
            return employees.ToList();
        }
        [HttpPut]
        public async Task<ActionResult<Employee>> Put(int id, string phone)
        {
            try
            {
                var employee = await _employeeService.UpdateEmployeePhone(id, phone);
                return Ok(employee);
            }
            catch (NoSuchEmployeeException nsee)
            {
                return NotFound(nsee.Message);
            }
        }
    }
}
