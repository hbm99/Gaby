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

    public ICollection<Measurements> GetAll(int? id)
    {
        return context.Set<Measurements>()
            .Where(m => m.MemberClient.ClientId.Equals(id)).ToList();
    }

    public IEnumerable<Measurements> Find(Expression<Func<Measurements, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public async Task<Measurements> Add(Measurements entity)
    {
        var client = context.MemberClients
            .FirstOrDefault(c => c.ClientId == entity.MemberClient.ClientId);
        entity.MemberClient = client;
        
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