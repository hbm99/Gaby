using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{

    [Table("Coaches")]
    public class Coach : Employee, IBasicSalary, IExtraSalary
    {
        public decimal BasicSalary { get; set; }

        public decimal ExtraSalary { get; set; }
    }
}

