using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public interface ICoachService : IEmployeeService
{
    Task<ICollection<Coach>> Get(string? name);
    Task AddEmployee(Coach coach);

    Task UpdateEmployee(Coach coach);
    
    Task DeleteEmployee(Coach coach);
}