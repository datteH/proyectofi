using AutoMapper;
using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
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
    public class SaleHeaderService : ISaleHeaderService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public SaleHeaderService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;        
            _mapper = mapper;
        }

        public async Task CreateItem(SaleHeader item)
        {
            _repository.SaleHeader.CreateItem(item);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<SaleHeader>>? GetAll(RequestParameters parameters, bool trackChanges)
            => await _repository.SaleHeader.GetAll(parameters, trackChanges)!;

        public async Task<SaleHeader>? GetById(Guid id, bool trackChanges)
            => await _repository.SaleHeader.GetById(id, trackChanges)!;

        public async Task UpdateItem(Guid id, SaleHeaderFormDto item)
        {
            var entity = await _repository.SaleHeader.GetById(id, true)!;

            if (entity != null)
            {
                _mapper.Map(item, entity);

                await _repository.SaveAsync();
            }                
        }
    }
}
