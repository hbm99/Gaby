using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers.Employee;

[ApiController]
[Route("api/[controller]")]
public class MaintenanceEmployeeController : GenericEmployeeTypeController<MaintenanceEmployee, IGenericEmployeeTypeRepository<MaintenanceEmployee>>
{
    public MaintenanceEmployeeController(IGenericEmployeeTypeRepository<MaintenanceEmployee> genericRepository) : base(genericRepository)
    {
    }
    
    [HttpGet]
    public ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }
    
    [HttpPost]
    public async Task<ActionResult> Add(MaintenanceEmployee maintenanceEmployee)
    {
        return await base.Add(maintenanceEmployee);
    }
    
    [HttpPut]
    public async Task<ActionResult> Update(MaintenanceEmployee maintenanceEmployee)
    {
        return await base.Update(maintenanceEmployee);
    }
}