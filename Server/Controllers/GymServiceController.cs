using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GymServiceController : GenericController<Service, IGenericRepository<Service>>
{
    public GymServiceController (IGenericRepository<Service> genericRepository) : base(genericRepository)
    {
    }

    [HttpPost]
    public override Task<ActionResult> AddEntity(Service entity)
    {
        return base.AddEntity(entity);
    }

    [HttpGet]
    public override ActionResult GetQuery([FromQuery] string? name, int page)
    {
        return base.GetQuery(name, page);
    }

    [HttpGet("{id}")]
    public override async Task<ActionResult> GetEntity(int id)
    {
        return await base.GetEntity(id);
    }

    [HttpPut]
    public override async Task<ActionResult> UpdateEntity(Service service)
    {
        return await base.UpdateEntity(service);
    }

}