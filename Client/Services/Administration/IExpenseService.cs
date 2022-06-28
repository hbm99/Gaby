using Gaby.Shared.Pager;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Administration
{
    public interface IExpenseService
    {
        Task<PagedResult<Expense>> GetExpenses(string? name, string page);
        Task<Expense> GetExpense(int id);
        Task AddExpense(Expense expense);
        Task AddExpenseRange(IEnumerable<Expense> expense);
        Task DeleteExpense(Expense expense);
        Task UpdateExpense(Expense expense);
    }
}
