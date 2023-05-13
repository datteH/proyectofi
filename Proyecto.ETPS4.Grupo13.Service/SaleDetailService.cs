using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Service
{
    public class SaleDetailService : ISaleDetailService
    {
        private readonly IRepositoryManager _repository;
        public SaleDetailService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task CreateItem(SaleDetail item)
        {
            _repository.SaleDetail.CreateItem(item);
            await _repository.SaveAsync();

            var product = await _repository.Product.GetById((Guid)item.ProductId!, true)!;
            product.Stock -= item.Quantity;
            _repository.Product.UpdateProduct(product);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<SaleDetail>>? GetByHeaderId(SaleDetailRequestParameters parameters, bool trackChanges)
            => await _repository.SaleDetail.GetByHeaderId(parameters, trackChanges)!;
    }
}
