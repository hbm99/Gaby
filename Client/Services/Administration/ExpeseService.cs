using Gaby.Shared.Pager;
using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Administration
{
    public class ExpenseService : IExpenseService
    {
        private IHttpService _httpService;

        public ExpenseService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<PagedResult<Expense>> GetExpenses(string? name, string page)
        {
            return await _httpService.Get<PagedResult<Expense>>("api/expense" + "?page=" + page + "&name=" + name); ;
        }
        public async Task<Expense> GetExpense(int id)
        {
            return await _httpService.Get<Expense>($"api/expense/{id}");
        }
        public async Task AddExpense(Expense expense)
        {
            await _httpService.Post($"api/expense", expense);
        }

        public async Task AddExpenseRange(IEnumerable<Expense> expense)
        {
            await _httpService.Post($"api/expense", expense);
        }
        public async Task DeleteExpense(Expense expense)
        {
            await _httpService.Put($"api/expense", expense);
        }
        public async Task UpdateExpense(Expense expense)
        {
            await _httpService.Put($"api/expense", expense);
        }
    }
}
