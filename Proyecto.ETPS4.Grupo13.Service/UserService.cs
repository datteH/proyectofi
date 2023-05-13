using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repository, IMapper mapper,
           UserManager<User> userManager)
        {
            _userManager = userManager;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IdentityResult> CreateUser(UserForRegistrationDto register)
        {
            var user = _mapper.Map<User>(register);

            user.UserName = register.Email;

            var result = await _userManager.CreateAsync(user, register.Password!);

            return result;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(RequestParameters parameters, bool trackChanges) => 
            await _repository.User.GetAllUsersAsync(parameters, trackChanges);

        public async Task<User> GetUserByIdAsync(string id) =>
            await _userManager.FindByIdAsync(id);

        public async Task<IdentityResult> UpdateUserAsync(UserUpdateDto form)
        {
            var entity = await _userManager.FindByEmailAsync(form.Email);

            if (!string.IsNullOrEmpty(form.Password))
            {
                var hasher = new PasswordHasher<User>();

                entity.PasswordHash = hasher.HashPassword(entity, form.Password);
            }

            _mapper.Map(form, entity);

            var results = await _userManager.UpdateAsync(entity);

            return results;
        }
    }
}
