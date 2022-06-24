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


        
        /// <summary>
        /// Returns inscription moment.
        /// </summary>
        [Key]
        public DateOnly Date { get; set; }

    }
}
