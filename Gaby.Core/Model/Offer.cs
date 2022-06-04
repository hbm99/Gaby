using Gaby.Core.Interfaces;
namespace Gaby.Core.Model
{
    /// <summary>
    /// Services offer.
    /// </summary>
    public class Offer : IOffer
    {
        
        public int IdO { get; set; }

        /// <summary>
        /// Returns offer price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Returns offer availability.
        /// </summary>
        public bool Availability { get; set; }
    }
}

