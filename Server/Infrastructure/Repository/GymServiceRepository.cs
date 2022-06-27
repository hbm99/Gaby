using System.Linq.Expressions;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.EntityFrameworkCore;

namespace Gaby.Server.Infrastructure.Repository;

public class GymServiceRepository: IGenericRepository<Service>
{
    protected readonly GabyDbContext context;
    
    public GymServiceRepository(GabyDbContext context)
    {
        this.context = context;
    }
    
    public Task<Service> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public PagedResult<Service> GetAll(string? name, int page)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all the services 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Service> GetAll()
    {
        return context.Set<Service>().Include(x => x.ServiceType).ToList();
    }
    
    
    public async Task<Service> Add(Service entity)
    {
        var servicetype = context.ServiceTypes
            .FirstOrDefault(c => c.ServiceTypeName == entity.ServiceType.ServiceTypeName);

        entity.ServiceType = servicetype;
        
        //entity.ServiceType.Services.Add(entity);
        
        var result = await context.Set<Service>().AddAsync(entity);
        
        await context.SaveChangesAsync();
        return result.Entity;
    }

    public IEnumerable<Service> Find(Expression<Func<Service, bool>> expression)
    {
        throw new NotImplementedException();
    }

    
    public Task<IEnumerable<Service>> AddRange(IEnumerable<Service> entities)
    {
        throw new NotImplementedException();
    }

   
    
    public Task Remove(Service entity)
    {
        throw new NotImplementedException();
    }

    
    
    public Task RemoveRange(IEnumerable<Service> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Service?> Update(Service entity)
    {
        throw new NotImplementedException();
    }
}