using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerWriteRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}