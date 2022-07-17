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
        public ActionResult GetQuery([FromQuery] int page) //hay que arreglar este método para que reciba name, así no pincha el buscador
        {
            return Ok(repository.GetAll(page));
        }

        [HttpGet("{id}/{coachId}")]
        public async Task<ActionResult> GetEntity(int id, string coachId)
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
