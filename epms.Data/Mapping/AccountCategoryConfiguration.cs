
using epms.Entities.Models;

namespace epms.Data.Mapping
{
    // AccountCategory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public class AccountCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AccountCategory>
    {
        public AccountCategoryConfiguration()
            : this("dbo")
        {
        }

        public AccountCategoryConfiguration(string schema)
        {
            ToTable("AccountCategory", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryCode).HasColumnName(@"CategoryCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.GroupId).HasColumnName(@"GroupId").HasColumnType("int").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.AccountGroup).WithMany(b => b.AccountCategories).HasForeignKey(c => c.GroupId).WillCascadeOnDelete(false); // FK_AccountCategory_AccountGroup
            HasOptional(a => a.Company).WithMany(b => b.AccountCategories).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false); // FK_AccountCategory_Company
        }
    }

}
