using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;

namespace Proyecto.ETPS4.Grupo13.Service.Contracts
{
    public interface ISaleHeaderService
    {
        Task<IEnumerable<SaleHeader>>? GetAll(RequestParameters parameters, bool trackChanges);
        Task<SaleHeader>? GetById(Guid id, bool trackChanges);
        Task CreateItem(SaleHeader item);
        Task UpdateItem(Guid id, SaleHeaderFormDto item);
    }
}
