using System.ComponentModel;

namespace epms.Entities.Enum
{
    public enum IdentificationType
    {
        [Description("National ID")] NID = 0,
        [Description("Passport")] Passport = 1,
        [Description("Driving Licence")] DrivingLicence = 2,
        [Description("Birth Certificate")] BirthCertificate = 3,
        [Description("Other")] Other = 4
    }
}