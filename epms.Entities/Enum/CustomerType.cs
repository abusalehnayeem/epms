using System.ComponentModel;

namespace epms.Entities.Enum
{
    public enum CustomerType
    {
        [Description("HOME USER")] Home = 0,
        [Description("OFFICE USER")] Bussiness = 1
    }
}