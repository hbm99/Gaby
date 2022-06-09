using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    [Table("MaintenanceEmployees")]
    public class MaintenanceEmployee: Employee, IBasicSalary, IExtraSalary
	{

        /// <summary>
        /// Returns the repairs that the employee has done.
        /// </summary>
        public ICollection<EquipmentRepair>? Repairs { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal ExtraSalary { get; set; }
    }
}

