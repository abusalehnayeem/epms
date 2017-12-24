namespace epms.Entities.Models
{
    public class Branch:BaseEntity
    {
        public string BranchName { get; set; }
        public short BranchCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Company Company { get; set; }

    }

}
