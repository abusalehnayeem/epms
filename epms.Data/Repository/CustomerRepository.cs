using epms.Data.Context;
using epms.Entities.Models;
using epms.Entities.Repository;

namespace epms.Data.Repository
{
    internal class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        internal CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}