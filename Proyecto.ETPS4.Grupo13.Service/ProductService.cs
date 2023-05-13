using AutoMapper;
using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Service.Contracts;

namespace Proyecto.ETPS4.Grupo13.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task CreateProduct(ProductFormDto item)
        {
            var entity = _mapper.Map<Product>(item);

            _repository.Product.CreateProduct(entity);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetAll(RequestParameters parameters, bool trackChanges)
        {
            var entities = await _repository.Product.GetAll(parameters, trackChanges)!;
            var dtos = _mapper.Map<IEnumerable<ProductDto>>(entities);

            return dtos;
        }

        public async Task<ProductDto>? GetById(Guid id, bool trackChanges)
        {
            var entity = await _repository.Product.GetById(id, trackChanges)!;
            var dto = _mapper.Map<ProductDto>(entity);

            return dto;
        }

        public async Task UpdateProduct(ProductFormDto item)
        {
            var entity = await _repository.Product.GetById(item.Id, true)!;

            _mapper.Map(item, entity);

            _repository.Product.UpdateProduct(entity);
            await _repository.SaveAsync();
        }
    }
}
