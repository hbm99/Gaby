using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class LessonTurn_Client : IClient, IEmployee, IService
	{

		[ForeignKey("ClientId")]
        public int ClientId { get; set; }

		public virtual BasicClient Client { get; set; }


		[ForeignKey("EmployeeId")]
		public string EmployeeId { get; set; }

		public virtual Coach Coach { get; set; }


		[ForeignKey("ServiceId")]
		public int ServiceId { get; set; }

		public virtual Service Service { get; set; }

		//ver qué hace EF con esto, lo que queremos es un foreign key a Lesson Turn
		public virtual LessonTurn LessonTurn { get; set; }

		/// <summary>
		/// Returns lesson turn schedule.
		/// </summary>
		public DateTime Schedule { get; set; }

		/// <summary>
        /// Returns if the client paid the lesson turn.
        /// </summary>
        public bool Paid { get; set; }

		/// <summary>
        /// Returns if the client assisted to the lesson turn.
        /// </summary>
		public bool Assisted { get; set; }
    }
}

