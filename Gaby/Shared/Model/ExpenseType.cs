using System;
using System.ComponentModel.DataAnnotations;

namespace Gaby.Shared.Model
{
	public class ExpenseType

	{
        /// <summary>
        /// Returns the name of the expense type.
        /// </summary>
        [Key]
        public string ExpenseTypeId { get; set; }

        /// <summary>
        /// Returns the expenses of this type.
        /// </summary>
        public ICollection<Expense> Expenses { get; set; }
    }
}

