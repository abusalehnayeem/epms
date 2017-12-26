using System.Collections.Generic;
using epms.Entities.Enum;

namespace epms.Entities.Models
{
    public class AccountGroup:BaseEntity
    {
        public AccountGroup()
        {
            this.AccountCategories = new HashSet<AccountCategory>();
            this.AccountMasters = new HashSet<AccountMaster>();
        }

        public string GroupCode { get; set; }
        public string GroupName { get; set; }

        public Company Company { get; set; }
        public ICollection<AccountCategory> AccountCategories { get; set; }
        public ICollection<AccountMaster> AccountMasters { get; set; }
    }
}