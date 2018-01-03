using System.Threading;
using System.Threading.Tasks;
using epms.Data.Context;
using epms.Data.Repository;
using epms.Entities;
using epms.Entities.Repository;

namespace epms.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IAccountCategoryRepository _accountCategoryRepository;
        private IAccountGroupRepository _accountGroupRepository;
        private IAccountMasterRepository _accountMasterRepository;
        private IBranchRepository _branchRepository;
        private ICompanyRepository _companyRepository;

        private IBillingsHistoryRepository _billingsHistoryRepository;
        private IPackageRepository _packageRepository;
        private ICustomerRepository _customerRepository;

        public UnitOfWork(string connectionString)
        {
            _context = new ApplicationDbContext(connectionString);
        }

        public void Dispose()
        {
            _accountCategoryRepository = null;
            _accountGroupRepository = null;
            _accountMasterRepository = null;
            _branchRepository = null;
            _companyRepository = null;
            _billingsHistoryRepository = null;
            _packageRepository = null;
            _customerRepository = null;
        }

        public IAccountCategoryRepository AccountCategoryRepository =>
            _accountCategoryRepository ?? (_accountCategoryRepository = new AccountCategoryRepository(_context));

        public IAccountGroupRepository AccountGroupRepository =>
            _accountGroupRepository ?? (_accountGroupRepository = new AccountGroupRepository(_context));

        public IAccountMasterRepository AccountMasterRepository =>
            _accountMasterRepository ?? (_accountMasterRepository = new AccountMasterRepository(_context));

        public ICompanyRepository CompanyRepository =>
            _companyRepository ?? (_companyRepository = new CompanyRepository(_context));

        public IBranchRepository BranchRepository =>
            _branchRepository ?? (_branchRepository = new BranchRepository(_context));

        public ICustomerRepository CustomerRepository =>
            _customerRepository ?? (_customerRepository = new CustomerRepository(_context));

        public IBillingsHistoryRepository BillingsHistoryRepository =>
            _billingsHistoryRepository ?? (_billingsHistoryRepository = new BillingsHistoryRepository(_context));

        public IPackageRepository PackageRepository =>
            _packageRepository ?? (_packageRepository = new PackageRepository(_context));

        int IUnitOfWork.SaveChanges()
        {
            return _context.SaveChanges();
        }

        Task<int> IUnitOfWork.SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        Task<int> IUnitOfWork.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
