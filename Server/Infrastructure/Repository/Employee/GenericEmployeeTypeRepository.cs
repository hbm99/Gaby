using Gaby.Shared.Interfaces;

namespace Gaby.Server.Infrastructure.Repository.Employee;

public class GenericEmployeeTypeRepository<T> : IGenericEmployeeTypeRepository<T> where T : class, INamed, IRemovable
{
    protected readonly GabyDbContext context;
    
    public GenericEmployeeTypeRepository(GabyDbContext context)
    {
        this.context = context;
    }
    public ICollection<T> GetAll(string? name) =>
        name != null
            ? context.Set<T>()
                .Where(p => p.Name.Contains(name) && p.Active)
                .ToList()
            : context.Set<T>()
                .Where(p => p.Active)
                .ToList();

    public async Task<T> Add(T entity)
    {
        var result = await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<T?> Update(T entity)
    {
        var result = context.Set<T>().First(p => p == entity);
        if (result != null)
        {
            // Update existing entity
            context.Entry(result).CurrentValues.SetValues(entity);
            await context.SaveChangesAsync();
        }
        else
        {
            throw new KeyNotFoundException("Employee not found");
        }
        
        return entity;
    }
}