using epms.Entities.Models;

namespace epms.Data.Mapping
{
    public class BranchConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
            : this("dbo")
        {
        }

        public BranchConfiguration(string schema)
        {
            ToTable("Branch", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsRequired();
            Property(x => x.BranchName).HasColumnName(@"BranchName").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.BranchCode).HasColumnName(@"BranchCode").HasColumnType("smallint").IsRequired();
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Company).WithMany(b => b.Branches).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false); // FK_Branch_Branch
        }
    }
}