using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using epms.Entities.Models;

namespace epms.Data.Configuration
{
    internal class AccountGroupConfiguration : EntityTypeConfiguration<AccountGroup>
    {
        internal AccountGroupConfiguration()
            : this("dbo")
        {
        }

        internal AccountGroupConfiguration(string schema)
        {
            ToTable("AccountGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GroupCode).HasColumnName(@"GroupCode").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(50);
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(200);
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsOptional();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.Company).WithMany(b => b.AccountGroups).HasForeignKey(c => c.CompanyId)
                .WillCascadeOnDelete(false); // FK_AccountGroup_Company
        }
    }
}