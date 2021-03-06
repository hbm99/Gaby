using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.GymService;

public interface IGymServiceService
{
    Task<ICollection<Service>> GetServices();
    
    Task<Service> GetService(int id);

    Task DeleteService(int id);

    Task AddService(Service service);

    Task UpdateService(Service service);
    
    Task<ICollection<ServiceType>> GetServiceTypes();
}