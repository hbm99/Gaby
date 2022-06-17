using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Model
{
    public class InscriptionDate
    {


        [Key]
        /// <summary>
        /// Returns inscription moment.
        /// </summary>
        public DateOnly Date { get; set; }

    }
}
