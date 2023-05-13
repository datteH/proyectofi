using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Service.Contracts;

namespace Proyecto.ETPS4.Grupo13.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IPurchaseService> _purchaseService;
        private readonly Lazy<ISaleDetailService> _saleDetailService;
        private readonly Lazy<ISaleHeaderService> _saleHeaderService;
        private readonly Lazy<ISupplierService> _supplierService;

        public ServiceManager(IRepositoryManager repository, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IHttpContextAccessor context)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repository, mapper, userManager));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, signInManager, context));
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repository));
            _productService = new Lazy<IProductService>(() => new ProductService(repository, mapper));
            _purchaseService = new Lazy<IPurchaseService>(() => new PurchaseService(repository));
            _saleDetailService = new Lazy<ISaleDetailService>(() => new SaleDetailService(repository));
            _saleHeaderService = new Lazy<ISaleHeaderService>(() => new SaleHeaderService(repository, mapper));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repository, mapper));
        }

        public IUserService UserService => _userService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public ICustomerService CustomerService => _customerService.Value;
        public IProductService ProductService => _productService.Value;
        public IPurchaseService PurchaseService => _purchaseService.Value;
        public ISaleDetailService SaleDetailService => _saleDetailService.Value;
        public ISaleHeaderService SaleHeaderService => _saleHeaderService.Value;
        public ISupplierService SupplierService => _supplierService.Value;
    }
}