using System;
using System.Collections.Generic;
using epms.Entities.Enum;

namespace epms.Entities.Models
{
    public class Customers : BaseEntity
    {
        public Customers()
        {
<<<<<<< HEAD
            BillingsHistory = new List<BillingsHistory>();
=======
            BillingsHistorys = new List<BillingsHistory>();
>>>>>>> 1c32f9f8b81997effd9a9217f18f9d7c7662dcce
        }

        public string CustomerNo { get; set; }
        public string Name { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public CustomerType CustomerType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string ContactPerson { get; set; }
        public string PhotoPath { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
<<<<<<< HEAD
        public ICollection<BillingsHistory> BillingsHistory { get; set; }
=======
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
>>>>>>> 1c32f9f8b81997effd9a9217f18f9d7c7662dcce
    }
}