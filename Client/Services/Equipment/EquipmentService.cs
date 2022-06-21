using Gaby.Shared.Pager;
using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Equipment
{
    public class EquipmentService : IEquipmentService
    {
        private IHttpService _httpService;

        public EquipmentService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<PagedResult<Gaby.Shared.Model.Equipment>> GetEquipments(string? name, string page)
        {
            return await _httpService.Get<PagedResult<Gaby.Shared.Model.Equipment>>("api/equipment" + "?page=" + page + "&name=" + name); ;
        }
        public async Task<Gaby.Shared.Model.Equipment> GetEquipment(int id)
        {
            return await _httpService.Get<Gaby.Shared.Model.Equipment>($"api/equipment/{id}");
        }
        public async Task AddEquipment(Gaby.Shared.Model.Equipment equipment)
        {
            await _httpService.Post($"api/equipment", equipment);
        }

        public async Task AddEquipmentRange(IEnumerable<Gaby.Shared.Model.Equipment> equipment)
        {
            await _httpService.Post($"api/equipment", equipment);
        }
        public async Task DeleteEquipment(int id)
        {
            await _httpService.Delete($"api/equipment/{id}");
        }
        public async Task UpdateEquipment(Gaby.Shared.Model.Equipment equipment)
        {
            await _httpService.Put($"api/equipment", equipment);
        }
    }
}
