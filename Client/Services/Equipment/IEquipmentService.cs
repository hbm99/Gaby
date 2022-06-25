using Gaby.Shared.Pager;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Equipment
{
    public interface IEquipmentService
    {
        Task<PagedResult<Gaby.Shared.Model.Equipment>> GetEquipments(string? name, string page);
        Task<Gaby.Shared.Model.Equipment> GetEquipment(int id);
        Task AddEquipment(Gaby.Shared.Model.Equipment equipment);
        Task AddEquipmentRange(IEnumerable<Gaby.Shared.Model.Equipment> equipment);
        Task DeleteEquipment(Gaby.Shared.Model.Equipment equipment);
        Task UpdateEquipment(Gaby.Shared.Model.Equipment equipment);
    }
}
