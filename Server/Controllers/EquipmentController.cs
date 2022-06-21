using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentController:GenericController<Equipment, IGenericRepository<Equipment>>
    {
        public EquipmentController(IGenericRepository<Equipment> genericRepository) : base(genericRepository)
        {
        }
        [HttpPost]
        public override Task<ActionResult> AddEntity(Equipment entity)
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
        public override async Task<ActionResult> UpdateEntity(Equipment equipment)
        {
            return await base.UpdateEntity(equipment);
        }
    }
   
}
