using System;
using System.Collections.Generic;
using epms.Entities.Enum;

namespace epms.Entities.Models
{
    public class Customers : BaseEntity
    {
        public Customers()
        {
            BillingsHistorys = new List<BillingsHistory>();
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
        public ICollection<BillingsHistory> BillingsHistorys { get; set; }
    }
}