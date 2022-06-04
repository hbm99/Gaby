using System;
namespace Gaby.Core.Model
{
	/// <summary>
    /// Member inscription.
    /// </summary>
	public class InscriptionDate
	{
        public InscriptionDate()
        {
            Members = new HashSet<Member>();
            Offers = new HashSet<Offer>();       
        }

		/// <summary>
        /// Returns inscription moment.
        /// </summary>
		public DateTime Datetime { get; set; }

        /// <summary>
        /// Returns members registered on that date. 
        /// </summary>
        public virtual ICollection<Member> Members { get; set; }

        /// <summary>
        /// Returns offers registered on that date.
        /// </summary>
        public virtual ICollection<Offer> Offers { get; set; }
    }
}

