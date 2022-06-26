using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers.Employee;

[ApiController]
[Route("api/[controller]")]
public class CoachController : GenericEmployeeTypeController<Coach, IGenericEmployeeTypeRepository<Coach>>
{
    public CoachController(IGenericEmployeeTypeRepository<Coach> genericRepository) : base(genericRepository)
    {
    }

    [HttpGet]
    public ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }
    
    [HttpPost]
    public async Task<ActionResult> Add(Coach coach)
    {
        return await base.Add(coach);
    }
    
    [HttpPut]
    public async Task<ActionResult> Update(Coach coach)
    {
        return await base.Update(coach);
    }
}