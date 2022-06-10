using System;
using System.ComponentModel.DataAnnotations;

namespace Gaby.Shared.Model
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public ICollection<PaymentType> PaymentType { get; set; }

        public DateOnly PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public ICollection<AmountPerType_Payment> AmountPerType { get; set; }


    }
}

