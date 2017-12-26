using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epms.Entities.Models
{

    public class LookUp:BaseEntity
    {
        public int? AccountTypeId { get; set; }
        public int? COAId { get; set; }
        public TypeSetup AccountTypeSetup { get; set; }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
    }

}
