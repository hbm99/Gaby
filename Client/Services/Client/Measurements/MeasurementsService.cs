
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
    public async Task<ICollection<Gaby.Shared.Model.Measurements>> GetMeasurements(int clientId)
    {
        return await _httpService.Get<ICollection<Gaby.Shared.Model.Measurements>>("api/measurements" + "?clientId=" +
            clientId);
    }

    public Task DeleteMeasurements(int id)
    {
        throw new NotImplementedException();
    }

    public async Task AddMeasurements(Gaby.Shared.Model.Measurements measurements)
    {
        await _httpService.Post($"api/measurements", measurements);
    }
}