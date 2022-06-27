using System.Linq.Expressions;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Server.Infrastructure.Repository;

public class GymServiceTypeRepository: IGenericRepository<ServiceType>
{
    protected readonly GabyDbContext context;
    public GymServiceTypeRepository(GabyDbContext context)
    {
        this.context = context;
    }
    public Task<ServiceType> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public PagedResult<ServiceType> GetAll(string? name, int page)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ServiceType> GetAll()
    {
        return context.Set<ServiceType>().ToList();
    }

    public IEnumerable<ServiceType> Find(Expression<Func<ServiceType, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceType> Add(ServiceType entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ServiceType>> AddRange(IEnumerable<ServiceType> entities)
    {
        throw new NotImplementedException();
    }

    public Task Remove(ServiceType entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRange(IEnumerable<ServiceType> entities)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceType?> Update(ServiceType entity)
    {
        throw new NotImplementedException();
    }
}