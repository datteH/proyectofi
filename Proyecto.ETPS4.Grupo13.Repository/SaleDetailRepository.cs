using Microsoft.EntityFrameworkCore;
using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository
{
    public class SaleDetailRepository : RepositoryBase<SaleDetail>, ISaleDetailRepository
    {
        public SaleDetailRepository(RepositoryContext context) : base(context) { }

        public void CreateItem(SaleDetail item) => Create(item);

        public async Task<IEnumerable<SaleDetail>>? GetByHeaderId(SaleDetailRequestParameters parameters, bool trackChanges) =>
            await FindByCondition(d => d.SaleHeaderId.Equals(parameters.SaleHeaderId), trackChanges)
            .ToListAsync();
    }
}
