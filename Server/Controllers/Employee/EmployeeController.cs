using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers.Employee;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : GenericController<Gaby.Shared.Model.Employee, IGenericRepository<Gaby.Shared.Model.Employee>>
{
    public EmployeeController(IGenericRepository<Gaby.Shared.Model.Employee> genericRepository) : base(genericRepository)
    {
    }

    [HttpPost]
    public override Task<ActionResult> AddEntity(Gaby.Shared.Model.Employee entity)
    {
        return base.AddEntity(entity);
    }

    /*[HttpGet]
    public override ActionResult GetQuery([FromQuery] string? name)
    {
        return base.GetQuery(name);
    }*/

    [HttpGet("{id}")]
    public override async Task<ActionResult> GetEntity(int id) //change to receive string
    {
        return await base.GetEntity(id);
    }

    /*[HttpPut]
    public override async Task<ActionResult> UpdateEntity(Gaby.Shared.Model.Employee employee)
    {
        return await base.UpdateEntity(employee);
    }*/
}