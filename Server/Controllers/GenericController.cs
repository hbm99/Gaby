using Gaby.Server.Infrastructure.Repository;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers
{
    public abstract class GenericController<T, TRepo> : ControllerBase where T : class where TRepo : IGenericRepository<T>  
    {
        private IGenericRepository<T> repository;
        public GenericController(IGenericRepository<T> genericRepository)
        {
            repository = genericRepository;
        }

        public virtual async Task<ActionResult> AddEntity(T entity)
        {
            return Ok(await repository.Add(entity));
        }

        //public virtual ActionResult GetEntitys(string? name, int page) 
        //{
        //    return Ok(repository.GetAll( name,page));
        //}
        public virtual ActionResult GetQuery([FromQuery] string? name, int page)
        {
            return Ok(repository.GetAll(name, page));
        }

        public virtual async Task<ActionResult> UpdateEntity(T entity)
        {
            return Ok(await repository.Update(entity));
        }

        public virtual async Task<ActionResult> GetEntity(int Id)
        {
            return Ok(await repository.GetById(Id));
        }
    }
}
