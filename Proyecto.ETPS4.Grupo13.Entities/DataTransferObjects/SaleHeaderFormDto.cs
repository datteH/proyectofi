using Proyecto.ETPS4.Grupo13.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects
{
    public class SaleHeaderFormDto
    {
        public Guid Id { get; set; }
        public Guid? CustomerId { get; set; }
        public Double Total { get; set; } = 0.0;
        public SaleType SaleType { get; set; } = SaleType.Cash;
        public SaleReceiptType SaleReceiptType { get; set; } = SaleReceiptType.Ticket;
        public InvoiceStatus Status { get; set; } = InvoiceStatus.InProcess;
    }
}
