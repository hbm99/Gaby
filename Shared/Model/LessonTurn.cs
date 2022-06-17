using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class LessonTurn : IEmployee, IService
	{
		public LessonTurn()
		{

		}

		[ForeignKey("ServiceId")]
		public int ServiceId { get; set; }

		public virtual Service Service { get; set; }


		[ForeignKey("EmployeeId")]
		public string EmployeeId { get; set; }

		public virtual Coach Coach { get; set; }

		/// <summary>
        /// Returns lesson turn schedule.
        /// </summary>
		public DateTime Schedule { get; set; }

		/// <summary>
        /// Returns lesson turn price.
        /// </summary>
		public decimal Price { get; set; }

	}
}

