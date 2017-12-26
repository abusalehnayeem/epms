using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epms.Entities.Models
{
    public class Invoice : BaseEntity
    {
        public Invoice()
        {
            BillingsHistorys = new List<BillingsHistory>();
        }
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
    }
}
