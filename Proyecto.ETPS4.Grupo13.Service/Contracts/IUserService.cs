using Microsoft.AspNetCore.Identity;
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
    public interface IUserService
    {
        Task<IdentityResult> CreateUser(UserForRegistrationDto register);
        Task<IEnumerable<User>> GetAllUsersAsync(RequestParameters parameters, bool trackChanges);
        Task<IdentityResult> UpdateUserAsync(UserUpdateDto form);
        Task<User> GetUserByIdAsync(string id);
    }
}
