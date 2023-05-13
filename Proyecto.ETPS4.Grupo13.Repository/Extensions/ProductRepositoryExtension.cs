using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Extensions
{
    public static class ProductRepositoryExtension
    {
        public static IQueryable<Product> Search(this IQueryable<Product> query, string? searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return query;

            var lowerCaseTerm = searchTerm!.ToLower();

            return query.Where(item => item.Name!.Contains(lowerCaseTerm) || item.Description!.Contains(lowerCaseTerm));
        }
    }
}
