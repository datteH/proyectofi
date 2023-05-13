using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects
{
    public class ProductFormDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Double SalePrice { get; set; } = 0.0;
        public string? Description { get; set; }
    }
}
