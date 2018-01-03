using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class AccountGroupRepository : Repository<AccountGroup>, IAccountGroupRepository
    {
        internal AccountGroupRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}