using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public interface ICleanerEmployeeService : IEmployeeService
{
    Task<ICollection<CleanerEmployee>> Get(string? name);
    Task AddEmployee(CleanerEmployee cleanerEmployee);

    Task UpdateEmployee(CleanerEmployee cleanerEmployee);
    
    Task DeleteEmployee(CleanerEmployee cleanerEmployee);
}