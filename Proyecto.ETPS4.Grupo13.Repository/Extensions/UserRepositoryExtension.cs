using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Extensions
{
    public static class UserRepositoryExtension
    {
        public static IQueryable<User> Search(this IQueryable<User> query, string? searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return query;

            var lowerTerm = searchTerm.ToLower();

            return query.Where(user => user.FirstName!.ToLower().Contains(lowerTerm) 
            || user.LastName!.ToLower().Contains(lowerTerm));
        }
    }
}
