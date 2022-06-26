using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Infrastructure.Repository.Employee;

public interface IGenericEmployeeTypeRepository<T> where T : class
{
    ICollection<T> GetAll([FromQuery] string? name);
    
    Task<T> Add(T entity);
    
    Task<T?> Update(T entity);
}