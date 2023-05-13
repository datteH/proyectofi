using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Service.Contracts;

namespace Proyecto.ETPS4.Grupo13.Service
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IRepositoryManager _repository;
        public PurchaseService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task CreateItem(Purchase item)
        {
            _repository.Purchase.CreateItem(item);
            await _repository.SaveAsync();

            var product = await _repository.Product.GetById((Guid)item.ProductId!, true)!;
            product.Stock += item.Quantity;
            product.CostPrice = (Double)item.Cost! / product.Purchases.Count();
            _repository.Product.UpdateProduct(product);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Purchase>>? GetAll(PurchaseRequestParameters parameters, bool trackChanges)
            => await _repository.Purchase.GetAll(parameters, trackChanges)!;

        public async Task<Purchase>? GetById(Guid id, bool trackChanges)
            => await _repository.Purchase.GetById(id, trackChanges)!;
    }
}
