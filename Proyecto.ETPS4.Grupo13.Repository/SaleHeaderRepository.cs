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
    public class SaleHeaderRepository : RepositoryBase<SaleHeader>, ISaleHeaderRepository
    {
        public SaleHeaderRepository(RepositoryContext context) : base(context) { }

        public void CreateItem(SaleHeader item) => Create(item);

        public async Task<IEnumerable<SaleHeader>> GetAll(RequestParameters parameters, bool trackChanges) =>
           await FindAll(trackChanges)
            .Include(h => h.Customer)
            .Include(h => h.User)
            .Include(h => h.SaleDetails)!.ThenInclude(d => d.Product)
            .Search(parameters.SearchTerm)
            .ToListAsync();

        public async Task<SaleHeader>? GetById(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges)
            .Include(c => c.SaleDetails)
            .FirstOrDefaultAsync() ?? new SaleHeader();

    }
}
