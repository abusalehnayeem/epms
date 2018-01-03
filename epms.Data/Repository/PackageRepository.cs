using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class PackageRepository : Repository<Package>, IPackageRepository
    {
        internal PackageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}