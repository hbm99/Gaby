using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public class CleanerEmployeeService : EmployeeService, ICleanerEmployeeService
{
    public CleanerEmployeeService(IHttpService httpService) : base(httpService)
    {
    }
    
    public override async Task<ICollection<Gaby.Shared.Model.Employee>> GetEmployees(string? name)
    {
        return await _httpService.Get<IList<Gaby.Shared.Model.Employee>>("api/cleaneremployee" + "?name=" + name);
    }

    public async Task AddEmployee(CleanerEmployee cleanerEmployee)
    {
        await _httpService.Post($"api/cleaneremployee", cleanerEmployee);
    }

    public async Task UpdateEmployee(CleanerEmployee cleanerEmployee)
    {
        await _httpService.Put($"api/cleaneremployee", cleanerEmployee);
    }

    public Task DeleteEmployee(CleanerEmployee cleanerEmployee)
    {
        throw new NotImplementedException();
    }
}