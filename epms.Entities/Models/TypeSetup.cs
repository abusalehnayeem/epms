using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class TypeSetup:BaseEntity
    {
        public TypeSetup()
        {
            this.LookUps = new List<LookUp>();
        }
        public string AccountTypeName { get; set; }
        public string AccountTypeCode { get; set; }  
        public bool? IsDeleted { get; set; }
        public List<LookUp> LookUps { get; set; }
    }

}
