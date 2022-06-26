
namespace Gaby.Client.Services.Employee;

public interface IEmployeeService
{
    Task<ICollection<Gaby.Shared.Model.Employee>> GetEmployees(string? name);
    
    Task<Gaby.Shared.Model.Employee> GetEmployee(string id);
}