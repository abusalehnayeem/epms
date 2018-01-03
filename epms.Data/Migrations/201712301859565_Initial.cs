namespace epms.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryCode = c.String(maxLength: 100),
                        CategoryName = c.String(maxLength: 150),
                        GroupId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDateTime = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SortedBy = c.Int(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountGroup", t => t.GroupId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.GroupId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.AccountGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupCode = c.String(maxLength: 50),
                        GroupName = c.String(maxLength: 200),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDateTime = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsActive = c.Boolean(),
                        IsDeleted = c.Boolean(nullable: false),
                        SortedBy = c.Int(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.AccountMaster",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountCode = c.String(nullable: false, maxLength: 50),
                        AccountName = c.String(nullable: false),
                        Description = c.String(),
                        GroupId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        IsTransactional = c.Boolean(),
                        OpeningBalanceDate = c.DateTime(),
                        IsBankAccount = c.Boolean(),
                        IsSubCode = c.Boolean(),
                        SubCodeId = c.String(maxLength: 50),
                        Debit = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        Credit = c.Decimal(precision: 18, scale: 2, storeType: "numeric"),
                        BankName = c.String(maxLength: 200),
                        BranchName = c.String(maxLength: 200),
                        BankAccountNo = c.String(maxLength: 100),
                        SupplierCode = c.String(maxLength: 50),
                        SupplierName = c.String(maxLength: 100),
                        SupplierCompany = c.String(maxLength: 200),
                        ClientCode = c.String(maxLength: 50),
                        ClientName = c.String(maxLength: 100),
                        ClientCompany = c.String(maxLength: 200),
                        CPhone = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 20),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDateTime = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(),
                        SortedBy = c.Int(nullable: false),
                        Remarks = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountCategory", t => t.CategoryId)
                .ForeignKey("dbo.AccountGroup", t => t.GroupId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.GroupId)
                .Index(t => t.CategoryId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 100),
                        Logo = c.String(maxLength: 300),
                        Address = c.String(nullable: false, maxLength: 150),
                        Phone = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SortedBy = c.Int(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BillingsHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Month = c.String(),
                        BillingDate = c.DateTime(nullable: false),
                        UnitPrice = c.Double(),
                        Quentity = c.Int(),
                        TotalPrice = c.Double(),
                        VatAmount = c.Double(),
                        Discount = c.Double(),
                        PaidAmount = c.Double(),
                        PaidDate = c.DateTime(nullable: false),
                        BillStatus = c.Boolean(),
                        PackageId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(),
                        SortedBy = c.Int(),
                        Remarks = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .ForeignKey("dbo.Package", t => t.PackageId)
                .Index(t => t.PackageId)
                .Index(t => t.CustomerId)
                .Index(t => t.BranchId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchName = c.String(nullable: false, maxLength: 150),
                        BranchCode = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 150),
                        Phone = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDateTime = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SortedBy = c.Int(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(maxLength: 100),
                        CustomerImage = c.String(),
                        FatherName = c.String(maxLength: 100),
                        MotherName = c.String(maxLength: 100),
                        SpouseName = c.String(maxLength: 100),
                        Gender = c.String(maxLength: 20),
                        CustomerEntryDate = c.DateTime(),
                        DateOfBirth = c.DateTime(),
                        TradeLicenseDate = c.DateTime(),
                        TradeLicenseNo = c.String(maxLength: 50),
                        Nationality = c.String(maxLength: 100),
                        RegistrationAuthority = c.String(maxLength: 50),
                        RegistrationNo = c.String(maxLength: 50),
                        BirthCertificateNo = c.String(maxLength: 25),
                        NationalId = c.String(maxLength: 25),
                        OccupationAndPosition = c.String(maxLength: 100),
                        Position = c.String(maxLength: 100),
                        PassportNo = c.String(maxLength: 50),
                        PassportExpireDate = c.DateTime(),
                        TINNo = c.String(maxLength: 50),
                        DrivingLicenseNo = c.String(maxLength: 50),
                        PresentAddress = c.String(maxLength: 300),
                        PermanentAddress = c.String(maxLength: 300),
                        OfficeAddress = c.String(maxLength: 300),
                        Mobile = c.String(maxLength: 15),
                        AnotherCellNo = c.String(maxLength: 15),
                        Home = c.String(maxLength: 15),
                        Office = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        CustomerIncomeSource = c.String(maxLength: 50),
                        TradeLicAuthority = c.String(maxLength: 50),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(),
                        SortedBy = c.Int(),
                        Remarks = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.BranchId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Package",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Details = c.String(maxLength: 500),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActivatedDate = c.DateTime(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        IsApproved = c.Boolean(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(),
                        SortedBy = c.Int(),
                        Remarks = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.BranchId)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountCategory", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.AccountCategory", "GroupId", "dbo.AccountGroup");
            DropForeignKey("dbo.AccountGroup", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.AccountMaster", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.BillingsHistory", "PackageId", "dbo.Package");
            DropForeignKey("dbo.BillingsHistory", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.BillingsHistory", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.BillingsHistory", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Package", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.Package", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Customer", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.Customer", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Branch", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.AccountMaster", "GroupId", "dbo.AccountGroup");
            DropForeignKey("dbo.AccountMaster", "CategoryId", "dbo.AccountCategory");
            DropIndex("dbo.Package", new[] { "CompanyId" });
            DropIndex("dbo.Package", new[] { "BranchId" });
            DropIndex("dbo.Customer", new[] { "CompanyId" });
            DropIndex("dbo.Customer", new[] { "BranchId" });
            DropIndex("dbo.Branch", new[] { "CompanyId" });
            DropIndex("dbo.BillingsHistory", new[] { "CompanyId" });
            DropIndex("dbo.BillingsHistory", new[] { "BranchId" });
            DropIndex("dbo.BillingsHistory", new[] { "CustomerId" });
            DropIndex("dbo.BillingsHistory", new[] { "PackageId" });
            DropIndex("dbo.AccountMaster", new[] { "CompanyId" });
            DropIndex("dbo.AccountMaster", new[] { "CategoryId" });
            DropIndex("dbo.AccountMaster", new[] { "GroupId" });
            DropIndex("dbo.AccountGroup", new[] { "CompanyId" });
            DropIndex("dbo.AccountCategory", new[] { "CompanyId" });
            DropIndex("dbo.AccountCategory", new[] { "GroupId" });
            DropTable("dbo.Package");
            DropTable("dbo.Customer");
            DropTable("dbo.Branch");
            DropTable("dbo.BillingsHistory");
            DropTable("dbo.Company");
            DropTable("dbo.AccountMaster");
            DropTable("dbo.AccountGroup");
            DropTable("dbo.AccountCategory");
        }
    }
}
