using Microsoft.EntityFrameworkCore;
using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Repository.Extensions;

namespace Proyecto.ETPS4.Grupo13.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(RepositoryContext context) : base(context) { }

        public void CreateItem(Supplier item) => Create(item);
        
        public async Task<IEnumerable<Supplier>> GetAll(RequestParameters parameters, bool trackChanges) =>
           await FindAll(trackChanges)
            .Search(parameters.SearchTerm)
            .ToListAsync();

        public async Task<Supplier>? GetById(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefaultAsync() ?? new Supplier();

        public void UpdateItem(Supplier item) => Update(item);
    }
}
