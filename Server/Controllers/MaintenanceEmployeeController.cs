using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MaintenanceEmployeeController : GenericEmployeeTypeController<MaintenanceEmployee, IGenericEmployeeTypeRepository<MaintenanceEmployee>>
{
    public MaintenanceEmployeeController(IGenericEmployeeTypeRepository<MaintenanceEmployee> genericRepository) : base(genericRepository)
    {
    }
    
    [HttpGet]
    public override ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }
    
    [HttpPost]
    public override Task<ActionResult> Add(MaintenanceEmployee maintenanceEmployee)
    {
        return base.Add(maintenanceEmployee);
    }
    
    [HttpPut]
    public override async Task<ActionResult> Update(MaintenanceEmployee maintenanceEmployee)
    {
        return await base.Update(maintenanceEmployee);
    }
}