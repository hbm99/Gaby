
namespace Gaby.Core.Common
{
	/// <summary>
    /// Home address.
    /// </summary>
	public class HomeAddress
	{
		string main_st;
		string secondary_st_1;
		string secondary_st_2;
		int house_number;
		string community;
		string municipality;

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
			this.main_st = main_st;
			this.secondary_st_1 = secondary_st_1;
			this.secondary_st_2 = secondary_st_2;
			this.house_number = house_number;
			this.community = community;
			this.municipality = municipality;
		}

		/// <summary>
        /// Returns the main street.
        /// </summary>
		public string MainSt { get => main_st; }

		/// <summary>
        /// Returns a secondary street.
        /// </summary>
		public string SecondarySt1 { get => secondary_st_1; }

		/// <summary>
		/// Returns a secondary street.
		/// </summary>
		public string SecondarySt2 { get => secondary_st_2; }

		/// <summary>
        /// Returns the house number.
        /// </summary>
        public int HouseNumber { get => house_number; }

		/// <summary>
        /// Returns the community.
        /// </summary>
		public string Community { get => community; }

		/// <summary>
        /// Returns the municipality.
        /// </summary>
		public string Municipality { get => municipality; }

    }
}

