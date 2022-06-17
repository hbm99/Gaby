using System;
namespace Gaby.Shared.Interfaces
{
	public interface IEmployee
	{
		/// <summary>
		/// Returns the ID of the employee. This ID is the identity number of the employee. 
		/// </summary>
		string EmployeeId { get; set; }
	}
}

