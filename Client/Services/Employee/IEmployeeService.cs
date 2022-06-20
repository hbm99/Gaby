
namespace Gaby.Client.Services.Employee;

public interface IEmployeeService
{
    Task<IList<Gaby.Shared.Model.Employee>> GetEmployees(string? name);
    
    Task<Gaby.Shared.Model.Employee> GetEmployee(string id);

    Task DeleteEmployee(string id);
    
}