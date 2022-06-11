using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Interfaces
{
    public interface IClient
    {
        /// <summary>
        /// Returns client Id (key).
        /// </summary>
        int ClientId { get; set; }
    }
}
