using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderWriteRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}