using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Contracts
{
    public interface ISaleHeaderRepository
    {
        Task<IEnumerable<SaleHeader>>? GetAll(RequestParameters parameters, bool trackChanges);
        Task<SaleHeader>? GetById(Guid id, bool trackChanges);
        void CreateItem(SaleHeader item);
    }
}
