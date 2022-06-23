using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    public class Offer : IOffer, INamed
    {
        [Key]
        public int OfferId { get; set; }

        /// <summary>
        /// Returns offer price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Returns offer availability.
        /// </summary>
        public bool Availability { get; set; }

        /// <summary>
        /// Returns members related to offer.
        /// </summary>
        [InverseProperty("Offer")]
        public virtual ICollection<ClientOffer> ClientOffers { get; set; }
        public string Name { get ; set; }
    }
}
