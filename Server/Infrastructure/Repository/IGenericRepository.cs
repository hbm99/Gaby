using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Gaby.Server.Infrastructure.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);
        PagedResult<T> GetAll([FromQuery] string? name, int page);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<T> Add(T entity);
        Task<IEnumerable<T>> AddRange(IEnumerable<T> entities);
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
        Task<T?> Update(T entity);
    }
}
