using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GymServiceController : ControllerBase
{
    protected IGenericRepository<Service> repository;
    public GymServiceController (IGenericRepository<Service> gymServiceRepository)
    {
        repository = gymServiceRepository;
    }

    [HttpPost]
    public async Task<ActionResult> AddEntity(Service entity)
    {
        return Ok(await repository.Add(entity));
        //return base.AddEntity(entity);
    }

    
    [HttpGet]
    public ActionResult GetAll()
    {
        return Ok(repository.GetAll());
        //return base.GetQuery(name,page);
    }

    
    [HttpGet("{id}")]
    public  async Task<ActionResult> GetEntity(int id)
    {
        return Ok(await repository.GetById(id));
    }
    

    [HttpPut]
    public  async Task<ActionResult> UpdateEntity(Service service)
    {
        return Ok(await repository.Update(service));
    }

}