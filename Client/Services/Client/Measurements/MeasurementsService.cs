
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.Measurements;

public class MeasurementsService : IMeasurementsService
{
    public Task<PagedResult<Gaby.Shared.Model.Measurements>> GetMeasurements(int? name, string page)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMeasurements(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddMeasurements(Gaby.Shared.Model.Measurements measurements)
    {
        throw new NotImplementedException();
    }
}