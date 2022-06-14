using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Model
{
    public class ClientOffer
    {
        [ForeignKey("OfferId")]
        public int OfferId { get; set; }
        //[InverseProperty("Offers")]

        public Offer Offer { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        //[InverseProperty("MemberClients")]

        public MemberClient MemberClient { get; set; }

        [ForeignKey("Date")]
        public DateOnly Date { get; set; }

        public InscriptionDate InscriptionDate { get; set; }
    }
}
