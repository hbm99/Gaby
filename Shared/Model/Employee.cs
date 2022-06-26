using System;
using System.ComponentModel.DataAnnotations;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    public class Employee : IEmployee, INamed, IRemovable
    {
        [Key] 
        public string EmployeeId { get; set; } = "";

        /// <summary>
        /// Returns the name of the employee.
        /// </summary>
        public string Name { get; set; }

        public bool Active { get; set; } = true;
    }
}
