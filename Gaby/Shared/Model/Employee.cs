using System;
using System.ComponentModel.DataAnnotations;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    public abstract class Employee : IEmployee
    {
        [Key]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Returns the name of the employee.
        /// </summary>
        public string Name { get; set; }

    }
}
