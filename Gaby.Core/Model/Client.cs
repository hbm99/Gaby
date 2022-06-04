using System;
using Gaby.Core.Interfaces;
namespace Gaby.Core.Model
{
	/// <summary>
    /// Client.
    /// </summary>
	public class Client : IClient
	{
        
        public int ClientId { get; set; }

        /// <summary>
        /// Returns client name.
        /// </summary>
        public string? Name { get; set; }
        
    }
}

