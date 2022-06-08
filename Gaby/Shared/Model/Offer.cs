using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    public class Offer : IOffer
    {
        public Offer()
        {
            Members = new HashSet<MemberClient>();
            InscriptionDates = new HashSet<InscriptionDate>();
        }

        public int OfferId { get; set; }

        /// <summary>
        /// Returns offer price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Returns offer availability.
        /// </summary>
        public bool Availability { get; set; }

        /// <summary>
        /// Returns members related to offer.
        /// </summary>
        public virtual ICollection<MemberClient> Members { get; set; }

        /// <summary>
        /// Returns inscription dates.
        /// </summary>
        public virtual ICollection<InscriptionDate> InscriptionDates { get; set; }

    }
}
