using Gaby.Core.Common;
using Gaby.Core.Interfaces;

namespace Gaby.Core.Model
{
    /// <summary>
    /// Member client.
    /// </summary>
	public class Member : IClient
	{

        public int IdC { get; set; }

        /// <summary>
        /// Returns member's schedule.
        /// </summary>
        public Tuple<TimeOnly, TimeOnly>? Schedule { get; set; }

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
    }
}

