using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public class MaintenanceEmployeeService : EmployeeService
{
    public MaintenanceEmployeeService(IHttpService httpService) : base(httpService)
    {
    }
    
    public override async Task<IList<Gaby.Shared.Model.Employee>> GetEmployees(string? name)
    {
        return await _httpService.Get<IList<Gaby.Shared.Model.Employee>>("api/maintenanceemployee" + "?name=" + name);
    }

    public async Task AddEmployee(MaintenanceEmployee maintenanceEmployee)
    {
        await _httpService.Post($"api/maintenanceemployee", maintenanceEmployee);
    }

    public async Task UpdateEmployee(MaintenanceEmployee maintenanceEmployee)
    {
        await _httpService.Put($"api/maintenanceemployee", maintenanceEmployee);
    }
}