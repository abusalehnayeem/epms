using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epms.Entities.Models
{
    public class Package : BaseEntity
    {
        public Package()
        {
            BillingsHistorys = new List<BillingsHistory>();
        }
        public string Name { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public DateTime ActivatedDate { get; set; }
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
        public Company Company { get; set; }
        public Branch Branch { get; set; }
    }
}
