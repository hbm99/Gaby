using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CleanerEmployeeController : GenericEmployeeTypeController<CleanerEmployee, IGenericEmployeeTypeRepository<CleanerEmployee>>
{
    public CleanerEmployeeController(IGenericEmployeeTypeRepository<CleanerEmployee> genericRepository) : base(genericRepository)
    {
    }
    
    [HttpGet]
    public override ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }
    
    [HttpPost]
    public override Task<ActionResult> Add(CleanerEmployee cleanerEmployee)
    {
        return base.Add(cleanerEmployee);
    }
    
    [HttpPut]
    public override async Task<ActionResult> Update(CleanerEmployee cleanerEmployee)
    {
        return await base.Update(cleanerEmployee);
    }
}