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
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context) { }

        public void CreateProduct(Product item) => Create(item);
        public void UpdateProduct(Product item) => Update(item);
        public async Task<IEnumerable<Product>> GetAll(RequestParameters parameters, bool trackChanges) =>
           await FindAll(trackChanges)
            .Search(parameters.SearchTerm)
            .ToListAsync();

        public async Task<Product>? GetById(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges)
            .Include(p => p.Purchases)
            .FirstOrDefaultAsync() ?? new Product();
    }
}
