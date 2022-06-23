using System.Linq.Expressions;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Infrastructure.Repository;

public interface IMeasurementsRepository
{
    Task<Measurements> GetById(int id);
    PagedResult<Measurements> GetAll([FromQuery] string? name, int page);
    IEnumerable<Measurements> Find(Expression<Func<Measurements, bool>> expression);
    Task<Measurements> Add(Measurements entity);
    Task<IEnumerable<Measurements>> AddRange(IEnumerable<Measurements> entities);
    Task Remove(Measurements entity);
    Task RemoveRange(IEnumerable<Measurements> entities);
    Task<Measurements?> Update(Measurements entity);
}