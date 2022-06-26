using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public class MaintenanceEmployeeService : EmployeeService, IMaintenanceEmployeeService
{
    public MaintenanceEmployeeService(IHttpService httpService) : base(httpService)
    {
    }
    
    public override async Task<ICollection<Gaby.Shared.Model.Employee>> GetEmployees(string? name)
    {
        return await _httpService.Get<ICollection<Gaby.Shared.Model.Employee>>("api/maintenanceemployee" + "?name=" + name);
    }

    public async Task AddEmployee(MaintenanceEmployee maintenanceEmployee)
    {
        await _httpService.Post($"api/maintenanceemployee", maintenanceEmployee);
    }

    public async Task UpdateEmployee(MaintenanceEmployee maintenanceEmployee)
    {
        await _httpService.Put($"api/maintenanceemployee", maintenanceEmployee);
    }

    public async Task DeleteEmployee(MaintenanceEmployee maintenanceEmployee)
    {
        await _httpService.Put($"api/maintenanceemployee", maintenanceEmployee);
    }
}