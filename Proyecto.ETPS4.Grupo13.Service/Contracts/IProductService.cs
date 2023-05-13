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
    public interface IProductService
    {
        Task CreateProduct(ProductFormDto item);
        Task<IEnumerable<ProductDto>> GetAll(RequestParameters parameters, bool trackChanges);
        Task<ProductDto>? GetById(Guid id, bool trackChanges);
        Task UpdateProduct(ProductFormDto item);
    }
}
