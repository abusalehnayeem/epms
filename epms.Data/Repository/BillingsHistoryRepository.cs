using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class BillingsHistoryRepository : Repository<BillingsHistory>, IBillingsHistoryRepository
    {
        internal BillingsHistoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}