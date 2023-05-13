using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<ICustomerRepository> _customersRepository;
        private readonly Lazy<IProductRepository> _productsRepository;
        private readonly Lazy<IPurchaseRepository> _purchaseRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<ISaleDetailRepository> _saleDetailRepository;
        private readonly Lazy<ISaleHeaderRepository> _saleHeaderRepository;
        private readonly Lazy<ISupplierRepository> _supplierRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _customersRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(context));
            _productsRepository = new Lazy<IProductRepository>(() => new ProductRepository(context));
            _purchaseRepository = new Lazy<IPurchaseRepository>(() => new PurchaseRepository(context));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
            _saleDetailRepository = new Lazy<ISaleDetailRepository>(() => new SaleDetailRepository(context));
            _saleHeaderRepository = new Lazy<ISaleHeaderRepository>(() => new SaleHeaderRepository(context));
            _supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(context));
        }

        public ICustomerRepository Customer => _customersRepository.Value;
        public IProductRepository Product => _productsRepository.Value;
        public IPurchaseRepository Purchase => _purchaseRepository.Value;
        public IUserRepository User => _userRepository.Value;
        public ISaleDetailRepository SaleDetail => _saleDetailRepository.Value;
        public ISaleHeaderRepository SaleHeader => _saleHeaderRepository.Value;
        public ISupplierRepository Supplier => _supplierRepository.Value;
        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
