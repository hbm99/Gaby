using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoachController : GenericEmployeeTypeController<Coach, IGenericEmployeeTypeRepository<Coach>>
{
    public CoachController(IGenericEmployeeTypeRepository<Coach> genericRepository) : base(genericRepository)
    {
    }

    [HttpGet]
    public override ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }
    
    [HttpPost]
    public override Task<ActionResult> Add(Coach coach)
    {
        return base.Add(coach);
    }
    
    [HttpPut]
    public override async Task<ActionResult> Update(Coach coach)
    {
        return await base.Update(coach);
    }
}