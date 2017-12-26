using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class Branch:BaseEntity
    {
        public Branch()
        {
            this.Customers = new HashSet<Customer>();
        }

        public string BranchName { get; set; }
        public short BranchCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public Company Company { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}