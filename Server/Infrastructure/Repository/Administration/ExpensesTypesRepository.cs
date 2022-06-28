using Gaby.Shared.Model;

namespace Gaby.Server.Infrastructure.Repository.Administration
{
    public class ExpensesTypesRepository : IExpensesTypesRepository
    {
        protected readonly GabyDbContext context;
        public ExpensesTypesRepository(GabyDbContext gabyDbContext)
        {
            context = gabyDbContext;
        }
        public async Task<ExpenseType> Add(ExpenseType expenseType)
        {
            var result = await context.ExpenseTypes.AddAsync(expenseType);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ExpenseType> GetByName(string expenseTypeName)
        {
            var result = await context.ExpenseTypes.FindAsync(expenseTypeName);
            return result;
        }

        public IEnumerable<ExpenseType> GetAll()
        {
            return context.ExpenseTypes.ToList();
        }
    }
}
