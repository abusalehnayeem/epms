using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using epms.Entities.Models;

namespace epms.Data.Configuration
{
    internal class PackageConfiguration : EntityTypeConfiguration<Package>
    {
        internal PackageConfiguration()
            : this("dbo")
        {
        }

        internal PackageConfiguration(string schema)
        {
            ToTable("Package", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Details).HasColumnName(@"Details").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal").IsRequired();
            Property(x => x.ActivatedDate).HasColumnName(@"ActivatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BranchId).HasColumnName(@"BranchId").HasColumnType("int").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsOptional();
            Property(x => x.IsApproved).HasColumnName(@"IsApproved").HasColumnType("bit").IsOptional();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired();
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.CreatedDateTime).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsOptional();
            Property(x => x.UpdatedDateTime).HasColumnName(@"UpdatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SortedBy).HasColumnName(@"SortedBy").HasColumnType("int").IsOptional();
            Property(x => x.Remarks).HasColumnName(@"Remarks").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);

            // Foreign keys
            HasRequired(a => a.Branch).WithMany(b => b.Packages).HasForeignKey(c => c.BranchId)
                .WillCascadeOnDelete(false); // FK_Customer_Customer
            HasRequired(a => a.Company).WithMany(b => b.Packages).HasForeignKey(c => c.CompanyId)
                .WillCascadeOnDelete(false); // FK_Customer_Company
        }
    }
}