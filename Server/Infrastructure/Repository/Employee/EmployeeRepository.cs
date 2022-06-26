
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Infrastructure.Repository.Employee;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly GabyDbContext context;
    
    public EmployeeRepository(GabyDbContext context)
    {
        this.context = context;
    }
    public ICollection<Shared.Model.Employee> GetAll(string? name) =>
        name != null
            ? context.Set<Shared.Model.Employee>()
                .Where(p => p.Name.Contains(name) && p.Active)
                .ToList()
            : context.Set<Shared.Model.Employee>()
                .Where(p => p.Active)
                .ToList();

    public async Task<Shared.Model.Employee?> GetById(string id) => await context.Set<Shared.Model.Employee>().FindAsync(id);
    
}