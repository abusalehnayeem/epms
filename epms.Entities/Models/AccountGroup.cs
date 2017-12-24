using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class AccountGroup
    {
        public AccountGroup()
        {
            this.BalanceSheetConfigurations = new List<BalanceSheetConfiguration>();
            AccountMasters = new List<AccountMaster>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public short? CompanyId { get; set; }
        public bool? IsActive { get; set; }

        public List<BalanceSheetConfiguration> BalanceSheetConfigurations { get; set; }
        public List<AccountMaster> AccountMasters { get; set; }
    }

}
