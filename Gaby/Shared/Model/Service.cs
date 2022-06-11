using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class Service : IService
	{
		public Service()
		{

		}

		[Key]
        public int ServiceId { get; set; }

		[Required]
		/// <summary>
        /// Returns type of service.
        /// </summary>
        public virtual ServiceType ServiceType { get; set; }

    }
}

