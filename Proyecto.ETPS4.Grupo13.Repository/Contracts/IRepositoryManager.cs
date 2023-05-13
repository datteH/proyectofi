using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Contracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customer { get; }
        IProductRepository Product { get; }
        IPurchaseRepository Purchase { get; }
        IUserRepository User { get; }
        ISaleHeaderRepository SaleHeader { get; }
        ISaleDetailRepository SaleDetail { get; }
        ISupplierRepository Supplier { get; }
        Task SaveAsync();
    }
}
