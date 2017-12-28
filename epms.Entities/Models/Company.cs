using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class Company : BaseEntity
    {
        public Company()
        {
            AccountCategories = new HashSet<AccountCategory>();
            AccountGroups = new HashSet<AccountGroup>();
            AccountMasters = new HashSet<AccountMaster>();
            Branches = new HashSet<Branch>();
            Customers = new HashSet<Customer>();
            BillingsHistorys=new HashSet<BillingsHistory>();
            Packages=new HashSet<Package>();
        }

        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public ICollection<AccountCategory> AccountCategories { get; set; }
        public ICollection<AccountGroup> AccountGroups { get; set; }
        public ICollection<AccountMaster> AccountMasters { get; set; }
        public ICollection<Branch> Branches { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
        public ICollection<Package> Packages { get; set; }
    }
}