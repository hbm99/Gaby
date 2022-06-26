
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Infrastructure.Repository.Employee;

public interface IEmployeeRepository
{
    ICollection<Shared.Model.Employee> GetAll([FromQuery] string? name);
    Task<Shared.Model.Employee?> GetById(string id);
}