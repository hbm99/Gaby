using System;
using System.ComponentModel.DataAnnotations;

namespace Gaby.Shared.Model
{
	public class CashInBox
	{
		public CashInBox()
		{

		}

		[Key]
		/// <summary>
        /// Returns money insertion/extraction Id (key).
        /// </summary>
        public int CashInBoxId { get; set; }

		/// <summary>
		/// Returns money insertion/extraction amount.
		/// </summary>
		public decimal Amount { get; set; }

    }
}

