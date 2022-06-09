using System;
using System.ComponentModel.DataAnnotations;

namespace Gaby.Shared.Model
{
	public class ExpenseType

	{
        [Key]
        /// <summary>
        /// Returns the name of the expense type.
        /// </summary>
        public string ExpenseTypeName { get; set; }
    }
}

