using System;
using System.Collections.Generic;

namespace epms.Entities.Models
{
    public class Customer:BaseEntity
    {
        public Customer()
        {
            BillingsHistorys = new HashSet<BillingsHistory>();
        }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string Gender { get; set; }
        public DateTime? CustomerEntryDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? TradeLicenseDate { get; set; }
        public string TradeLicenseNo { get; set; }
        public string Nationality { get; set; }
        public string RegistrationAuthority { get; set; }
        public string RegistrationNo { get; set; }
        public string BirthCertificateNo { get; set; }
        public string NationalId { get; set; }
        public string OccupationAndPosition { get; set; }
        public string Position { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public string TinNo { get; set; }
        public string DrivingLicenseNo { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string OfficeAddress { get; set; }
        public string Mobile { get; set; }
        public string AnotherCellNo { get; set; }
        public string Home { get; set; }
        public string Office { get; set; }
        public string Email { get; set; }
        public string CustomerIncomeSource { get; set; }
        public string TradeLicAuthority { get; set; }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
    }
}