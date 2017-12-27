using epms.Entities.Models;

namespace epms.Data.Mapping
{
    public class AccountGroupConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AccountGroup>
    {
        public AccountGroupConfiguration()
            : this("dbo")
        {
        }

        public AccountGroupConfiguration(string schema)
        {
            ToTable("AccountGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupCode).HasColumnName(@"GroupCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsOptional();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.Company).WithMany(b => b.AccountGroups).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false); // FK_AccountGroup_Company
        }
    }
}