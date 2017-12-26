using System;
using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class Company:BaseEntity
    {
        public Company()
        {
            this.AccountCategories = new HashSet<AccountCategory>();
            this.AccountGroups = new HashSet<AccountGroup>();
            this.AccountMasters = new HashSet<AccountMaster>();
            this.Branches = new HashSet<Branch>();
            this.Customers = new HashSet<Customer>();
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
    }
}