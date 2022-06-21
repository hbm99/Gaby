
using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.Measurements;

public class MeasurementsService : IMeasurementsService
{
    private IHttpService _httpService;

    public MeasurementsService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public Task<PagedResult<Gaby.Shared.Model.Measurements>> GetMeasurements(int? name, string page)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMeasurements(int id)
    {
        throw new NotImplementedException();
    }

    public async Task AddMeasurements(Gaby.Shared.Model.Measurements measurements)
    {
        await _httpService.Post("api/measurements", measurements);
    }
}