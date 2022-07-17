using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace Gaby.Server.Infrastructure.Repository
{
    public interface ILessonRepository
    {
        IList<Lesson> GetById(int EmployeId, string coachId);
        PagedResult<Lesson> GetAll([FromQuery] int page);
        IEnumerable<Lesson> Find(string? expression);
        Task<Lesson> Add(Lesson entity);
        Task<IEnumerable<Lesson>> AddRange(IEnumerable<Lesson> entities);
        Task Remove(Lesson entity);
        Task RemoveRange(IEnumerable<Lesson> entities);
        Task<Lesson?> Update(Lesson entity);
    }
}
