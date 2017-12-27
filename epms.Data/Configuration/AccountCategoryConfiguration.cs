using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using epms.Entities.Models;

namespace epms.Data.Configuration
{
    // AccountCategory
    internal class AccountCategoryConfiguration : EntityTypeConfiguration<AccountCategory>
    {
        internal AccountCategoryConfiguration()
            : this("dbo")
        {
        }

        internal AccountCategoryConfiguration(string schema)
        {
            ToTable("AccountCategory", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryCode).HasColumnName(@"CategoryCode").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(150);
            Property(x => x.GroupId).HasColumnName(@"GroupId").HasColumnType("int").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.AccountGroup).WithMany(b => b.AccountCategories).HasForeignKey(c => c.GroupId)
                .WillCascadeOnDelete(false); // FK_AccountCategory_AccountGroup
            HasRequired(a => a.Company).WithMany(b => b.AccountCategories).HasForeignKey(c => c.CompanyId)
                .WillCascadeOnDelete(false); // FK_AccountCategory_Company
        }
    }
}