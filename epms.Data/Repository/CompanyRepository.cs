using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        internal CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}