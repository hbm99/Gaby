using Gaby.Shared.Model;

namespace Gaby.Server.Infrastructure.Repository.Administration
{
    public class EquipmentExpensesRepository:IEquipmentExpensesRepository
    {
        protected readonly GabyDbContext context;
        public EquipmentExpensesRepository(GabyDbContext gabyDbContext)
        {
            context = gabyDbContext;
        }
        public async Task<EquipmentExpense> Add(EquipmentExpense equipmentExpense)
        {
            var expenseType = context.ExpenseTypes
            .FirstOrDefault(c => c.ExpenseTypeName == equipmentExpense.ExpenseType.ExpenseTypeName);
            equipmentExpense.ExpenseType = expenseType;

            var equipment = context.Equipments
                .FirstOrDefault(c => c.EquipmentId == equipmentExpense.Equipment.EquipmentId);
            equipmentExpense.Equipment = equipment;

            var result = await context.EquipmentExpenses.AddAsync(equipmentExpense);

            await context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
