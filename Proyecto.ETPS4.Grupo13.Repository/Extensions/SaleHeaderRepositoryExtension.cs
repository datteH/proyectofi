using Proyecto.ETPS4.Grupo13.Entities.Models;

namespace Proyecto.ETPS4.Grupo13.Repository.Extensions
{
    public static class SaleHeaderRepositoryExtension
    {
        public static IQueryable<SaleHeader> Search(this IQueryable<SaleHeader> query, string? id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return query;

            return query.Where(s => s.Id.ToString().Contains(id));
        }
    }
}
