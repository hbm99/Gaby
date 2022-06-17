using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Model
{
    public class AmountPerType_Payment
    {
        public AmountPerType_Payment()
        {

        }

        [Key]
        public int AmountPerType_PaymentId { get; set; }
        
        [Required]
        public PaymentType PaymentType { get; set; }

        public decimal Amount { get; set; }
        
        [Required]
        public ICollection<Payment> Payments { get; set; }
    }
}
