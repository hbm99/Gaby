using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class Lesson : IService, IEmployee
	{
		public Lesson()
		{
			
		}

		[ForeignKey("ServiceId")]
		public int ServiceId { get; set; }

		public virtual Service Service { get; set; }

		[ForeignKey("EmployeeId")]
		public string EmployeeId { get; set; }

		public virtual Coach Coach { get; set; }

		public decimal Price { get; set; }

        public int Capacity { get; set; }

		public decimal MinutesDuration { get; set; }

        
    }
}

