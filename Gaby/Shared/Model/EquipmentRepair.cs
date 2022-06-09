using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaby.Shared.Model
{

	public class EquipmentRepair
	{
        [ForeignKey("EmployeeId")]
        [InverseProperty("EquipmentRepairs")]
        /// <summary>
        /// Refers to the employee who did the repair.
        /// </summary>
        public MaintenanceEmployee MaintenanceEmployee { get; set; }


        [ForeignKey("EquipmentId")]
        [InverseProperty("EquipmentRepairs")]
        /// <summary>
        /// Refers to the equipment repaired.
        /// </summary>
        public Equipment Equipment { get; set; }


        /// <summary>
        /// Returns the date of the equipment repair.
        /// </summary>
        public DateOnly ReparationDate { get; set; }
    }
}

