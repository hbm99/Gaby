using System;
using System.ComponentModel.DataAnnotations;

namespace Gaby.Shared.Model
{
	public class Payment
	{
        [Required]
        public ICollection<PaymentType> PaymentType { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        //Requiere nueva tabla o no entiendo el contexto
       // public ICollection<Tuple<PaymentType, decimal >> AmountPerType { get; set; }

    }
}

