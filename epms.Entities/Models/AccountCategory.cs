using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class AccountCategory:BaseEntity
    {
        public AccountCategory()
        {
            this.BalanceSheetConfigurations = new List<BalanceSheetConfiguration>();
            this.AccountMasters = new List<AccountMaster>();
        }

        public string CategoryName { get; set; }
        public int? GroupId { get; set; }

        public Company Company { get; set; }
        public List<BalanceSheetConfiguration> BalanceSheetConfigurations { get; set; }
        public List<AccountMaster> AccountMasters { get; set; }
    }

}
