using System;
namespace Gaby.Shared.Interfaces
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

