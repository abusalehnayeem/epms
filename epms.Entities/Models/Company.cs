using System;

namespace epms.Entities.Models
{
    public class Company:BaseEntity
    {
        public Company()
        {
            
        }
        public short CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public short CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public short? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }

}
