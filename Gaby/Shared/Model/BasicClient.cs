using Gaby.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Model
{
    public class BasicClient : IClient
    {
        [Key]
        public int ClientId { get; set; }

        /// <summary>
        /// Returns client name.
        /// </summary>
        public string? Name { get; set; }
    }
}
