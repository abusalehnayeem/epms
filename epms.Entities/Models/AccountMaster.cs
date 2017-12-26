using System;

namespace epms.Entities.Models
{
    public class AccountMaster:BaseEntity
    {
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public int? COACategoryId { get; set; }
        public int? GroupId { get; set; }
        public int? BalanceSheetConfigId { get; set; }
        public bool? IsSubCode { get; set; }
        public string SubCodeId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BankAccountNo { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCompany { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientCompany { get; set; }
        public string CPhone { get; set; }
        public string Phone { get; set; }
        public string Remarks { get; set; }

        public byte? SortedBy { get; set; }
        public bool? IsTransactional { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public bool? IsBankAccount { get; set; }

        public AccountCategory AccountCategory { get; set; }
        public AccountGroup AccountGroup { get; set; }
        public Company Company { get; set; }
    }

}
