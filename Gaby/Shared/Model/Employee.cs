using System;
namespace Gaby.Shared.Model
{
    public abstract class Employee
    {

        /// <summary>
        /// Returns the ID of the employee. This ID is the identity number of the employee. 
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Returns the name of the employee.
        /// </summary>
        public string Name { get; set; }

    }
}
