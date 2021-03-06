using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.Measurements;

public interface IMeasurementsService
{
    Task<ICollection<Gaby.Shared.Model.Measurements>> GetMeasurements(int clientId);
    //Task<MemberClient> GetClient(int id);

    //Task DeleteMeasurements(int id);
    Task AddMeasurements(Gaby.Shared.Model.Measurements measurements);
    
    //Task AddClientRange(IEnumerable<Measurements> measurements);
    //Task UpdateClient(Measurements measurements);
}