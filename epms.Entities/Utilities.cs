using System.ComponentModel;

namespace epms.Entities
{
    public enum CustomerType
    {
        [Description("HOME USER")] Home,
        [Description("OFFICE USER")] Bussiness
    }

    public enum IdentificationType
    {
        [Description("National ID")] NID,
        [Description("Passport")] Passport,
        [Description("Driving Licence")] DrivingLicence,
        [Description("Birth Certificate")] BirthCertificate,
        [Description("Other")] Other
    }
}