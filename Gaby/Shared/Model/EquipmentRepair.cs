using Gaby.Shared.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaby.Shared.Model
{

    public class EquipmentRepair : IEmployee
    {
        [Required]
        [ForeignKey("EmployeeId")]
        [InverseProperty("EquipmentRepairs")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Refers to the employee who did the repair.
        /// </summary>
        public virtual MaintenanceEmployee MaintenanceEmployee { get; set; }

        [Required]
        [ForeignKey("EquipmentId")]
        [InverseProperty("EquipmentRepairs")]
        public int EquipmentId { get; set; }

        /// <summary>
        /// Refers to the equipment repaired.
        /// </summary>
        public virtual Equipment Equipment { get; set; }


        /// <summary>
        /// Returns the date of the equipment repair.
        /// </summary>
        public DateOnly ReparationDate { get; set; }
    }
}

