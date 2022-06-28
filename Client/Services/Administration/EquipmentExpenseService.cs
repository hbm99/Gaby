using Gaby.Shared.Model;
using Gaby.Client.Services.SharedServices;

namespace Gaby.Client.Services.Administration
{
    public class EquipmentExpenseService:IEquipmentExpenseService
    {
        private IHttpService _httpService;

        public EquipmentExpenseService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task AddEquipmentExpense(EquipmentExpense equipmentExpense)
        {
            await _httpService.Post($"api/equipmentexpense", equipmentExpense);
        }
    }
}
