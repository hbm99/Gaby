using System;
using System.ComponentModel.DataAnnotations;
using Gaby.Shared.Interfaces;

namespace Gaby.Shared.Model
{
    public class ServiceType
    {
        [Key]
        /// <summary>
        /// Returns service type name.
        /// </summary>
        public string ServiceTypeName { get; set; }
    }
}

