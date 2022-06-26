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
        repository = measurementsRepository;
    }

    [HttpPost]
    public async Task<ActionResult> AddEntity(Measurements entity)
    {
        return Ok(await repository.Add(entity));
    }

    [HttpGet]
    public ActionResult GetQuery([FromQuery] int? clientId)
    {
        return Ok(repository.GetAll(clientId));
    }
}