using System.Linq.Expressions;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Server.Infrastructure.Repository;

public class MeasurementsRepository : IMeasurementsRepository
{
    protected readonly GabyDbContext context;
    
    public MeasurementsRepository(GabyDbContext context)
    {
        this.context = context;
    }
    public Task<Measurements> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public PagedResult<Measurements> GetAll(string? name, int page)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Measurements> Find(Expression<Func<Measurements, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public async Task<Measurements> Add(Measurements entity)
    {
        var result = await context.Set<Measurements>().AddAsync(entity);
        await context.SaveChangesAsync();
        return result.Entity;
    }

    public Task<IEnumerable<Measurements>> AddRange(IEnumerable<Measurements> entities)
    {
        throw new NotImplementedException();
    }

    public Task Remove(Measurements entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<Measurements> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Measurements?> Update(Measurements entity)
    {
        throw new NotImplementedException();
    }
}