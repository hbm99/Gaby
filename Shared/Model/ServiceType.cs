using System;
using System.ComponentModel.DataAnnotations;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    public class ServiceType
    {
        /// <summary>
        /// Returns service type name.
        /// </summary>
        [Key]
        public string ServiceTypeName { get; set; }
    }
}

