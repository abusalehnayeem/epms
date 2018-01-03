using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class AccountMasterRepository : Repository<AccountMaster>, IAccountMasterRepository
    {
        internal AccountMasterRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}