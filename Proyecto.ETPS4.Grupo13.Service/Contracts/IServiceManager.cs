using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Service.Contracts
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IAuthenticationService AuthenticationService { get; }
        ICustomerService CustomerService { get; }
        IProductService ProductService { get; }
        IPurchaseService PurchaseService { get; }
        ISaleDetailService SaleDetailService { get; }
        ISaleHeaderService SaleHeaderService { get; }
        ISupplierService SupplierService { get; }
    }
}
