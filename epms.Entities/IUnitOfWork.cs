using System;
using System.Threading;
using System.Threading.Tasks;
using epms.Entities.Repository;

namespace epms.Entities
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        IAccountCategoryRepository AccountCategoryRepository { get; }
        IAccountGroupRepository AccountGroupRepository { get; }
        IAccountMasterRepository AccountMasterRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IBranchRepository BranchRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IBillingsHistoryRepository BillingsHistoryRepository { get; }
        IPackageRepository PackageRepository { get; }

        #endregion

        #region Methods

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #endregion
    }
}
