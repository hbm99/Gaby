using System.Linq.Expressions;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Infrastructure.Repository.Administration
{
    public interface IExpensesRepository
    {
        Task<Expense> Add(Expense expense);
        PagedResult<Expense> GetAll([FromQuery] string? name, int page);
        Task<Expense> GetById(int id);
        Task<Expense?> Update(Expense expense);
    }
}