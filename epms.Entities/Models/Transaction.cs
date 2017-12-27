using System;

namespace epms.Entities.Models
{
    public class Transaction : BaseEntity
    {
        public string TransactionId { get; set; }
        public long? VoucherNo { get; set; }
        public string VoucherType { get; set; }
        public string VoucherCode { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string EntryType { get; set; }
        public string Particular { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public bool? IsAdvancePayment { get; set; }
        public bool? IsChequePayment { get; set; }
        public bool? IsCleared { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeIssueDate { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string BranchName { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public int? COAId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public bool? IsRejected { get; set; }
        public bool? IsReversed { get; set; }
        public string RejectReason { get; set; }
    }
}