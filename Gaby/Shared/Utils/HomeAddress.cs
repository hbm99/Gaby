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
		/// Creates a new address.
		/// </summary>
		/// <param name="main_st"></param>
		/// <param name="secondary_st_1"></param>
		/// <param name="secondary_st_2"></param>
		/// <param name="house_number"></param>
		/// <param name="community"></param>
		/// <param name="municipality"></param>
		public HomeAddress(string main_st, string secondary_st_1, string secondary_st_2, int house_number, string community, string municipality)
		{
			this.MainSt = main_st;
			this.SecondarySt1 = secondary_st_1;
			this.SecondarySt2 = secondary_st_2;
			this.HouseNumber = house_number;
			this.Community = community;
			this.Municipality = municipality;
		}

		/// <summary>
		/// Returns the main street.
		/// </summary>
		public string MainSt { get; private set; }

		/// <summary>
		/// Returns a secondary street.
		/// </summary>
		public string SecondarySt1 { get; private set; }

		/// <summary>
		/// Returns a secondary street.
		/// </summary>
		public string SecondarySt2 { get; private set; }

		/// <summary>
		/// Returns the house number.
		/// </summary>
		public int HouseNumber { get; private set; }

		/// <summary>
		/// Returns the community.
		/// </summary>
		public string Community { get; private set; }

		/// <summary>
		/// Returns the municipality.
		/// </summary>
		public string Municipality { get; private set; }
	}
}
