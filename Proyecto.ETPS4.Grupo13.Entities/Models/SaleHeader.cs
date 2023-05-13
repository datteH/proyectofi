using Proyecto.ETPS4.Grupo13.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Models
{
    public class SaleHeader
    {
        public Guid Id { get; set; }
        public Guid? CustomerId { get; set; }
        public string? UserId { get; set; }
        public Double Total { get; set; } = 0.0;
        public SaleType SaleType { get; set; } = SaleType.Cash;
        public SaleReceiptType SaleReceiptType { get; set; } = SaleReceiptType.Ticket;
        public InvoiceStatus Status { get; set; } = InvoiceStatus.InProcess;
        public Customer? Customer { get; set; }
        public User? User { get; set; }
        public ICollection<SaleDetail>? SaleDetails { get; set; }
    }
}
