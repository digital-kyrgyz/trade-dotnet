using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerReadRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}