using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaby.Shared.Interfaces
{
    public interface IOffer
    {
        /// <summary>
        /// Returns offer Id (key).
        /// </summary>
        int OfferId { get; set; }
    }
}
