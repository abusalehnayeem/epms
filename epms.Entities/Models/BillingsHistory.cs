using System;

namespace epms.Entities.Models
{
    public class BillingsHistory : BaseEntity
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public DateTime BillingDate { get; set; }
        public double? UnitPrice { get; set; }
        public int? Quentity { get; set; }
        public double? TotalPrice { get; set; }
        public double? VatAmount { get; set; }
        public double? Discount { get; set; }
        public double? PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
        public bool? BillStatus { get; set; }
        public int PackageId { get; set; }
        public int CustomerId { get; set; }
        public Package Package { get; set; }
        public Customer Customer { get; set; }
        public Company Company { get; set; }
        public Branch Branch { get; set; }
    }
}