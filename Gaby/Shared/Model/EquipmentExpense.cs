using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaby.Shared.Model
{
    [Table("EquipmentExpenses")]
    public class EquipmentExpense: Expense
	{
        
        public EquipmentExpense()
        {
			ExpenseType.ExpenseTypeName = "Equipment";
        }

        [ForeignKey("EquipmentId")]
        [InverseProperty("Expenses")]
        public Equipment Equipment { get; set; }
    }
}

