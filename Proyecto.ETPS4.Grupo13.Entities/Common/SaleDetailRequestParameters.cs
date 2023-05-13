using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Common
{
    public class SaleDetailRequestParameters : RequestParameters
    {
        public Guid? SaleHeaderId { get; set; }
    }
}
