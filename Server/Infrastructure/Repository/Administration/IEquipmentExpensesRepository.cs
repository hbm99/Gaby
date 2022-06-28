using Gaby.Shared.Model;

namespace Gaby.Server.Infrastructure.Repository.Administration
{
    public interface IEquipmentExpensesRepository
    {
        Task<EquipmentExpense> Add(EquipmentExpense equipmentExpense);
    }
}
