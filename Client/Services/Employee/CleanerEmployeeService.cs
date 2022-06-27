using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public class CleanerEmployeeService : EmployeeService, ICleanerEmployeeService
{
    public CleanerEmployeeService(IHttpService httpService) : base(httpService)
    {
    }
    
    public async Task<ICollection<CleanerEmployee>> Get(string? name)
    {
        return await _httpService.Get<ICollection<CleanerEmployee>>("api/cleaneremployee" + "?name=" + name);
    }

    public async Task AddEmployee(CleanerEmployee cleanerEmployee)
    {
        await _httpService.Post($"api/cleaneremployee", cleanerEmployee);
    }

    public async Task UpdateEmployee(CleanerEmployee cleanerEmployee)
    {
        await _httpService.Put($"api/cleaneremployee", cleanerEmployee);
    }

    public async Task DeleteEmployee(CleanerEmployee cleanerEmployee)
    {
        await _httpService.Put($"api/cleaneremployee", cleanerEmployee);
    }
}