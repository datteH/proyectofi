using Microsoft.EntityFrameworkCore;
using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository
{
    public class PurchaseRepository : RepositoryBase<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(RepositoryContext context) : base(context) { }

        public void CreateItem(Purchase item) => Create(item);

        public async Task<IEnumerable<Purchase>> GetAll(PurchaseRequestParameters parameters, bool trackChanges) =>
           await FindAll(trackChanges)
            .Filter(parameters.SupplierId, parameters.ProductId)
            .ToListAsync();

        public async Task<Purchase>? GetById(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefaultAsync() ?? new Purchase();
    }
}
