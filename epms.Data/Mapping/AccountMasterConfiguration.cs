﻿namespace epms.Entities.Models
{


    // ------------------------------------------------------------------------------------------------
    // This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
    // Created by Simon Hughes (https://about.me/simon.hughes).
    //
    // Do not make changes directly to this file - edit the template instead.
    //
    // The following connection settings were used to generate this file:
    //     Configuration file:     "F:\asp.net\EPMS\epms.DataTest\App.config"
    //     Connection String Name: "MyDbContext"
    //     Connection String:      "Server= 127.0.0.1;Database=TestDB;User Id=sa;password=**zapped**;;"
    // ------------------------------------------------------------------------------------------------
    // Database Edition       : Data Center Edition
    // Database Engine Edition: Enterprise

    // <auto-generated>
    // ReSharper disable ConvertPropertyToExpressionBody
    // ReSharper disable DoNotCallOverridableMethodsInConstructor
    // ReSharper disable EmptyNamespace
    // ReSharper disable InconsistentNaming
    // ReSharper disable PartialMethodWithSinglePart
    // ReSharper disable PartialTypeWithSinglePart
    // ReSharper disable RedundantNameQualifier
    // ReSharper disable RedundantOverridenMember
    // ReSharper disable UseNameofExpression
    // TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


    namespace epms.Data.Mapping
    {
        #region POCO Configuration

        // AccountMaster
        [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
        public class AccountMasterConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AccountMaster>
        {
            public AccountMasterConfiguration()
                : this("dbo")
            {
            }

            public AccountMasterConfiguration(string schema)
            {
                ToTable("AccountMaster", schema);
                HasKey(x => x.Id);

                Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
                Property(x => x.AccountCode).HasColumnName(@"AccountCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
                Property(x => x.AccountName).HasColumnName(@"AccountName").HasColumnType("nvarchar(max)").IsRequired();
                Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
                Property(x => x.GroupId).HasColumnName(@"GroupId").HasColumnType("int").IsOptional();
                Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsOptional();
                Property(x => x.CompanyId).HasColumnName(@"CompanyId").HasColumnType("int").IsOptional();
                Property(x => x.IsTransactional).HasColumnName(@"IsTransactional").HasColumnType("bit").IsOptional();
                Property(x => x.OpeningBalanceDate).HasColumnName(@"OpeningBalanceDate").HasColumnType("datetime").IsOptional();
                Property(x => x.IsBankAccount).HasColumnName(@"IsBankAccount").HasColumnType("bit").IsOptional();
                Property(x => x.IsSubCode).HasColumnName(@"IsSubCode").HasColumnType("bit").IsOptional();
                Property(x => x.SubCodeId).HasColumnName(@"SubCodeId").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
                Property(x => x.Debit).HasColumnName(@"Debit").HasColumnType("numeric").IsOptional().HasPrecision(18, 2);
                Property(x => x.Credit).HasColumnName(@"Credit").HasColumnType("numeric").IsOptional().HasPrecision(18, 2);
                Property(x => x.BankName).HasColumnName(@"BankName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
                Property(x => x.BranchName).HasColumnName(@"BranchName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
                Property(x => x.BankAccountNo).HasColumnName(@"BankAccountNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
                Property(x => x.SupplierCode).HasColumnName(@"SupplierCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
                Property(x => x.SupplierName).HasColumnName(@"SupplierName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
                Property(x => x.SupplierCompany).HasColumnName(@"SupplierCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
                Property(x => x.ClientCode).HasColumnName(@"ClientCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
                Property(x => x.ClientName).HasColumnName(@"ClientName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
                Property(x => x.ClientCompany).HasColumnName(@"ClientCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
                Property(x => x.CPhone).HasColumnName(@"CPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
                Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
                Property(x => x.Remarks).HasColumnName(@"Remarks").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
                Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired();
                Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsOptional();

                // Foreign keys
                HasOptional(a => a.AccountCategory).WithMany(b => b.AccountMasters).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_AccountMaster_AccountCategory
                HasOptional(a => a.AccountGroup).WithMany(b => b.AccountMasters).HasForeignKey(c => c.GroupId).WillCascadeOnDelete(false); // FK_AccountMaster_AccountGroup
                HasOptional(a => a.Company).WithMany(b => b.AccountMasters).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false); // FK_AccountMaster_Company
            }
        }

        #endregion

    }
    // </auto-generated>


}
