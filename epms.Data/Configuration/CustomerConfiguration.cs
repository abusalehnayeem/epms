using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using epms.Entities.Models;

namespace epms.Data.Configuration
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        internal CustomerConfiguration()
            : this("dbo")
        {
        }

        internal CustomerConfiguration(string schema)
        {
            ToTable("Customer", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CustomerName).HasColumnName(@"CustomerName").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.CustomerImage).HasColumnName(@"CustomerImage").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FatherName).HasColumnName(@"FatherName").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.MotherName).HasColumnName(@"MotherName").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.SpouseName).HasColumnName(@"SpouseName").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.Gender).HasColumnName(@"Gender").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.CustomerEntryDate).HasColumnName(@"CustomerEntryDate").HasColumnType("datetime")
                .IsOptional();
            Property(x => x.DateOfBirth).HasColumnName(@"DateOfBirth").HasColumnType("datetime").IsOptional();
            Property(x => x.TradeLicenseDate).HasColumnName(@"TradeLicenseDate").HasColumnType("datetime").IsOptional();
            Property(x => x.TradeLicenseNo).HasColumnName(@"TradeLicenseNo").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(50);
            Property(x => x.Nationality).HasColumnName(@"Nationality").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.RegistrationAuthority).HasColumnName(@"RegistrationAuthority").HasColumnType("nvarchar")
                .IsOptional().HasMaxLength(50);
            Property(x => x.RegistrationNo).HasColumnName(@"RegistrationNo").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(50);
            Property(x => x.BirthCertificateNo).HasColumnName(@"BirthCertificateNo").HasColumnType("nvarchar")
                .IsOptional().HasMaxLength(25);
            Property(x => x.NationalId).HasColumnName(@"NationalId").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(25);
            Property(x => x.OccupationAndPosition).HasColumnName(@"OccupationAndPosition").HasColumnType("nvarchar")
                .IsOptional().HasMaxLength(100);
            Property(x => x.Position).HasColumnName(@"Position").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(100);
            Property(x => x.PassportNo).HasColumnName(@"PassportNo").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(50);
            Property(x => x.PassportExpireDate).HasColumnName(@"PassportExpireDate").HasColumnType("datetime")
                .IsOptional();
            Property(x => x.TinNo).HasColumnName(@"TINNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DrivingLicenseNo).HasColumnName(@"DrivingLicenseNo").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(50);
            Property(x => x.PresentAddress).HasColumnName(@"PresentAddress").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(300);
            Property(x => x.PermanentAddress).HasColumnName(@"PermanentAddress").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(300);
            Property(x => x.OfficeAddress).HasColumnName(@"OfficeAddress").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(300);
            Property(x => x.Mobile).HasColumnName(@"Mobile").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.AnotherCellNo).HasColumnName(@"AnotherCellNo").HasColumnType("nvarchar").IsOptional()
                .HasMaxLength(15);
            Property(x => x.Home).HasColumnName(@"Home").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Office).HasColumnName(@"Office").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CustomerIncomeSource).HasColumnName(@"CustomerIncomeSource").HasColumnType("nvarchar")
                .IsOptional().HasMaxLength(50);
            Property(x => x.TradeLicAuthority).HasColumnName(@"TradeLicAuthority").HasColumnType("nvarchar")
                .IsOptional().HasMaxLength(50);
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
            HasRequired(a => a.Branch).WithMany(b => b.Customers).HasForeignKey(c => c.BranchId)
                .WillCascadeOnDelete(false); // FK_Customer_Customer
            HasRequired(a => a.Company).WithMany(b => b.Customers).HasForeignKey(c => c.CompanyId)
                .WillCascadeOnDelete(false); // FK_Customer_Company
        }
    }
}