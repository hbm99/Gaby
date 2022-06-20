using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public interface ICoachService : IEmployeeService
{
    Task AddEmployee(Coach coach);

    Task UpdateEmployee(Coach coach);
}