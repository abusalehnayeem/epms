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

        // BalanceSheetConfiguration
        [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
        public class BalanceSheetConfigurationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BalanceSheetConfiguration>
        {
            public BalanceSheetConfigurationConfiguration()
                : this("dbo")
            {
            }

            public BalanceSheetConfigurationConfiguration(string schema)
            {
                ToTable("BalanceSheetConfiguration", schema);
                HasKey(x => x.Id);

                //Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
                //Property(x => x.GroupId).HasColumnName(@"GroupId").HasColumnType("int").IsOptional();
                //Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsOptional();
                //Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
                //Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsOptional();
            }
        }

        #endregion

    }
    // </auto-generated>


}