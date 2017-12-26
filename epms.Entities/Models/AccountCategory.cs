using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class AccountCategory:BaseEntity
    {
        public AccountCategory()
        {
            this.AccountMasters = new HashSet<AccountMaster>();
        }

        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public int GroupId { get; set; }

        public AccountGroup AccountGroup { get; set; }
        public Company Company { get; set; }
        public ICollection<AccountMaster> AccountMasters { get; set; }
    }
}