using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class BranchRepository : Repository<Branch>, IBranchRepository
    {
        internal BranchRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}