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
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        public CustomerService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task CreateItem(Customer customer)
        {
            _repository.Customer.CreateCustomer(customer);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Customer>>? GetAll(RequestParameters parameters, bool trackChanges)
            => await _repository.Customer.GetAll(parameters, trackChanges)!;

        public async Task<Customer>? GetById(Guid id, bool trackChanges)
            => await _repository.Customer.GetById(id, trackChanges)!;

        public async Task UpdateItem(Customer customer)
        {
            _repository.Customer.UpdateCustomer(customer);
            await _repository.SaveAsync();
        }
    }
}
