using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaby.Shared.Model
{
    [Table("EquipmentExpenses")]
    public class EquipmentExpense: Expense
	{
        
        public EquipmentExpense()
        {
			ExpenseTypeId = "Equipo";
        }

        public Equipment Equipment { get; set; }
    }
}

