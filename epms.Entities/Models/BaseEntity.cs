using System;

namespace epms.Entities.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public bool Status { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int SortedBy { get; set; }
        public string Remarks { get; set; }
    }
}