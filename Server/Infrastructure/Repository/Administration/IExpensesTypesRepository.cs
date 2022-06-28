using System.Linq.Expressions;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Infrastructure.Repository.Administration
{
    public interface IExpensesTypesRepository
    {
        Task<ExpenseType> Add(ExpenseType expenseType);
        Task<ExpenseType> GetByName(string expenseTypeName);
        IEnumerable<ExpenseType> GetAll();
    }
}
