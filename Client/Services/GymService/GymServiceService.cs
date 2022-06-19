using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.GymService;

public class GymServiceService: IGymServiceService
{
    private IHttpService _httpService;
    
    public GymServiceService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<PagedResult<Service>> GetServices(string? name, string page)
    {
        return await _httpService.Get<PagedResult<Service>>("api/gymservice" + "?page=" + page + "&name=" + name);
    }

    public async Task<Service> GetService(int id)
    {
        return await _httpService.Get<Service>($"api/gymservice/{id}");
    }

    public async Task DeleteService(int id)
    {
        await _httpService.Delete($"api/gymservice/{id}");
    }

    public async Task AddService(Service service)
    {
        await _httpService.Post($"api/gymservice", service);
    }

    public async Task UpdateService(Service service)
    {
        await _httpService.Put($"api/gymservice", service);
    }
}