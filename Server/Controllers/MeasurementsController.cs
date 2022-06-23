using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MeasurementsController : ControllerBase // : GenericController<Measurements, IGenericRepository<Measurements>>
{
    IMeasurementsRepository repository;
    public MeasurementsController(IMeasurementsRepository measurementsRepository)
    {
        measurementsRepository = repository;
    }

    [HttpPost]
    public async Task<ActionResult> AddEntity(Measurements entity)
    {
        return Ok(await repository.Add(entity)); //return base.AddEntity(entity);
    }
}