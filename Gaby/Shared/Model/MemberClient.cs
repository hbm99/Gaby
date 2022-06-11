using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaby.Shared.Utils;

namespace Gaby.Shared.Model
{
    [Table("Members")]
    public class MemberClient : BasicClient
    {
        public MemberClient()
        {
            Offers = new HashSet<Offer>();
            InscriptionDates = new HashSet<InscriptionDate>();
        }

      
        public TimeOnly? CheckInTime { get; set; }
        public TimeOnly? CheckOutTime { get; set; }

        /// <summary>
        /// Returns if the client is an active member (has time available until next payment).
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Returns address.
        /// </summary>
        public HomeAddress? Address { get; set; }

        /// <summary>
        /// Returns a phone number.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Returns ailments data.
        /// </summary>
        public string? Ailments { get; set; }

        /// <summary>
        /// Returns offers registered of the member.
        /// </summary>
        public virtual ICollection<Offer> Offers { get; set; }

        /// <summary>
        /// Returns inscription dates from offers.
        /// </summary>
        public virtual ICollection<InscriptionDate> InscriptionDates { get; set; }
    }
}
