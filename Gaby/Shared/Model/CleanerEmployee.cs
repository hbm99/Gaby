using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    [Table("CleanerEmployees")]
    public class CleanerEmployee : Employee, IBasicSalary
    {
        public decimal BasicSalary { get; set; }
    }
}

