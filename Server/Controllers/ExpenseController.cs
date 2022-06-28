using Gaby.Server.Infrastructure.Repository.Administration;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers.Administration
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController:ControllerBase
    {
        IExpensesRepository repository;
        public ExpenseController(IExpensesRepository expensesRepository)
        {
            repository = expensesRepository;
        }
        [HttpPost]
        public async Task<ActionResult> AddExpense(Expense expense)
        {
            return Ok(await repository.Add(expense));
        }
        [HttpGet]
        public ActionResult GetExpenses([FromQuery] string? name, int page)
        {
            return Ok(repository.GetAll(name, page));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetExpense(int id)
        {
            return Ok(await repository.GetById(id));
        }
        [HttpPut]
        public async Task<ActionResult> UpdateExpense(Expense expense)
        {
            return Ok(await repository.Update(expense)); ;
        }
    }
}
