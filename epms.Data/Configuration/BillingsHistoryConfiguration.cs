using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using epms.Entities.Models;

namespace epms.Data.Configuration
{
    internal class BillingsHistoryConfiguration : EntityTypeConfiguration<BillingsHistory>
    {
        internal BillingsHistoryConfiguration()
            : this("dbo")
        {
        }

        internal BillingsHistoryConfiguration(string schema)
        {
            ToTable("BillingsHistory", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
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
            HasRequired(a => a.Branch).WithMany(b => b.BillingsHistorys).HasForeignKey(c => c.BranchId)
                .WillCascadeOnDelete(false); // FK_BillingsHistory_Branch
            HasRequired(a => a.Company).WithMany(b => b.BillingsHistorys).HasForeignKey(c => c.CompanyId)
                .WillCascadeOnDelete(false); // FK_BillingsHistory_Company
            HasRequired(a => a.Package).WithMany(b => b.BillingsHistorys).HasForeignKey(c => c.PackageId)
                .WillCascadeOnDelete(false); // FK_illingsHistory_Package
            HasRequired(a => a.Customer).WithMany(b => b.BillingsHistorys).HasForeignKey(c => c.CustomerId)
                .WillCascadeOnDelete(false); // FK_illingsHistory_Package
        }
    }
}