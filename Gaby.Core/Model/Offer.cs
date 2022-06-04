using Gaby.Core.Interfaces;
namespace Gaby.Core.Model
{
    /// <summary>
    /// Services offer.
    /// </summary>
    public class Offer : IOffer
    {
        public Offer()
        {
            Members = new HashSet<Member>();
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
        public virtual ICollection<Member> Members { get; set; }

        /// <summary>
        /// Returns inscription dates.
        /// </summary>
        public virtual ICollection<InscriptionDate> InscriptionDates { get; set; }

    }

}