using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Contracts
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>>? GetAll(RequestParameters parameters, bool trackChanges);
        Task<Customer>? GetById(Guid id, bool trackChanges);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}
