using Gaby.Client.Services.SharedServices;

namespace Gaby.Client.Services.Employee;

public class EmployeeService : IEmployeeService
{
    protected IHttpService _httpService;

    public EmployeeService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    
    public async Task<ICollection<Gaby.Shared.Model.Employee>> GetEmployees(string? name)
    {
        return await _httpService.Get<ICollection<Gaby.Shared.Model.Employee>>("api/employee" + "?name=" + name);
    }

    public async Task<Gaby.Shared.Model.Employee> GetEmployee(string id)
    {
        return await _httpService.Get<Gaby.Shared.Model.Employee>($"api/employee/{id}");
    }
}