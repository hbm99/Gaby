using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.Administration
{
    public interface IExpenseTypeService
    {
        Task<ExpenseType> GetExpenseType(string expenseTypeName);
        Task AddExpenseType(ExpenseType expenseType);
        Task <IEnumerable<ExpenseType>> GetAllExpenses();   
    }
}
