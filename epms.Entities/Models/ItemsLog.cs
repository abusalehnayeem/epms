using System;

namespace epms.Entities.Models
{
    public class ItemsLog : BaseEntity
    {
        public double? OldUnitPrice { get; set; }
        public double? NewUnitPrice { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }

        public int ItemId { get; set; }
        public virtual Items Items { get; set; }
    }
}