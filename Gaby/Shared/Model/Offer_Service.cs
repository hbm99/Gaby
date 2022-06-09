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

        [Key]
        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }

        //tener dos Key declarados así no pincha según la doc de Msft,
        //hay q manejarlo en el DbContext con el modelBuilder y demás,
        //ver lo que hizo Elena
        [Key]
        [ForeignKey("OfferId")]
        public int OfferId { get; set; }

        
        public virtual Service Service { get; set; }

        public virtual Offer Offer { get; set; }

        /// <summary>
        /// Returns amount of services.
        /// </summary>
        public int Amount { get; set; }
    }
}

