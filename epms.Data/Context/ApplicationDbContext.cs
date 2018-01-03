using System.Data.Entity;
using epms.Data.Configuration;
using epms.Entities.Models;

namespace epms.Data.Context
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("Name=EpmsConnection")
        {
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        internal ApplicationDbContext(string connectionString)
            : base(connectionString)
        {
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Package> AccountCategories { get; set; } // AccountCategory
        public IDbSet<AccountGroup> AccountGroups { get; set; } // AccountGroup
        public IDbSet<AccountMaster> AccountMasters { get; set; } // AccountMaster
        //public IDbSet<BalanceSheetConfiguration> BalanceSheetConfigurations { get; set; } // BalanceSheetConfiguration
        public IDbSet<Branch> Branches { get; set; } // Branch
        public IDbSet<Company> Companies { get; set; } // Company
        public IDbSet<Customer> Customers { get; set; } // Customer
        public IDbSet<Package> Packages { get; set; } // Customer
        public IDbSet<BillingsHistory> BillingsHistories { get; set; } // Customer

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountCategoryConfiguration());
            modelBuilder.Configurations.Add(new AccountGroupConfiguration());
            modelBuilder.Configurations.Add(new AccountMasterConfiguration());
            modelBuilder.Configurations.Add(new BranchConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new PackageConfiguration());
            modelBuilder.Configurations.Add(new BillingsHistoryConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}