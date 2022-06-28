using Gaby.Shared.Model;
using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.Administration
{
    public class ExpenseTypeService : IExpenseTypeService
    {
        private IHttpService _httpService;

        public ExpenseTypeService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task AddExpenseType(ExpenseType expenseType)
        {
            await _httpService.Post($"api/expensetype", expenseType);
        }

        public async Task<ExpenseType> GetExpenseType(string id)
        {
            return await _httpService.Get<ExpenseType>($"api/expensetype/{id}");
        }
        public async Task<IEnumerable<ExpenseType>> GetAllExpenses()
        {
            return await _httpService.Get<IEnumerable<ExpenseType>>($"api/expensetype/all");
        }
    }
}
