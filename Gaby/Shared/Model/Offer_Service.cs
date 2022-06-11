using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
	public class Offer_Service : IService, IOffer
	{
		public Offer_Service()
		{

		}

        
        [Required]
        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }


        [Required]
        [ForeignKey("OfferId")]
        public int OfferId { get; set; }

        public virtual Offer Offer { get; set; }

        /// <summary>
        /// Returns amount of services.
        /// </summary>
        public int Amount { get; set; }
    }
}

