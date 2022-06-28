using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LessonController : ControllerBase
    {
        private readonly ILessonRepository repository;
        public LessonController(ILessonRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpPost]
        public async Task<ActionResult> AddEntity(Lesson entity)
        {
            return Ok(repository.Add(entity));
        }

        [HttpGet]
        public ActionResult GetQuery([FromQuery] int page)
        {
            return Ok(repository.GetAll(page));
        }

        [HttpGet("{key}")]
        public async Task<ActionResult> GetEntity([FromQuery] int id, string coachId)
        {
            return Ok(repository.GetById(id, coachId));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEntity(Lesson lesson)
        {
            return Ok(repository.Update(lesson));
        }
       
    }
}
