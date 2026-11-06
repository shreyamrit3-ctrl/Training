using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "sandeep",
                Department = "IT",
                Designation = "Developer",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "sheily",
                Department = "HR",
                Designation = "Manager",
                Salary = 65000
            },
            new Employee
            {
                Id = 3,
                Name = "Amit",
                Department = "Finance",
                Designation = "Accountant",
                Salary = 45000
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }
    }
}