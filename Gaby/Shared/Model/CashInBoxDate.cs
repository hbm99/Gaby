using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaby.Shared.Model
{
	public class CashInBoxDate
	{
		public CashInBoxDate()
		{

		}

		[Key]
		/// <summary>
		/// Returns insertion/extraction moment.
		/// </summary>
		public DateTime Datetime { get; set; }

		[ForeignKey("CashInBoxId")]
        public virtual CashInBox? CashInBox { get; set; }
	}
}

