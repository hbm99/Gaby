using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Utils
{
	
    public class HomeAddress
    {
		/// <summary>
		/// Returns the main street.
		/// </summary>
		public string MainSt { get; set; }

		/// <summary>
		/// Returns a secondary street.
		/// </summary>
		public string SecondarySt1 { get; set; }

		/// <summary>
		/// Returns a secondary street.
		/// </summary>
		public string SecondarySt2 { get; set; }

		/// <summary>
		/// Returns the house number.
		/// </summary>
		public int HouseNumber { get; set; }

		/// <summary>
		/// Returns the community.
		/// </summary>
		public string Community { get; set; }

		/// <summary>
		/// Returns the municipality.
		/// </summary>
		public string Municipality { get; set; }
	}
}
