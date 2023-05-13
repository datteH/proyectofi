using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.ETPS4.Grupo13.Entities.Enums;

namespace Proyecto.ETPS4.Grupo13.Entities.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DocumentType DocumentType { get; set; } = DocumentType.DUI;
        public string? DocumentNumber { get; set; }
    }
}
