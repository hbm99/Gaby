using System;
using System.ComponentModel.DataAnnotations;

namespace Gaby.Shared.Model
{

	public class EquipmentRepair
	{
        /// <summary>
        /// Refers to the employee who did the repair.
        /// </summary>
        public MaintenanceEmployee MaintenanceEmployee { get; set; }


        /// <summary>
        /// Refers to the gym equipment that was repaired.
        /// </summary>
        public Equipment Equipment { get; set; }


        /// <summary>
        /// Returns the date of the equipment repair.
        /// </summary>
        public DateOnly ReparationDate { get; set; }
    }
}

