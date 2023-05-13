using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Service.Contracts
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>>? GetAll(RequestParameters parameters, bool trackChanges);
        Task<Supplier>? GetById(Guid id, bool trackChanges);
        Task CreateItem(SupplierFormDto item);
        Task UpdateItem(SupplierFormDto item);
    }
}
