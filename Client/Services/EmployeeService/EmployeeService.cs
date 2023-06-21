//using AspDotNetCoreBlazorFullStackCrud.Shared.Models;
using AspDotNetCoreBlazorFullStackCrud.Shared.Models;
using System.Net.Http.Json;

namespace AspDotNetCoreBlazorFullStackCrud.Client.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        public readonly HttpClient _http;
        public EmployeeService(HttpClient http)
        {
            _http = http;
        }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Skill> Skill { get ; set ; } = new List<Skill>();
        //public HttpClient Http { get; }

        public async Task GetEmployees()
        {
            var result = await _http.GetFromJsonAsync<List<Employee>>("api/employees");
            if (result != null)
                Employees = result;
        }

        public Task<Employee> GetSingleEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetSkills()
        {
            throw new NotImplementedException();
        }
    }
}
