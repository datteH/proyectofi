﻿using Microsoft.EntityFrameworkCore;
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
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext context) : base(context) { }

        public void CreateCustomer(Customer customer) => Create(customer);
        public void UpdateCustomer(Customer customer) => Update(customer);
        public async Task<IEnumerable<Customer>> GetAll(RequestParameters parameters, bool trackChanges) =>
           await FindAll(trackChanges)
            .Search(parameters.SearchTerm)
            .ToListAsync();

        public async Task<Customer>? GetById(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges)
            .FirstOrDefaultAsync() ?? new Customer();
    }
}
