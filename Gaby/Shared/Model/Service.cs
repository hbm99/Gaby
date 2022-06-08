using System;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class Service : IService
	{
		public Service()
		{

		}

        public int ServiceId { get; set; }

		/// <summary>
        /// Returns type of service.
        /// </summary>
        public string ServiceTypeId { get; set; }

    }
}

