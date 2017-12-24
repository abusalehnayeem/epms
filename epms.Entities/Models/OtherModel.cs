using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epms.Entities.Models
{

    public class Branch
    {
        public Branch()
        {
            this.LookUps = new List<LookUp>();
        }

        public short CompanyId { get; set; }
        public string BranchName { get; set; }
        public short BranchCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public short CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public short? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<LookUp> LookUps { get; set; }

    }

    public class Company
    {
        public Company()
        {
            this.Accounts = new List<Accounts>();
            this.Coas = new List<COA>();
            this.CoaCategories = new List<COACategory>();
            this.Csses = new List<Css>();
            this.Customers = new List<Customer>();
            this.DoubleBenefits = new List<DoubleBenefit>();
            this.FixedDeposites = new List<FixedDeposite>();
            this.InterestRates = new List<InterestRate>();
            this.InterestRateHistories = new List<InterestRateHistory>();
            this.Loans = new List<Loan>();
            this.LoanAccounts = new List<LoanAccount>();
            this.LoanAddtionalInfoes = new List<loanAddtionalInfo>();
            this.LoanInstallmentInformation = new List<LoanInstallmentInformation>();
            this.LoanScanDocuments = new List<loanScanDocument>();
            this.LoanSignatoryInfoes = new List<loanSignatoryInfo>();
            this.LookUps = new List<LookUp>();
            this.MonthlyBenefits = new List<MonthlyBenefit>();
            this.Roles = new List<Role>();
            this.Savings = new List<Savings>();
            this.Transactions = new List<Transactions>();
            this.UserDetails = new List<UserDetail>();
            this.UserDetails1 = new List<UserDetail>();
        }

        public short CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public short CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public short? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public List<Accounts> Accounts { get; set; }
        public List<COA> Coas { get; set; }
        public List<COACategory> CoaCategories { get; set; }
        public List<Css> Csses { get; set; }
        public List<Customer> Customers { get; set; }
        public List<DoubleBenefit> DoubleBenefits { get; set; }
        public List<FixedDeposite> FixedDeposites { get; set; }
        public List<InterestRate> InterestRates { get; set; }
        public List<InterestRateHistory> InterestRateHistories { get; set; }
        public List<Loan> Loans { get; set; }
        public List<LoanAccount> LoanAccounts { get; set; }
        public List<loanAddtionalInfo> LoanAddtionalInfoes { get; set; }
        public List<LoanInstallmentInformation> LoanInstallmentInformation { get; set; }
        public List<loanScanDocument> LoanScanDocuments { get; set; }
        public List<loanSignatoryInfo> LoanSignatoryInfoes { get; set; }
        public List<LookUp> LookUps { get; set; }
        public List<MonthlyBenefit> MonthlyBenefits { get; set; }
        public List<Role> Roles { get; set; }
        public List<Savings> Savings { get; set; }
        public List<Transactions> Transactions { get; set; }
        public List<UserDetail> UserDetails { get; set; }
        public List<UserDetail> UserDetails1 { get; set; }
    }

    public class LookUp:BaseEntity
    {
        public int? AccountTypeId { get; set; }
        public int? COAId { get; set; }
        public TypeSetup AccountTypeSetup { get; set; }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
    }

}
