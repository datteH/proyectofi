using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Double CostPrice { get; set; } = 0.0;
        public Double SalePrice { get; set; } = 0.0;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Stock { get; set; } = 0;
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
