using System.Collections.Generic;

namespace epms.Entities
{
    public class Items : BaseEntity
    {
        public Items()
        {
            ItemsLog = new HashSet<ItemsLog>();
            BillingsHistory = new HashSet<BillingsHistory>();
        }

        public string Name { get; set; }
        public double? UnitPrice { get; set; }
        public virtual ICollection<ItemsLog> ItemsLog { get; set; }
        public virtual ICollection<BillingsHistory> BillingsHistory { get; set; }
    }
}