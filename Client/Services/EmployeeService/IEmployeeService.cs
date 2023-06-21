using AspDotNetCoreBlazorFullStackCrud.Shared.Models;

namespace AspDotNetCoreBlazorFullStackCrud.Client.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> Employees { get; set; }
        List<Skill> Skill { get; set; }
        Task GetSkills();
        Task GetEmployees();
        Task<Employee> GetSingleEmployee(int id);
    }
}
