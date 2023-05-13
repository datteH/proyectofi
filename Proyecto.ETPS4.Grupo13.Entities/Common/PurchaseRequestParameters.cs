using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Common
{
    public class PurchaseRequestParameters : RequestParameters
    {
        public Guid? SupplierId { get; set; }
        public Guid? ProductId { get; set; }
    }
}
