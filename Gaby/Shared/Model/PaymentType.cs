using System;
namespace Gaby.Shared.Model
{
	public class PaymentType
	{
        public string PaymentTypeId { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}

