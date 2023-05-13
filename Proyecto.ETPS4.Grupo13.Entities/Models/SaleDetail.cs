using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Models
{
    public class SaleDetail
    {
        public Guid Id { get; set; }
        public Guid? SaleHeaderId { get; set; }
        public Guid? ProductId { get; set; }
        public string? ProductDescription { get; set; }
        public int Quantity { get; set; }
        public Double Price { get; set; } = 0.0;
        public Double SubTotal { get; set; } = 0.0;
        public SaleHeader? SaleHeader { get; set; }
        public Product? Product { get; set; }
    }
}
