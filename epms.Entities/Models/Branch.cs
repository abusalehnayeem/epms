using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class Branch : BaseEntity
    {
        public Branch()
        {
            Customers = new HashSet<Customer>();
            BillingsHistorys = new HashSet<BillingsHistory>();
            Packages = new HashSet<Package>();
        }

        public string BranchName { get; set; }
        public short BranchCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public Company Company { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
        public ICollection<Package> Packages { get; set; }
    }
}