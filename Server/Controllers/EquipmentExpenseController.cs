using Gaby.Server.Infrastructure.Repository.Administration;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentExpenseController : ControllerBase
    {
        IEquipmentExpensesRepository repository;
        public EquipmentExpenseController(IEquipmentExpensesRepository equipmentExpenseRepository)
        {
            repository = equipmentExpenseRepository;
        }
        [HttpPost]
        public async Task<ActionResult> AddEquipmentExpense(EquipmentExpense equipmentExpense)
        {
            return Ok(await repository.Add(equipmentExpense));
        }
    }
}
