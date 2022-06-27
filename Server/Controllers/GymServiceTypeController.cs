using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GymServiceTypeController : ControllerBase//: GenericController<ServiceType, IGenericRepository<ServiceType>>
{
    protected IGenericRepository<ServiceType> repository;
    
    public GymServiceTypeController(IGenericRepository<ServiceType> serviceTypeRepository)
    {
        repository = serviceTypeRepository;
    }
    
    
    [HttpGet]
    public  ActionResult GetQuery()
    {
        return Ok(repository.GetAll());
    }
}