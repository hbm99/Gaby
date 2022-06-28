using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gaby.Server.Infrastructure.Repository.Administration
{

    public class ExpensesRepository : IExpensesRepository
    {
        protected readonly GabyDbContext context;
        public ExpensesRepository(GabyDbContext gabyDbContext)
        {
            context = gabyDbContext;
        }
        public async Task<Expense> Add(Expense expense)
        {
            var expenseType = context.ExpenseTypes
            .FirstOrDefault(c => c.ExpenseTypeName == expense.ExpenseType.ExpenseTypeName);
            expense.ExpenseType = expenseType;

            var result = await context.Expenses.AddAsync(expense);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public PagedResult<Expense> GetAll([FromQuery] string? name, int page)
        {
            int pageSize = 10;
            return context.Expenses
                .Include(p=>p.ExpenseType)
                .GetPaged(page, pageSize);
        }

        public async Task<Expense> GetById(int id)
        {
            var result = await context.Expenses.FindAsync(id);
            return result;
        }

        public async Task<Expense?> Update(Expense expense)
        {
            var result = context.Expenses.First(p => p == expense);
            if (result != null)
            {

                // Update existing entity
                context.Entry(result).CurrentValues.SetValues(expense);

                await context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Person not found");
            }
            return expense;
        }
    }
}
