using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Extensions
{
    public static class PurchaseRepositoryExtension
    {
        public static IQueryable<Purchase> Filter(this IQueryable<Purchase> query, Guid? supplierId, Guid? productId)
        {
            if (supplierId != null && supplierId != Guid.Empty)
                return query.Where(p => p.SupplierId.Equals(supplierId));

            if (productId != null && productId != Guid.Empty)
                return query.Where(P => P.ProductId.Equals(productId));

            if ((supplierId != null && supplierId != Guid.Empty) && (productId != null && productId != Guid.Empty))
                return query.Where(p => p.SupplierId.Equals(supplierId) && p.ProductId.Equals(productId));

            return query;
        }
    }
}
