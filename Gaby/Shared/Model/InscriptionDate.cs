using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Model
{
    public class InscriptionDate
    {
        public InscriptionDate()
        {
            Members = new HashSet<MemberClient>();
            Offers = new HashSet<Offer>();
        }

        [Key]
        /// <summary>
        /// Returns inscription moment.
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Returns members registered on that date. 
        /// </summary>
        public virtual ICollection<MemberClient> Members { get; set; }

        /// <summary>
        /// Returns offers registered on that date.
        /// </summary>
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
