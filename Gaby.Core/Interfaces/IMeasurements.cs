using System;
namespace Gaby.Core.Interfaces
{
	/// <summary>
    /// Measurement Id.
    /// </summary>
	public interface IMeasurements
	{
		/// <summary>
		/// Returns the measurements code (primary key).
		/// </summary>
		int MeasurementsId { get; set; }
	}
}

