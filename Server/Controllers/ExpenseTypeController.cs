using Gaby.Server.Infrastructure.Repository.Administration;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTypeController : ControllerBase
    {
        IExpensesTypesRepository repository;
        public ExpenseTypeController(IExpensesTypesRepository expensesTypesRepository)
        {
            repository = expensesTypesRepository;
        }
        [HttpPost]
        public async Task<ActionResult> AddExpenseType(ExpenseType expenseType)
        {
            return Ok(await repository.Add(expenseType));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetExpenseType(string id)
        {
            return Ok(await repository.GetByName(id));
        }
        [HttpGet("all")]
        public ActionResult GetExpensesTypes()
        {
            return Ok(repository.GetAll());
        }
    }
}
