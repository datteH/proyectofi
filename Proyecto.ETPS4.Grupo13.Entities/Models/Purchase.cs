using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Models
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Double? Cost { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? ProductId { get; set; }
        public DateTime PurchasedAt { get; set; } = DateTime.Now;
        public Supplier? Supplier { get; set; }
        public Product? Product { get; set; }
    }
}
