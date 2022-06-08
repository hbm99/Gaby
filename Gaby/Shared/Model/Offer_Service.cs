using System;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class Offer_Service : IService, IOffer
	{
		public Offer_Service()
		{

		}

        public int ServiceId { get; set; }

        public int OfferId { get; set; }

		/// <summary>
        /// Returns amount of services.
        /// </summary>
        public int Amount { get; set; }
    }
}

