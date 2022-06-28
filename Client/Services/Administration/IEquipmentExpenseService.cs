using Gaby.Shared.Pager;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Administration
{
    public interface IEquipmentExpenseService
    {
        Task AddEquipmentExpense(EquipmentExpense equipmentExpense);
    }
}
