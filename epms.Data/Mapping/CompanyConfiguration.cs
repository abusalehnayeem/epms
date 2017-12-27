using epms.Entities.Models;

namespace epms.Data.Mapping
{
    public class CompanyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
            : this("dbo")
        {
        }

        public CompanyConfiguration(string schema)
        {
            ToTable("Company", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Logo).HasColumnName(@"Logo").HasColumnType("nvarchar").IsOptional().HasMaxLength(300);
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.CreatedDateTime).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsOptional();
            Property(x => x.UpdatedDateTime).HasColumnName(@"UpdatedDate").HasColumnType("datetime").IsOptional();
        }
    }
}