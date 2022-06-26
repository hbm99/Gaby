using Gaby.Server.Infrastructure.Repository.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers.Employee;

public abstract class GenericEmployeeTypeController<T, TRepo> : ControllerBase where T : class where TRepo : IGenericEmployeeTypeRepository<T>
{
    protected IGenericEmployeeTypeRepository<T> repository;

    public GenericEmployeeTypeController(IGenericEmployeeTypeRepository<T> genericEmployeeRepository)
    {
        repository = genericEmployeeRepository;
    }
    
    public ActionResult GetQuery([FromQuery] string? name)
    {
        return Ok(repository.GetAll(name));
    }
    
    public async Task<ActionResult> Add(T entity)
    {
        return Ok(await repository.Add(entity));
    }
    
    public async Task<ActionResult> Update(T entity)
    {
        return Ok(await repository.Update(entity));
    }
}