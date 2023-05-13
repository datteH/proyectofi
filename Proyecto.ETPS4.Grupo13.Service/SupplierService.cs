using AutoMapper;
using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Service.Contracts;

namespace Proyecto.ETPS4.Grupo13.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public SupplierService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateItem(SupplierFormDto item)
        {
            var entity = _mapper.Map<Supplier>(item);
            _repository.Supplier.CreateItem(entity);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Supplier>>? GetAll(RequestParameters parameters, bool trackChanges)
            => await _repository.Supplier.GetAll(parameters, trackChanges)!;

        public async Task<Supplier>? GetById(Guid id, bool trackChanges)
            => await _repository.Supplier.GetById(id, trackChanges)!;

        public async Task UpdateItem(SupplierFormDto item)
        {
            var entity = await _repository.Supplier.GetById(item.Id, true)!;

            _mapper.Map(item, entity);

            _repository.Supplier.UpdateItem(entity);
            await _repository.SaveAsync();
        }
    }
}
