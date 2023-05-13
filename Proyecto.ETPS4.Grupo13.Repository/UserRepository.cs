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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context) { }

        public async Task<IEnumerable<User>> GetAllUsersAsync(RequestParameters parameters, bool trackChanges) =>
            await FindAll(trackChanges)
            .Search(parameters.SearchTerm)
            .ToListAsync();
    }
}
