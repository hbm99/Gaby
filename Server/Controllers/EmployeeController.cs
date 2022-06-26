using Gaby.Server.Infrastructure.Repository.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    IEmployeeRepository repository;
    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        repository = employeeRepository;
    }

    [HttpGet]
    public ActionResult GetQuery([FromQuery] string? name)
    {
        return Ok(repository.GetAll(name));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetEntity(string id)
    {
        return Ok(await repository.GetById(id));
    }
    
}