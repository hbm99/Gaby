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
		public string ExpenseTypeName { get; set; }
	}
}

