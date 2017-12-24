﻿using System;

namespace epms.Entities.Models
{
    public class BillingsHistory : BaseEntity
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public DateTime BillingDate { get; set; }
        public double? TotalAmount { get; set; }
        public double? DueAmount { get; set; }
        public double? VatAmount { get; set; }
        public double? Discount { get; set; }
        public double? PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
        public bool? BillStatus { get; set; }
        public int PackageId { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual Package Package { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}