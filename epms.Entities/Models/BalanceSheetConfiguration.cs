namespace epms.Entities.Models
{
    public class BalanceSheetConfiguration:BaseEntity
    {
        public int GroupId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public AccountGroup AccountGroup { get; set; }
        public AccountCategory AccountCategory { get; set; }
    }

}
