using Gaby.Server.Infrastructure.Repository.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

public abstract class GenericEmployeeTypeController<T, TRepo> : ControllerBase where T : class where TRepo : IGenericEmployeeTypeRepository<T>
{
    protected IGenericEmployeeTypeRepository<T> repository;

    public GenericEmployeeTypeController(IGenericEmployeeTypeRepository<T> genericEmployeeRepository)
    {
        repository = genericEmployeeRepository;
    }
    
    public virtual ActionResult GetQuery([FromQuery] string? name)
    {
        return Ok(repository.GetAll(name));
    }
    
    public virtual async Task<ActionResult> Add(T entity)
    {
        return Ok(await repository.Add(entity));
    }
    
    public virtual async Task<ActionResult> Update(T entity)
    {
        return Ok(await repository.Update(entity));
    }
}