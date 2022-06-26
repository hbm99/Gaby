using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public interface IMaintenanceEmployeeService : IEmployeeService
{
    Task AddEmployee(MaintenanceEmployee maintenanceEmployee);

    Task UpdateEmployee(MaintenanceEmployee maintenanceEmployee);
    
    Task DeleteEmployee(MaintenanceEmployee maintenanceEmployee);
}