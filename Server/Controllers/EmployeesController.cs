using AspDotNetCoreBlazorFullStackCrud.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreBlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public static List<Skill> skills = new List<Skill> {
            new Skill {Id =1, Name = "ASP.NET"},
            new Skill {Id = 2, Name ="React JS"}
        };

        public static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Jon Doe",
                FirstName = "Jon",
                LastName = "Doe",
                Email = "jon@email.com",
                Skill = skills [0]
            },
            new Employee
            {
                Id = 2,
                Name = "Mike Hussi",
                FirstName = "Mike",
                LastName = "Hussi",
                Email = "mike@email.com",
                Skill = skills [1]
            }
        };
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployee()
        {
            
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> GetSingleEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e=>e.Id == id);
            if (employee == null)
            {
                return NotFound("Sorry, no employee found. :/");
            }
            return Ok(employee);
        }
    }
}
