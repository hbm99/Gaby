using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public interface ICleanerEmployeeService : IEmployeeService
{
    Task AddEmployee(CleanerEmployee cleanerEmployee);

    Task UpdateEmployee(CleanerEmployee cleanerEmployee);
    
    Task DeleteEmployee(CleanerEmployee cleanerEmployee);
}