using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers.Employee;

[ApiController]
[Route("api/[controller]")]
public class CleanerEmployeeController : GenericEmployeeTypeController<CleanerEmployee, IGenericEmployeeTypeRepository<CleanerEmployee>>
{
    public CleanerEmployeeController(IGenericEmployeeTypeRepository<CleanerEmployee> genericRepository) : base(genericRepository)
    {
    }
    
    [HttpGet]
    public ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }
    
    [HttpPost]
    public async Task<ActionResult> Add(CleanerEmployee cleanerEmployee)
    {
        return await base.Add(cleanerEmployee);
    }
    
    [HttpPut]
    public async Task<ActionResult> Update(CleanerEmployee cleanerEmployee)
    {
        return await base.Update(cleanerEmployee);
    }
}