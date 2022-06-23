using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class Service : IService
	{
		[Key]
        public int ServiceId { get; set; }

        /// <summary>
        /// Returns type of service.
        /// </summary>
		[Required]
		public virtual ServiceType ServiceType { get; set; }

    }
}

