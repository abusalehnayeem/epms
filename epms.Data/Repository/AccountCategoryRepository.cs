using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class AccountCategoryRepository : Repository<AccountCategory>, IAccountCategoryRepository
    {
        internal AccountCategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}